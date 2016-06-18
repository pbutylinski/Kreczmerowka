using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Kreczmerowka
{
    public partial class MainWindow : Form
    {
        private Problems AllProblems = new Problems();
        private List<Answer> ListOfAnsers = new List<Answer>();

        private int QuestionCount { get; set; }
        private Mode CurrentMode { get; set; }
        private bool ShowMessages { get; set; }
        private bool InternetDatabase { get; set; }

        private int QuestionId { get; set; }
        private int ProblemId { get; set; }

        private static string Sciezka = Application.StartupPath + @"\BazaPytan.xml";
        private static string SciezkaUrl = @"http://lemurr.pl/kreczmerowka/NowaBaza.xml";

        public MainWindow()
        {
            CurrentMode = Mode.Learning;

            ShowMessages = false;
            InternetDatabase = false;

            InitializeComponent();
            QuestionId = ProblemId = 0;

            AllProblems.LoadDatabase(Sciezka);
            if (AllProblems.Count() > 0) LoadQuestion();

            Hide();
        }

        private void Hide()
        {
            rbAnswerNo.Visible =
                rbtnYes.Visible =
                btnSave.Visible = false;

            tbUpper.ReadOnly =
                tbLower.ReadOnly =
                tbNotes.ReadOnly = true;

            tbUpper.BackColor =
                tbLower.BackColor =
                tbNotes.BackColor = Color.White;

            label1.Visible =
                label3.Visible =
                lblIncorrectCount.Visible =
                lblCorrectCount.Visible =
                tbNotes.Visible =
                btnNextQuestion.Visible =
                btnNextProblem.Visible =
                btnPreviousQuestion.Visible =
                btnPreviousProblem.Visible =
                lblResults.Visible =
                lblProblemId.Visible = true;

            panel1.BackColor = SystemColors.Control;

            miEditingAnswers.Checked = (CurrentMode == Mode.Editing);
            miLearning.Checked = (CurrentMode == Mode.Learning);
            miExam12Questions.Checked = (CurrentMode == Mode.Exam);

            if (CurrentMode == Mode.Editing)
            {
                panel1.BackColor = Color.Orange;

                rbAnswerNo.Visible =
                    rbtnYes.Visible =
                    btnSave.Visible = true;

                tbUpper.ReadOnly =
                    tbLower.ReadOnly =
                    tbNotes.ReadOnly = false;
            }
            else if (CurrentMode == Mode.Exam)
            {
                label1.Visible =
                    label3.Visible =
                    lblIncorrectCount.Visible =
                    lblCorrectCount.Visible =
                    tbNotes.Visible =
                    btnNextQuestion.Visible =
                    btnNextProblem.Visible =
                    btnPreviousQuestion.Visible =
                    btnPreviousProblem.Visible =
                    lblResults.Visible =
                    lblProblemId.Visible = false;
            }
        }

        private void LoadQuestion()
        {
            tbUpper.Text = AllProblems.ListOfProblems[ProblemId].Description;
            lblProblemId.Text = "[" + (QuestionId + 1).ToString() + "-" + (ProblemId + 1).ToString() + "]  " + AllProblems.ListOfProblems[ProblemId].Code;
            tbLower.Text = AllProblems.GetQuestion(ProblemId, QuestionId).Content;
            tbNotes.Text = (CurrentMode == Mode.Editing) ? AllProblems.GetQuestion(ProblemId, QuestionId).Notes : "";

            if (AllProblems.GetQuestion(ProblemId, QuestionId).CorrectAnswer)
                rbtnYes.Select();
            else rbAnswerNo.Select();

            ToggleAnswerButtons(true);
            btnAnswerYes.BackColor = btnAnswerNo.BackColor = SystemColors.Control;
        }

        private void NextQuestion()
        {
            if (AllProblems.Count() == 0) return;
            btnAnswerYes.Enabled = btnAnswerNo.Enabled = true;

            if (QuestionId >= (AllProblems.ListOfProblems[ProblemId].Questions.Count() - 1))
            {
                QuestionId = 0;
                ProblemId = ProblemId >= AllProblems.Count() - 1 ? 0 : ProblemId + 1;
            }
            else QuestionId++;

            LoadQuestion();
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Editing) SaveQuestion();
            NextQuestion();
        }

        private void NextProblem(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Editing) SaveQuestion();
            QuestionId = 0;
            ProblemId = ProblemId >= AllProblems.Count() - 1 ? 0 : ProblemId + 1;
            LoadQuestion();
        }

        private void LearningMode(object sender, EventArgs e)
        {
            CurrentMode = Mode.Learning;
            Hide();
        }

        private void EditingMode(object sender, EventArgs e)
        {
            CurrentMode = Mode.Editing;
            Hide();
            LoadQuestion();
        }

        private void SaveQuestion()
        {
            AllProblems.ListOfProblems[ProblemId].Description = tbUpper.Text;
            AllProblems.GetQuestion(ProblemId, QuestionId).Content = tbLower.Text;
            AllProblems.GetQuestion(ProblemId, QuestionId).CorrectAnswer = rbtnYes.Checked;
            AllProblems.GetQuestion(ProblemId, QuestionId).Notes = tbNotes.Text;
        }

        private void UpdatePoints()
        {
            int correct = 0;
            int incorrect = 0;
            int neutral = 0;

            foreach (var item in ListOfAnsers)
                switch (item.Choice)
                {
                    case UserChoice.Yes:
                        if (AllProblems.ListOfProblems[item.ProblemId].Questions[item.QuestionId].CorrectAnswer) correct++;
                        else incorrect++;
                        break;
                    case UserChoice.No:
                        if (AllProblems.ListOfProblems[item.ProblemId].Questions[item.QuestionId].CorrectAnswer) incorrect++;
                        else correct++;
                        break;
                    case UserChoice.DontKnow:
                        neutral++;
                        break;
                    default: break;
                }

            int Suma = ListOfAnsers.Count();

            lblCorrectCount.Text = correct.ToString();
            lblIncorrectCount.Text = incorrect.ToString();

            float Wyniki = Suma != 0 ? 100.00F * (correct - incorrect) / Suma : 0;

            lblResults.Text = Wyniki.ToString("0.00") + "%";
            CalkowitaIloscOdpLabel.Text = Suma.ToString();

            if ((CurrentMode == Mode.Exam) && Suma == QuestionCount)
            {
                CurrentMode = Mode.Learning;
                MessageBox.Show("Koniec Kreczmerówki!");
                Hide();

                Summary P = new Summary(ListOfAnsers, AllProblems.ListOfProblems);
                P.Show();
            }
        }

        private void ToggleAnswerButtons(bool enabled)
        {
            btnAnswerNo.Enabled = btnAnswerYes.Enabled = btnAnswerDontKnow.Enabled = enabled;
        }

        private void AnswerYes(object sender, EventArgs e)
        {
            ListOfAnsers.Add(new Answer(QuestionId, ProblemId, UserChoice.Yes));

            if (ShowMessages)
            {
                bool isAnswered = AllProblems.GetQuestion(ProblemId, QuestionId).CorrectAnswer;
                MessageBox.Show(isAnswered ? "Poprawna odpowiedź!" : "Źle! Do roboty leniu!", "Huehuehue");
            }

            tbNotes.Text = AllProblems.GetQuestion(ProblemId, QuestionId).Notes;

            if (CurrentMode != Mode.Exam)
            {
                ToggleAnswerButtons(false);
            }
            else
            {
                NextQuestion();
            }

            UpdatePoints();
        }

        private void AnswerNo(object sender, EventArgs e)
        {
            ListOfAnsers.Add(new Answer(QuestionId, ProblemId, UserChoice.No));

            if (ShowMessages)
            {
                bool isAnswered = AllProblems.GetQuestion(ProblemId, QuestionId).CorrectAnswer;
                MessageBox.Show(!isAnswered ? "Poprawna odpowiedź!" : "Źle! Do roboty leniu!", "Huehuehue");
            }

            tbNotes.Text = AllProblems.GetQuestion(ProblemId, QuestionId).Notes;

            if (CurrentMode != Mode.Exam)
            {
                ToggleAnswerButtons(false);
            }
            else
            {
                NextQuestion();
            }

            UpdatePoints();
        }

        private void AnswerDontKnow(object sender, EventArgs e)
        {
            ListOfAnsers.Add(new Answer(QuestionId, ProblemId, UserChoice.DontKnow));

            if (ShowMessages)
            {
                MessageBox.Show("Nie wiedziałeś? OMG WTF Prof. Kreczmer nie byłby zadowolony :/", "LOL");
            }

            if (CurrentMode != Mode.Exam)
            {
                tbNotes.Text = AllProblems.GetQuestion(ProblemId, QuestionId).Notes;
                ToggleAnswerButtons(false);

                if (AllProblems.GetQuestion(ProblemId, QuestionId).CorrectAnswer)
                {
                    btnAnswerYes.BackColor = Color.LightGreen;
                }
                else
                {
                    btnAnswerNo.BackColor = Color.LightGreen;
                }

            }
            else NextQuestion();

            UpdatePoints();
        }

        private void PreviousQuestion(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Editing) SaveQuestion();

            if (QuestionId == 0)
            {
                ProblemId = ProblemId == 0 ? AllProblems.Count() - 1 : ProblemId - 1;
                QuestionId = AllProblems.ListOfProblems[ProblemId].Questions.Count() - 1;
            }
            else QuestionId--;

            LoadQuestion();
        }

        private void PreviousProblem(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Editing) SaveQuestion();

            QuestionId = 0;
            ProblemId = ProblemId == 0 ? AllProblems.Count() - 1 : ProblemId - 1;
            LoadQuestion();
        }

        private void Help(object sender, EventArgs e)
        {
            var ab = new AboutBox();
            ab.Visible = true;
        }

        private void OpenDatabaseFile(object sender, EventArgs e)
        {
            OtworzBazeFileDialog.ShowDialog();

            if (OtworzBazeFileDialog.FileName.Length > 0)
            {
                Sciezka = OtworzBazeFileDialog.FileName;

                AllProblems.ListOfProblems = new List<Problem>();

                if (AllProblems.LoadDatabase(Sciezka))
                {
                    MessageBox.Show("Bazę wczytano pomyślnie", "Sukces");
                }
                else
                {
                    MessageBox.Show("Nie można było wczytać bazy", "Porażka");
                }

                if (AllProblems.Count() > 0) LoadQuestion();

                InternetDatabase = false;
            }
        }

        private void OpenFromServer(object sender, EventArgs e)
        {
            try
            {
                var Plik = new WebClient().DownloadString(SciezkaUrl);
                MemoryStream Strumien = new MemoryStream(Encoding.Default.GetBytes(Plik));
                AllProblems.LoadDatabase(Strumien);

                MessageBox.Show("Bazę wczytano pomyślnie", "Sukces");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się pobrać pliku!", "Wystąpił błąd");
            }

            if (AllProblems.Count() > 0) LoadQuestion();

            InternetDatabase = true;
        }

        private void SaveDatabase(object sender, EventArgs e)
        {
            SaveQuestion();
            AllProblems.SaveDatabase(Sciezka);
        }

        private void ShowMessageAfterEachAnswer(object sender, EventArgs e)
        {
            ShowMessages = !miShowMessagesAfterEachAnswer.Checked;
            miShowMessagesAfterEachAnswer.Checked = ShowMessages;
        }

        private void ShuffleQuestion(object sender, EventArgs e)
        {
            AllProblems.ShuffleQuestions();
            QuestionId = 0;
            LoadQuestion();
        }

        private void ResetCounters(object sender, EventArgs e)
        {
            ListOfAnsers.Clear();
            UpdatePoints();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnAnswerYes.Enabled && (CurrentMode != Mode.Editing))
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                    case Keys.B: AnswerYes(sender, e); break;
                    case Keys.X:
                    case Keys.N: AnswerNo(sender, e); break;
                    case Keys.C:
                    case Keys.M: AnswerDontKnow(sender, e); break;
                    default: break;
                }
            }

            if (CurrentMode != Mode.Exam)
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                    case Keys.Right: NextQuestion(sender, e); break;
                    case Keys.Left: PreviousQuestion(sender, e); break;
                    default: break;
                }
            }
        }

        private void StartOver(object sender, EventArgs e)
        {
            ProblemId = QuestionId = 0;
            LoadQuestion();
        }

        private void DatabaseInfo(object sender, EventArgs e)
        {
            string readablePath = InternetDatabase ? "z serwera (lemurr.pl)" : Sciezka;

            string msg = String.Format("Wczytana baza: {0}\n\nZawiera ona {1} problemów oraz łącznie {2} pytań do nich",
                readablePath,
                AllProblems.Count(), 
                AllProblems.ListOfProblems.Sum(k => k.Questions.Count()));

            MessageBox.Show(msg, "Informacje o bazie");
        }

        private void Summary(object sender, EventArgs e)
        {
            Summary P = new Summary(ListOfAnsers, AllProblems.ListOfProblems);
            P.Show();
        }

        private void StartTest(int questionCount)
        {
            QuestionCount = questionCount;

            CurrentMode = Mode.Exam;
            Hide();

            Random r = new Random(DateTime.Now.Millisecond);
            ProblemId = r.Next(0, AllProblems.Count() - 1);

            QuestionId = 0;
            LoadQuestion();
        }

        private void Kreczmerowka12(object sender, EventArgs e) { StartTest(12); }

        private void Kreczmerowka26(object sender, EventArgs e) { StartTest(26); }

        private void Kreczmerowka128(object sender, EventArgs e) { StartTest(128); }
    }
}
