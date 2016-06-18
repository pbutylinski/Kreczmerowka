using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreczmerowka
{
    public partial class Summary : Form
    {
        private List<Answer> Answers = new List<Answer>();
        private List<Problem> Problems = new List<Problem>();

        public Summary(List<Answer> answers, List<Problem> problems)
        {
            InitializeComponent();

            Answers = answers;
            Problems = problems;
        }

        private void Summary_Load(object sender, EventArgs e) { LoadData(true, true, true); }

        private void ChangeQuestion(object sender, EventArgs e)
        {
            try
            {
                int problemId = Convert.ToInt32(lvAnswers.SelectedItems[0].Text);
                int questionId = Convert.ToInt32(lvAnswers.SelectedItems[0].SubItems[1].Text);

                tbQuestion.Text = Problems[problemId].Questions[questionId].Content;
                tbComment.Text = Problems[problemId].Questions[questionId].Notes;
                tbProblem.Text = Problems[problemId].Description;
            }
            catch (Exception) { }
        }

        private void LoadData(bool displayWrong, bool displayCorrect, bool displayNeutral)
        {
            lvAnswers.Items.Clear();

            foreach (var item in Answers)
            {
                ListViewItem Odp = new ListViewItem();

                Odp.Text = item.ProblemId.ToString();
                Odp.SubItems.Add(item.QuestionId.ToString());

                bool isCorrect =
                    item.Choice == UserChoice.Yes && Problems[item.ProblemId].Questions[item.QuestionId].CorrectAnswer ||
                    item.Choice == UserChoice.No && !Problems[item.ProblemId].Questions[item.QuestionId].CorrectAnswer;

                Odp.SubItems.Add(AnswerToString(item.Choice));

                Odp.SubItems.Add(item.Choice == UserChoice.DontKnow ? "-" : (isCorrect ? "Dobrze" : "Źle"));

                if (isCorrect && displayCorrect ||
                    !isCorrect && displayWrong && item.Choice != UserChoice.DontKnow ||
                    item.Choice == UserChoice.DontKnow && displayNeutral)
                    lvAnswers.Items.Add(Odp);
            }

            lvAnswers.Refresh();
        }

        private void Sortowanie(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: LoadData(true, true, true); break; //Pokaż wszystkie
                case 1: LoadData(true, false, true); break; //Błędne i niewiadome
                case 2: LoadData(true, false, false); break; //Tylko błędne
                case 3: LoadData(false, false, true); break; //Tylko niewiadome
                case 4: LoadData(false, true, false); break; //Tylko prawidłowe
                default: LoadData(true, true, true); break;
            }
        }

        string AnswerToString(UserChoice choice)
        {
            switch (choice)
            {
                case UserChoice.Yes: return "Tak";
                case UserChoice.No: return "Nie";
                case UserChoice.DontKnow: return "Nie wiem";
                default: return choice.ToString();
            }
        }
    }
}
