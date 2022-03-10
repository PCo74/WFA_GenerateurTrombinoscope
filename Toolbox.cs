using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WFA_GenerateurTrombinoscope
{
    public class Toolbox
    {
        // https://stackoverflow.com/questions/620605/how-to-make-a-valid-windows-filename-from-an-arbitrary-string
        public static string getValidFileName(string aFileName)
        {
            string result = (aFileName != string.Empty) ? aFileName : "filename";
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                result = result.Replace(c, '_');
            }
            return result;
        }

        public static string[] getFilesFromFolder(string aPath, string aExtension)
        {
            return Directory.EnumerateFiles(aPath, "*."+ aExtension, SearchOption.TopDirectoryOnly).ToArray();
        }

        public static string[] getFilesFromFolder(string aPath, string[] aExtensions)
        {
            DirectoryInfo directory = new DirectoryInfo(aPath);
            var liste = (aExtensions.SelectMany(m => directory.EnumerateFiles(m))).Select(l => l.FullName);
            //var files = liste.Select(l => l.FullName);
            return liste.ToArray();
        }

        // REF : https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
        public static Encoding getEncoding(string unFicCSV)
        {
            using (StreamReader sr = new StreamReader(unFicCSV, Encoding.UTF8))
            {
                string content = sr.ReadToEnd();
                Regex regex = new Regex("�");
                int nbc = regex.Matches(content).Count;
                return (nbc != 0) ? Encoding.GetEncoding(1252) : Encoding.GetEncoding(65001);
            }
        }

        // REF : https://stackoverflow.com/questions/28558336/how-to-put-html-code-into-a-resx-resource-file
        public static string ReadTextResourceFromAssembly(string name)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
            {
                return new StreamReader(stream).ReadToEnd();
            }
        }
    }
}
