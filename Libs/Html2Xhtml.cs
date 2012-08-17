using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

using Corsis.Diagnostics;

namespace Corsis.Xhtml
{
    /// <summary>
    /// Doc types.
    /// </summary>
    public enum DocType
    {
        /// <summary>
        /// The program selects automatically either XHTML 1.0 Transitional or XHTML 1.0 Frameset depending on the input.
        /// </summary>
        Auto,
        Xhtml_1_0_Transitional,
        Xhtml_1_0_Strict,
        Xhtml_1_0_Frameset,
        Xhtml_Basic_1_0,
        Xhtml_1_1,
        Xhtml_MobileProfile_1_0,
        Xhtml_Basic_1_1,
        Xhtml_Print_1_0
    }

    /// <summary>
    /// A stream filter that converts HTML to XHTML. It is able to correct many common errors in input HTML.
    /// </summary>
    public static class Html2Xhtml
    {
        /// <summary>
        /// Runs Html2Xhtml as a filter on streams. Example: <c>var xhtmlString = Html2Xhtml.RunAsFilter(stdin =&gt; stdin.Write(htmlString)).ReadToEnd()</c>
        /// </summary>
        /// <param name="inputAction">An action on the standard input stream of Html2Xhtml. For example: <c>Html2Xhtml.RunAsFilter(stdin =&gt; stdin.Write(htmlString))</c>.</param>
        /// <param name="outputDocType">Doctype of the output XHTML file. If not specified, the program selects automatically either XHTML 1.0 Transitional or XHTML 1.0 Frameset depending on the input.</param>
        /// <param name="e">Instructs the program to propagate input chunks to the output even if it is unable to adapt them to the output XHTML doctype. Using this option, the XHTML output may be non-valid. Not using this option, some input data could be removed from the output in some [rare] cases.</param>
        /// <param name="inputEncodingName">Encoding name of the input stream. This option overrides the default input character set detection mechanism.</param>
        /// <param name="outputEncodingName">Encoding name of the output XHTML document stream. If this option is not present, the character set of the input is used as default.</param>
        /// <param name="lineLength">Number of characters per line. The default value is int.MaxValue. It must be greater than or equal to 40, otherwise the parameter is ignored.</param>
        /// <param name="tabLength">Tab length in number of characters. The default value is 0. It must be a number between 0 and 16, otherwise the parameter is ignored. Use 0 to avoid indentation in the output.</param>
        /// <param name="preserveWhitespaceInComments">Use this option to preserve white spaces, tabs and ends of lines in HTML comments. The default value is true. If set to false, space is rearranged.</param>
        /// <param name="noProtectCData">Enclose CDATA sections in "script" and "style" following the XHTML 1.0 specification (using "&lt;!CDATA[[" and"]]&gt;"). It might be incompatible with some browsers. The default in this version is to enclose CDATA sections using "//&lt;!CDATA[[" and "//]]&gt;", because major browsers handle it properly.</param>
        /// <param name="compactBlockElements">No white spaces or line breaks are written between the start tag of a block element and the start tag of its first enclosed inline element (or character data) and between the end tag of its last enclosed inline element (or character data) and the end tag of the block element. By default, if this option is not set, a new line character and indentation is written between them.</param>
        /// <param name="emptyElementTagsAlways">By default, empty element tags are written only for elements declared as empty in the DTD. This option makes any element not having content to be written with the empty element tag, even if it is not declared as empty in the DTD. This option may cause problems when the XHTML document is opened by browsers in HTML (tag soup) mode.</param>
        /// <param name="compactEmptyElementTags">Do not write a whitespace before the slash for empty element tags (i.e. write "&lt;br/&gt;" instead of the default "&lt;br /&gt;"). Note that although both notations are correct in XML, the XHTML 1.0 standard recommends the latter to improve compatibility with old browsers.</param>
        /// <param name="dosEndOfLine">Write the output XHTML file with DOS--style (CRLF) end of line, instead of the default UNIX--style end of line. Both end of line styles are allowed by the XML recommendation.</param>
        /// <returns>The standard output stream of Html2Xhtml.</returns>
        /// <exception cref="Corsis.Diagnostics.CommandNotFoundException">html2xhtml not installed in PATH.</exception>
        /// <example>
        /// In-memory string-to-string conversion: <c>var xhtmlString = Html2Xhtml.RunAsFilter(stdin =&gt; stdin.Write(htmlString)).ReadToEnd()</c>
        /// In-memory string-to-XDocument conversion: <c>var xdoc = Html2Xhtml.RunAsFilter(stdin =&gt; stdin.Write(htmlString)).ReadToXDocument()</c>
        /// </example>
        public static StreamReader RunAsFilter(
            Action<StreamWriter> inputAction,
            DocType outputDocType = DocType.Auto,
            bool e = false,
            string inputEncodingName = "utf-8",
            string outputEncodingName = "utf-8",
            int? lineLength = int.MaxValue,
            int? tabLength = 0,
            bool preserveWhitespaceInComments = true,
            bool noProtectCData = false,
            bool compactBlockElements = false,
            bool emptyElementTagsAlways = false,
            bool compactEmptyElementTags = false,
            bool dosEndOfLine = false)
        {
            var args = string.Join(" ",
                ToDocTypeKey(outputDocType),
                !e ? null : "-e",
                inputEncodingName == null ? null : "--ics " + inputEncodingName,
                outputEncodingName == null ? null : "--ocs " + outputEncodingName,
                !lineLength.HasValue ? null : "-l " + lineLength.ToString(),
                !tabLength.HasValue ? null : "-b " + tabLength.ToString(),
                !preserveWhitespaceInComments ? null : "--preserve-space-comments",
                !noProtectCData ? null : "--no-protect-cdata",
                !compactBlockElements ? null : "--compact-block-elements",
                !emptyElementTagsAlways ? null : "--empty-elm-tags-always",
                !compactEmptyElementTags ? null : "--compact-empty-elem-tags",
                !dosEndOfLine ? null : "--dos-eol");

            return "html2xhtml".RunAsFilter(
                inputAction,
                arguments: args,
                inputEncoding:  inputEncodingName  == null ? null : Encoding.GetEncoding(inputEncodingName),
                outputEncoding: outputEncodingName == null ? null : Encoding.GetEncoding(outputEncodingName));
        }

