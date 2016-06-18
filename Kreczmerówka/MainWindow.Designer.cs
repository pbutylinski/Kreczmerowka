namespace Kreczmerowka
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnPreviousProblem = new System.Windows.Forms.Button();
            this.btnPreviousQuestion = new System.Windows.Forms.Button();
            this.rbAnswerNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.btnNextProblem = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnAnswerDontKnow = new System.Windows.Forms.Button();
            this.btnAnswerNo = new System.Windows.Forms.Button();
            this.btnAnswerYes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProblemId = new System.Windows.Forms.Label();
            this.CalkowitaIloscOdpLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowMessagesAfterEachAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.przejdźDoPoczątkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOWczytanejBazieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsumowanieOdpowiedziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLearning = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditingAnswers = new System.Windows.Forms.ToolStripMenuItem();
            this.miExam12Questions = new System.Windows.Forms.ToolStripMenuItem();
            this.Kreczmerowka26PytanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Kreczmerowka128PytanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbUpper = new System.Windows.Forms.TextBox();
            this.tbLower = new System.Windows.Forms.TextBox();
            this.OtworzPlikFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OtworzBazeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.otwórzPlikBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujLicznikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pytaniaLosowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblResults);
            this.panel1.Controls.Add(this.btnPreviousProblem);
            this.panel1.Controls.Add(this.btnPreviousQuestion);
            this.panel1.Controls.Add(this.rbAnswerNo);
            this.panel1.Controls.Add(this.rbtnYes);
            this.panel1.Controls.Add(this.btnNextProblem);
            this.panel1.Controls.Add(this.btnNextQuestion);
            this.panel1.Controls.Add(this.btnAnswerDontKnow);
            this.panel1.Controls.Add(this.btnAnswerNo);
            this.panel1.Controls.Add(this.btnAnswerYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 101);
            this.panel1.TabIndex = 0;
            // 
            // ZapiszButton
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(680, 25);
            this.btnSave.Name = "ZapiszButton";
            this.btnSave.Size = new System.Drawing.Size(110, 51);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveDatabase);
            // 
            // WynikLabel
            // 
            this.lblResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResults.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResults.Location = new System.Drawing.Point(718, 0);
            this.lblResults.Name = "WynikLabel";
            this.lblResults.Size = new System.Drawing.Size(266, 101);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "0,00%";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoprzedniProblemButton
            // 
            this.btnPreviousProblem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviousProblem.Location = new System.Drawing.Point(36, 51);
            this.btnPreviousProblem.Name = "PoprzedniProblemButton";
            this.btnPreviousProblem.Size = new System.Drawing.Size(142, 25);
            this.btnPreviousProblem.TabIndex = 9;
            this.btnPreviousProblem.Text = "Poprzedni problem";
            this.btnPreviousProblem.UseVisualStyleBackColor = true;
            this.btnPreviousProblem.Click += new System.EventHandler(this.PreviousProblem);
            // 
            // PoprzedniePytanieButton
            // 
            this.btnPreviousQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviousQuestion.Location = new System.Drawing.Point(36, 25);
            this.btnPreviousQuestion.Name = "PoprzedniePytanieButton";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(142, 25);
            this.btnPreviousQuestion.TabIndex = 8;
            this.btnPreviousQuestion.Text = "Poprzednie pytanie";
            this.btnPreviousQuestion.UseVisualStyleBackColor = true;
            this.btnPreviousQuestion.Click += new System.EventHandler(this.PreviousQuestion);
            // 
            // OdpNieRadioButton
            // 
            this.rbAnswerNo.AutoSize = true;
            this.rbAnswerNo.Location = new System.Drawing.Point(347, 82);
            this.rbAnswerNo.Name = "OdpNieRadioButton";
            this.rbAnswerNo.Size = new System.Drawing.Size(14, 13);
            this.rbAnswerNo.TabIndex = 6;
            this.rbAnswerNo.TabStop = true;
            this.rbAnswerNo.UseVisualStyleBackColor = true;
            // 
            // OdpTakRadioButton
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(233, 82);
            this.rbtnYes.Name = "OdpTakRadioButton";
            this.rbtnYes.Size = new System.Drawing.Size(14, 13);
            this.rbtnYes.TabIndex = 5;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // NastepnyProblemButton
            // 
            this.btnNextProblem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextProblem.Location = new System.Drawing.Point(532, 51);
            this.btnNextProblem.Name = "NastepnyProblemButton";
            this.btnNextProblem.Size = new System.Drawing.Size(142, 25);
            this.btnNextProblem.TabIndex = 4;
            this.btnNextProblem.Text = "Następny problem";
            this.btnNextProblem.UseVisualStyleBackColor = true;
            this.btnNextProblem.Click += new System.EventHandler(this.NextProblem);
            // 
            // NastepnePytanieBtn
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextQuestion.Location = new System.Drawing.Point(532, 25);
            this.btnNextQuestion.Name = "NastepnePytanieBtn";
            this.btnNextQuestion.Size = new System.Drawing.Size(142, 25);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.Text = "Następne pytanie";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.NextQuestion);
            // 
            // OdNieWiemButton
            // 
            this.btnAnswerDontKnow.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnswerDontKnow.Location = new System.Drawing.Point(416, 25);
            this.btnAnswerDontKnow.Name = "OdNieWiemButton";
            this.btnAnswerDontKnow.Size = new System.Drawing.Size(110, 51);
            this.btnAnswerDontKnow.TabIndex = 2;
            this.btnAnswerDontKnow.Text = "NIE WIEM";
            this.btnAnswerDontKnow.UseVisualStyleBackColor = true;
            this.btnAnswerDontKnow.Click += new System.EventHandler(this.AnswerDontKnow);
            // 
            // OdpNieButton
            // 
            this.btnAnswerNo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnswerNo.Location = new System.Drawing.Point(300, 25);
            this.btnAnswerNo.Name = "OdpNieButton";
            this.btnAnswerNo.Size = new System.Drawing.Size(110, 51);
            this.btnAnswerNo.TabIndex = 1;
            this.btnAnswerNo.Text = "NIE";
            this.btnAnswerNo.UseVisualStyleBackColor = true;
            this.btnAnswerNo.Click += new System.EventHandler(this.AnswerNo);
            // 
            // OdpTakButton
            // 
            this.btnAnswerYes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnswerYes.Location = new System.Drawing.Point(184, 25);
            this.btnAnswerYes.Name = "OdpTakButton";
            this.btnAnswerYes.Size = new System.Drawing.Size(110, 51);
            this.btnAnswerYes.TabIndex = 0;
            this.btnAnswerYes.Text = "TAK";
            this.btnAnswerYes.UseVisualStyleBackColor = true;
            this.btnAnswerYes.Click += new System.EventHandler(this.AnswerYes);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProblemId);
            this.panel2.Controls.Add(this.CalkowitaIloscOdpLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblIncorrectCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCorrectCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbNotes);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(715, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.panel2.Size = new System.Drawing.Size(269, 464);
            this.panel2.TabIndex = 1;
            // 
            // IDProblemuLabel
            // 
            this.lblProblemId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProblemId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProblemId.Location = new System.Drawing.Point(1, 184);
            this.lblProblemId.Name = "IDProblemuLabel";
            this.lblProblemId.Size = new System.Drawing.Size(265, 36);
            this.lblProblemId.TabIndex = 16;
            this.lblProblemId.Text = "Brak wczytanych pytań";
            this.lblProblemId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalkowitaIloscOdpLabel
            // 
            this.CalkowitaIloscOdpLabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.CalkowitaIloscOdpLabel.Location = new System.Drawing.Point(189, 122);
            this.CalkowitaIloscOdpLabel.Name = "CalkowitaIloscOdpLabel";
            this.CalkowitaIloscOdpLabel.Size = new System.Drawing.Size(68, 33);
            this.CalkowitaIloscOdpLabel.TabIndex = 15;
            this.CalkowitaIloscOdpLabel.Text = "0";
            this.CalkowitaIloscOdpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Całkowita ilość odpowiedzi:";
            // 
            // IloscBlednychLabel
            // 
            this.lblIncorrectCount.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblIncorrectCount.Location = new System.Drawing.Point(189, 89);
            this.lblIncorrectCount.Name = "IloscBlednychLabel";
            this.lblIncorrectCount.Size = new System.Drawing.Size(68, 33);
            this.lblIncorrectCount.TabIndex = 13;
            this.lblIncorrectCount.Text = "0";
            this.lblIncorrectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ilość błędnych odpowiedzi:";
            // 
            // IloscPoprawnychLabel
            // 
            this.lblCorrectCount.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblCorrectCount.Location = new System.Drawing.Point(189, 56);
            this.lblCorrectCount.Name = "IloscPoprawnychLabel";
            this.lblCorrectCount.Size = new System.Drawing.Size(68, 33);
            this.lblCorrectCount.TabIndex = 11;
            this.lblCorrectCount.Text = "0";
            this.lblCorrectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ilość poprawnych odpowiedzi:";
            // 
            // NotatkaTextBox
            // 
            this.tbNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbNotes.Font = new System.Drawing.Font("Courier New", 10F);
            this.tbNotes.Location = new System.Drawing.Point(1, 220);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "NotatkaTextBox";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNotes.Size = new System.Drawing.Size(265, 241);
            this.tbNotes.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.trybToolStripMenuItem,
            this.oToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzPlikBazyDanychToolStripMenuItem,
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem,
            this.resetujLicznikiToolStripMenuItem,
            this.pytaniaLosowoToolStripMenuItem,
            this.miShowMessagesAfterEachAnswer,
            this.przejdźDoPoczątkuToolStripMenuItem,
            this.informacjeOWczytanejBazieToolStripMenuItem,
            this.podsumowanieOdpowiedziToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.plikToolStripMenuItem.Text = "Opcje";
            // 
            // komunikatPoKażdejOdpowiedziToolStripMenuItem
            // 
            this.miShowMessagesAfterEachAnswer.Name = "komunikatPoKażdejOdpowiedziToolStripMenuItem";
            this.miShowMessagesAfterEachAnswer.Size = new System.Drawing.Size(249, 22);
            this.miShowMessagesAfterEachAnswer.Text = "Komunikat po każdej odpowiedzi";
            this.miShowMessagesAfterEachAnswer.Click += new System.EventHandler(this.ShowMessageAfterEachAnswer);
            // 
            // przejdźDoPoczątkuToolStripMenuItem
            // 
            this.przejdźDoPoczątkuToolStripMenuItem.Name = "przejdźDoPoczątkuToolStripMenuItem";
            this.przejdźDoPoczątkuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.przejdźDoPoczątkuToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.przejdźDoPoczątkuToolStripMenuItem.Text = "Przejdź do początku";
            this.przejdźDoPoczątkuToolStripMenuItem.Click += new System.EventHandler(this.StartOver);
            // 
            // informacjeOWczytanejBazieToolStripMenuItem
            // 
            this.informacjeOWczytanejBazieToolStripMenuItem.Name = "informacjeOWczytanejBazieToolStripMenuItem";
            this.informacjeOWczytanejBazieToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.informacjeOWczytanejBazieToolStripMenuItem.Text = "Informacje o wczytanej bazie";
            this.informacjeOWczytanejBazieToolStripMenuItem.Click += new System.EventHandler(this.DatabaseInfo);
            // 
            // podsumowanieOdpowiedziToolStripMenuItem
            // 
            this.podsumowanieOdpowiedziToolStripMenuItem.Name = "podsumowanieOdpowiedziToolStripMenuItem";
            this.podsumowanieOdpowiedziToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.podsumowanieOdpowiedziToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.podsumowanieOdpowiedziToolStripMenuItem.Text = "Podsumowanie odpowiedzi";
            this.podsumowanieOdpowiedziToolStripMenuItem.Click += new System.EventHandler(this.Summary);
            // 
            // trybToolStripMenuItem
            // 
            this.trybToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLearning,
            this.miEditingAnswers,
            this.miExam12Questions,
            this.Kreczmerowka26PytanMenu,
            this.Kreczmerowka128PytanMenu});
            this.trybToolStripMenuItem.Name = "trybToolStripMenuItem";
            this.trybToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.trybToolStripMenuItem.Text = "Tryb";
            // 
            // naukaToolStripMenuItem
            // 
            this.miLearning.Name = "naukaToolStripMenuItem";
            this.miLearning.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miLearning.Size = new System.Drawing.Size(229, 22);
            this.miLearning.Text = "Nauka";
            this.miLearning.Click += new System.EventHandler(this.LearningMode);
            // 
            // poprawianiePytańToolStripMenuItem
            // 
            this.miEditingAnswers.Name = "poprawianiePytańToolStripMenuItem";
            this.miEditingAnswers.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.miEditingAnswers.Size = new System.Drawing.Size(229, 22);
            this.miEditingAnswers.Text = "Poprawianie pytań";
            this.miEditingAnswers.Click += new System.EventHandler(this.EditingMode);
            // 
            // Kreczmerowka12PytanMenu
            // 
            this.miExam12Questions.Name = "Kreczmerowka12PytanMenu";
            this.miExam12Questions.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miExam12Questions.Size = new System.Drawing.Size(229, 22);
            this.miExam12Questions.Text = "Próbna (12 pytań)";
            this.miExam12Questions.Click += new System.EventHandler(this.Kreczmerowka12);
            // 
            // Kreczmerowka26PytanMenu
            // 
            this.Kreczmerowka26PytanMenu.Name = "Kreczmerowka26PytanMenu";
            this.Kreczmerowka26PytanMenu.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Kreczmerowka26PytanMenu.Size = new System.Drawing.Size(229, 22);
            this.Kreczmerowka26PytanMenu.Text = "Zerówka (26 pytań)";
            this.Kreczmerowka26PytanMenu.Click += new System.EventHandler(this.Kreczmerowka26);
            // 
            // Kreczmerowka128PytanMenu
            // 
            this.Kreczmerowka128PytanMenu.Name = "Kreczmerowka128PytanMenu";
            this.Kreczmerowka128PytanMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Kreczmerowka128PytanMenu.Size = new System.Drawing.Size(229, 22);
            this.Kreczmerowka128PytanMenu.Text = "Egzamin (0x000080 pytań)";
            this.Kreczmerowka128PytanMenu.Click += new System.EventHandler(this.Kreczmerowka128);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.oToolStripMenuItem.Text = "Pomoc";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.Help);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(715, 464);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbLower);
            this.splitContainer1.Size = new System.Drawing.Size(709, 458);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 0;
            // 
            // GornyTextBox
            // 
            this.tbUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUpper.Font = new System.Drawing.Font("Courier New", 10F);
            this.tbUpper.Location = new System.Drawing.Point(0, 0);
            this.tbUpper.Multiline = true;
            this.tbUpper.Name = "GornyTextBox";
            this.tbUpper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbUpper.Size = new System.Drawing.Size(709, 213);
            this.tbUpper.TabIndex = 0;
            // 
            // DolnyTextBox
            // 
            this.tbLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLower.Font = new System.Drawing.Font("Courier New", 10F);
            this.tbLower.Location = new System.Drawing.Point(0, 0);
            this.tbLower.Multiline = true;
            this.tbLower.Name = "DolnyTextBox";
            this.tbLower.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLower.Size = new System.Drawing.Size(709, 241);
            this.tbLower.TabIndex = 1;
            // 
            // OtworzPlikFileDialog
            // 
            this.OtworzPlikFileDialog.Filter = "Pliki tekstowe|*.txt";
            // 
            // OtworzBazeFileDialog
            // 
            this.OtworzBazeFileDialog.Filter = "Plik bazy danych Kreczmerówki|*.xml";
            // 
            // otwórzPlikBazyDanychToolStripMenuItem
            // 
            this.otwórzPlikBazyDanychToolStripMenuItem.Image = global::Kreczmerowka.Properties.Resources.Open_Folder_icon;
            this.otwórzPlikBazyDanychToolStripMenuItem.Name = "otwórzPlikBazyDanychToolStripMenuItem";
            this.otwórzPlikBazyDanychToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzPlikBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.otwórzPlikBazyDanychToolStripMenuItem.Text = "Otwórz bazę z pliku";
            this.otwórzPlikBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.OpenDatabaseFile);
            // 
            // otwórzBazęZSerweraLemurrplToolStripMenuItem
            // 
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem.Image = global::Kreczmerowka.Properties.Resources.Open_Folder_icon;
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem.Name = "otwórzBazęZSerweraLemurrplToolStripMenuItem";
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem.Text = "Otwórz bazę z serwera";
            this.otwórzBazęZSerweraLemurrplToolStripMenuItem.Click += new System.EventHandler(this.OpenFromServer);
            // 
            // resetujLicznikiToolStripMenuItem
            // 
            this.resetujLicznikiToolStripMenuItem.Image = global::Kreczmerowka.Properties.Resources.icon_random_arrow;
            this.resetujLicznikiToolStripMenuItem.Name = "resetujLicznikiToolStripMenuItem";
            this.resetujLicznikiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetujLicznikiToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.resetujLicznikiToolStripMenuItem.Text = "Resetuj liczniki";
            this.resetujLicznikiToolStripMenuItem.Click += new System.EventHandler(this.ResetCounters);
            // 
            // pytaniaLosowoToolStripMenuItem
            // 
            this.pytaniaLosowoToolStripMenuItem.Image = global::Kreczmerowka.Properties.Resources.icon_random;
            this.pytaniaLosowoToolStripMenuItem.Name = "pytaniaLosowoToolStripMenuItem";
            this.pytaniaLosowoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.pytaniaLosowoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.pytaniaLosowoToolStripMenuItem.Text = "Losuj pytania";
            this.pytaniaLosowoToolStripMenuItem.Click += new System.EventHandler(this.ShuffleQuestion);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "OknoGlowne";
            this.Text = "Kreczmerówka";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnNextProblem;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnAnswerDontKnow;
        private System.Windows.Forms.Button btnAnswerNo;
        private System.Windows.Forms.Button btnAnswerYes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLearning;
        private System.Windows.Forms.ToolStripMenuItem miEditingAnswers;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.TextBox tbUpper;
        private System.Windows.Forms.TextBox tbLower;
        private System.Windows.Forms.RadioButton rbAnswerNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.OpenFileDialog OtworzPlikFileDialog;
        private System.Windows.Forms.Button btnPreviousProblem;
        private System.Windows.Forms.Button btnPreviousQuestion;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProblemId;
        private System.Windows.Forms.Label CalkowitaIloscOdpLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIncorrectCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikBazyDanychToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OtworzBazeFileDialog;
        private System.Windows.Forms.ToolStripMenuItem pytaniaLosowoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miShowMessagesAfterEachAnswer;
        private System.Windows.Forms.ToolStripMenuItem resetujLicznikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przejdźDoPoczątkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOWczytanejBazieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExam12Questions;
        private System.Windows.Forms.ToolStripMenuItem podsumowanieOdpowiedziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Kreczmerowka26PytanMenu;
        private System.Windows.Forms.ToolStripMenuItem Kreczmerowka128PytanMenu;
        private System.Windows.Forms.ToolStripMenuItem otwórzBazęZSerweraLemurrplToolStripMenuItem;
    }
}

