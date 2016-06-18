using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Kreczmerowka
{
    [Serializable()]
    public class Problems
    {
        public List<Problem> ListOfProblems { get; set; }

        public static int Version { get; set; }
        public static string Author { get; set; }
        public static string Comment { get; set; }
        public static DateTime Modified { get; set; }

        public Problems()
        {
            ListOfProblems = new List<Problem>();
        }

        public bool LoadDatabase(string path)
        {
            try
            {
                ListOfProblems = QuestionDatabaseRepository.LoadFromFile(path).ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania pliku bazy:" + Environment.NewLine + exc.Message, "Kreczmerówka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool LoadDatabase(MemoryStream stream)
        {
            try
            {
                ListOfProblems = QuestionDatabaseRepository.LoadFromStream(stream).ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania pliku bazy:" + Environment.NewLine + exc.Message, "Kreczmerówka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void SaveDatabase(string path)
        {
            try
            {
                QuestionDatabaseRepository.SaveToFile(path, ListOfProblems);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania pliku bazy:" + Environment.NewLine + exc.Message, "Kreczmerówka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShuffleQuestions()
        {
            Random rng = new Random();
            int n = ListOfProblems.Count();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Problem value = ListOfProblems[k];
                ListOfProblems[k] = ListOfProblems[n];
                ListOfProblems[n] = value;
            }

            foreach (var item in ListOfProblems)
            {
                Random r = new Random();
                int x = item.Questions.Count();
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Question value = item.Questions[k];
                    item.Questions[k] = item.Questions[n];
                    item.Questions[n] = value;
                }
            }
        }
        
        public int Count()
        {
            return ListOfProblems.Count();
        }

        public Question GetQuestion(int problemId, int questionId)
        {
            return ListOfProblems[problemId].Questions[questionId];
        }
    }
}