        static string ToDocTypeKey(DocType type)
        {
            switch (type)
            {
                case DocType.Xhtml_1_0_Transitional:
                    return "-t transitional";
                case DocType.Xhtml_1_0_Strict:
                    return "-t strict";
                case DocType.Xhtml_1_0_Frameset:
                    return "-t frameset";
                case DocType.Xhtml_Basic_1_0:
                    return "-t basic-1.0";
                case DocType.Xhtml_1_1:
                    return "-t 1.1";
                case DocType.Xhtml_MobileProfile_1_0:
                    return "-t mp";
                case DocType.Xhtml_Basic_1_1:
                    return "-t basic-1.1";
                case DocType.Xhtml_Print_1_0:
                    return "-t print-1.0";
            }
            return null;
        }

        /// <summary>
        /// Provides information about the encodings supported by Html2Xhtml.
        /// Html2Xhtml uses both .NET and libiconv-2 from the GNU Project to
        /// handle encodings. Any encoding you want to use should thus be 
        /// supported by both .NET and libiconv-2 under the same name.
        /// </summary>
        public static class SupportedEncodings
        {
            static HashSet<string> DotNetOnly;
            static HashSet<string> IConvOnly;
            static HashSet<string> Both;

            static SupportedEncodings()
            {
                GetSupportSets(out Both, out DotNetOnly, out IConvOnly);
            }

            /// <summary>
            /// Determines whether an encoding specified by its name is supported by Html2Xhtml.
            /// </summary>
            /// <param name="encodingName">The name of the encoding to check support for. For example: utf-8, iso-8859-1, etc.</param>
            /// <returns>true if the encoding specified by its name is supported by Html2Xhtml; otherwise, false.</returns>
            public static bool Contains(string encodingName)
            {
                return Both.Contains(encodingName.ToLowerInvariant());
            }

            /// <summary>
            /// Enumeration of all encoding names supported by Html2Xhtml.
            /// </summary>
            public static IEnumerable<string> Names
            {
                get { return Both; }
            }

            /// <summary>
            /// Determines encodings supported by Html2Xhtml.
            /// </summary>
            /// <param name="complete">When this method returns, contains the names of all encodings supported by Html2Xhtml.</param>
            /// <param name="dotNetOnly">When this method returns, contains the names of all encodings supported only by .NET.</param>
            /// <param name="iconvOnly">When this method returns, contains the names of all encodings supported only by libiconv-2.dll</param>
            public static void GetSupportSets(out HashSet<string> complete, out HashSet<string> dotNetOnly, out HashSet<string> iconvOnly)
            {
                var dotNetEncodings = Encoding.GetEncodings().Select(e => e.Name.ToLowerInvariant()).ToSet();
                var iconvEncodings = "html2xhtml".RunAsFilter(null, arguments: "--lcs").ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToSet();
                complete = dotNetEncodings.Intersect(iconvEncodings).ToSet();
                dotNetOnly = dotNetEncodings.Except(iconvEncodings).ToSet();
                iconvOnly = iconvEncodings.Except(dotNetEncodings).ToSet();
            }
        }
    }

