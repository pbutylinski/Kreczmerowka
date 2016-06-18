namespace Kreczmerowka
{
    partial class Summary
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
            this.lvAnswers = new System.Windows.Forms.ListView();
            this.ProblemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PytanieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KolumnaOdpUzytkownika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KolumnaOdpPoprawna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdpowiedziListView
            // 
            this.lvAnswers.AllowColumnReorder = true;
            this.lvAnswers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProblemID,
            this.PytanieID,
            this.KolumnaOdpUzytkownika,
            this.KolumnaOdpPoprawna});
            this.lvAnswers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAnswers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvAnswers.FullRowSelect = true;
            this.lvAnswers.GridLines = true;
            this.lvAnswers.LabelWrap = false;
            this.lvAnswers.Location = new System.Drawing.Point(3, 3);
            this.lvAnswers.Name = "OdpowiedziListView";
            this.lvAnswers.Size = new System.Drawing.Size(300, 579);
            this.lvAnswers.TabIndex = 0;
            this.lvAnswers.UseCompatibleStateImageBehavior = false;
            this.lvAnswers.View = System.Windows.Forms.View.Details;
            this.lvAnswers.SelectedIndexChanged += new System.EventHandler(this.ChangeQuestion);
            // 
            // ProblemID
            // 
            this.ProblemID.Text = "Problem";
            // 
            // PytanieID
            // 
            this.PytanieID.Text = "Pytanie";
            // 
            // KolumnaOdpUzytkownika
            // 
            this.KolumnaOdpUzytkownika.Text = "Twoja odpowiedź";
            this.KolumnaOdpUzytkownika.Width = 106;
            // 
            // KolumnaOdpPoprawna
            // 
            this.KolumnaOdpPoprawna.Text = "Dobrze?";
            this.KolumnaOdpPoprawna.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(303, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 46);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrowanie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pokaż wszystkie",
            "Błędne i niewiadome",
            "Tylko błędne",
            "Tylko niewiadome",
            "Tylko prawidłowe"});
            this.comboBox1.Location = new System.Drawing.Point(202, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Sortowanie);
            // 
            // tbProblem
            // 
            this.tbProblem.BackColor = System.Drawing.Color.White;
            this.tbProblem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbProblem.Location = new System.Drawing.Point(309, 82);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.ReadOnly = true;
            this.tbProblem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProblem.Size = new System.Drawing.Size(583, 140);
            this.tbProblem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(306, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Problem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(306, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pytanie";
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.White;
            this.tbQuestion.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbQuestion.Location = new System.Drawing.Point(309, 261);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbQuestion.Size = new System.Drawing.Size(583, 140);
            this.tbQuestion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(306, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Komentarz";
            // 
            // tbComment
            // 
            this.tbComment.BackColor = System.Drawing.Color.White;
            this.tbComment.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbComment.Location = new System.Drawing.Point(309, 442);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbComment.Size = new System.Drawing.Size(583, 140);
            this.tbComment.TabIndex = 6;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvAnswers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Summary";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podsumowanie";
            this.Load += new System.EventHandler(this.Summary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAnswers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader KolumnaOdpUzytkownika;
        private System.Windows.Forms.ColumnHeader KolumnaOdpPoprawna;
        private System.Windows.Forms.ColumnHeader ProblemID;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.ColumnHeader PytanieID;
    }
}