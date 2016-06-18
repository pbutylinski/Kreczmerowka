using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Kreczmerowka
{
    public static class QuestionDatabaseRepository
    {
        private static XmlSerializer XmlSer = new XmlSerializer(typeof(List<Problem>));

        public static IEnumerable<Problem> LoadFromStream(MemoryStream stream)
        {
            var problems = new List<Problem>();

            stream.Seek(0, SeekOrigin.Begin);

            problems = (List<Problem>)XmlSer.Deserialize(stream);

            foreach (var item in problems)
            {
                item.Description = item.Description.Replace("\n", Environment.NewLine);

                foreach (var i in item.Questions)
                {
                    i.Notes = i.Notes.Replace("\n", Environment.NewLine).Replace("&lt;", "<").Replace("&gt;", ">");
                    i.Content = i.Content.Replace("\n", Environment.NewLine).Replace("&lt;", "<").Replace("&gt;", ">");
                }
            }

            return problems;
        }

        public static IEnumerable<Problem> LoadFromFile(string filename)
        {
            File.SetAttributes(filename, FileAttributes.Normal);

            using (var fs = new FileStream(filename, FileMode.Open))
            using (var ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return LoadFromStream(ms);
            }
        }

        public static void SaveToFile(string path, IEnumerable<Problem> problems)
        {
            using (var sw = new StreamWriter(path, false))
            {
                XmlSer.Serialize(sw, problems);
                sw.Close();
            }
        }
    }
}