    /// <summary>
    /// Some extension methods for convenience.
    /// </summary>
    public static class Html2XhtmlExtensions
    {
        /// <summary>
        /// A convenience method to read the output stream of Html2Xhtml directly into a System.Xml.Linq.XDocument instance.
        /// It uses Corsis.Xhtml.XhtmlNamedEntities to convert named entities to numeric entities so that they can be parsed
        /// without errors by System.Xml.Linq.XDocument.
        /// </summary>
        /// <param name="html2xhtmlOutput">The output stream reader of Html2Xhtml.</param>
        /// <param name="keepXhtmlNamespace">Determines whether to remove the xml namespace reference to allow easy navigation in the resulting System.Xml.Linq.XDocument instance.</param>
        /// <returns>A System.Xml.Linq.XDocument instance.</returns>
        public static XDocument ReadToXDocument(this StreamReader html2xhtmlOutput, bool keepXhtmlNamespace = false)
        {
            return html2xhtmlOutput.ReadToEnd().ToXDocument();
        }

        /// <summary>
        /// A convenience method to convert the output string of Html2Xhtml to a System.Xml.Linq.XDocument instance.
        /// It uses Corsis.Xhtml.XhtmlNamedEntities to convert named entities to numeric entities so that they can be parsed
        /// without errors by System.Xml.Linq.XDocument.
        /// </summary>
        /// <param name="html2xhtmlOutput">The output stream reader of Html2Xhtml.</param>
        /// <param name="keepXhtmlNamespace">Determines whether to remove the xml namespace reference to allow easy navigation in the resulting System.Xml.Linq.XDocument instance.</param>
        /// <returns>A System.Xml.Linq.XDocument instance.</returns>
        public static XDocument ToXDocument(this string html2xhtmlOutput, bool keepXhtmlNamespace = false)
        {
            var xhtml1 = html2xhtmlOutput.Trim();
            var xhtml2 = XhtmlNamedEntities.NameToNumber.Map(xhtml1);
            var xhtml3 = keepXhtmlNamespace ? xhtml2 : xhtml2.RipNamespace();
            return XDocument.Parse(xhtml3);
        }

        // <html xmlns="http://www.w3.org/1999/xhtml">
        static Regex xmlnsPattern = new Regex(@" xmlns=.http://www.w3.org/1999/xhtml.", RegexOptions.Compiled);

        /// <summary>
        /// Removes xmlns.
        /// </summary>
        public static string RipNamespace(this string xhtml)
        {
            return xmlnsPattern.Replace(xhtml, string.Empty, 1);
        }

        /// <summary>
        /// Creates a set from a collection.
        /// </summary>
        /// <returns>A hash set.</returns>
        public static HashSet<T> ToSet<T>(this IEnumerable<T> collection)
        {
            return new HashSet<T>(collection);
        }
    }
}

namespace Corsis.Diagnostics
{
    public static class Command
    {
        static readonly HashSet<int> pids = new HashSet<int>();
        static readonly Killer killer = new Killer();

        class Killer
        {
            ~Killer()
            {
                if (KillDangling)
                {
                    foreach (var pid in pids)
                    {
                        Process process = null;
                        try { process = Process.GetProcessById(pid); }
                        catch { }
                        if (process != null)
                        {
                            Console.WriteLine(" KILLED > {0}", process.Id);
                            process.Kill();
                        }
                    }
                }
            }
        }

        public static bool KillDangling = true;

        /// <summary>
        /// Runs a command as a filter on streams.
        /// </summary>
        /// <param name="command">The command to run.</param>
        /// <param name="inputAction">An action on the standard input stream of the command.</param>
        /// <param name="closeInputStreamAfterAction"></param>
        /// <param name="inputEncoding">Encoding of the input stream. If not specified, the system default is used.</param>
        /// <param name="outputEncoding">Encoding of the output XHTML document stream. If not specified, the system default is used.</param>
        /// <param name="arguments">Arguments to be </param>
        /// <param name="priorityClass"></param>
        /// <returns>The output stream of the command.</returns>
        public static StreamReader RunAsFilter(
            this string command,
            Action<StreamWriter> inputAction,
            bool closeInputStreamAfterAction = true,
            Encoding inputEncoding = null,
            Encoding outputEncoding = null,
            string arguments = null,
            ProcessPriorityClass? priorityClass = ProcessPriorityClass.RealTime)
        {
            try
            {
                var info = new ProcessStartInfo(command, arguments);
                info.UseShellExecute = false;
                info.CreateNoWindow = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                if (outputEncoding != null)
                    info.StandardOutputEncoding = outputEncoding;

                var process = Process.Start(info);
                if (priorityClass.HasValue)
                    process.PriorityClass = priorityClass.Value;
                
                var standardInput = inputEncoding == null ? process.StandardInput : new StreamWriter(process.StandardInput.BaseStream, inputEncoding);
                if (inputAction != null)
                    inputAction(standardInput);
                if (closeInputStreamAfterAction)
                    standardInput.Close();

                if (KillDangling)
                    pids.Add(process.Id);

                return process.StandardOutput;
            }
            catch (Exception inner)
            {
                throw new CommandNotFoundException(string.Format("Command not found: [{0}]", command), inner);
            }
        }
    }

    [global::System.Serializable]
    public class CommandNotFoundException : ApplicationException
    {
        public CommandNotFoundException() { }
        public CommandNotFoundException(string message) : base(message) { }
        public CommandNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected CommandNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}