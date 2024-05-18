namespace WindowsFormsApp1
{
    partial class AddQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionForm));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblDiffLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.rdBtnEasy = new System.Windows.Forms.RadioButton();
            this.rdBtnNormal = new System.Windows.Forms.RadioButton();
            this.rdBtnHard = new System.Windows.Forms.RadioButton();
            this.rdBtnMaster = new System.Windows.Forms.RadioButton();
            this.rdBtnExpert = new System.Windows.Forms.RadioButton();
            this.CorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.WrongAnswerBox = new System.Windows.Forms.TextBox();
            this.AddWrongAnswer = new System.Windows.Forms.Button();
            this.AddNewQuestion = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.WrongAnswerList = new System.Windows.Forms.ListBox();
            this.DeleteWrongAnswer = new System.Windows.Forms.Button();
            this.ImageName = new System.Windows.Forms.Label();
            this.DeleteImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(38, 37);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(74, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Intrebarea: ";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(38, 234);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(104, 16);
            this.lblCorrectAnswer.TabIndex = 1;
            this.lblCorrectAnswer.Text = "Raspuns corect:";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Location = new System.Drawing.Point(38, 279);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(115, 16);
            this.lblWrongAnswers.TabIndex = 2;
            this.lblWrongAnswers.Text = "Raspusuri gresite:";
            // 
            // lblDiffLevel
            // 
            this.lblDiffLevel.AutoSize = true;
            this.lblDiffLevel.Location = new System.Drawing.Point(38, 76);
            this.lblDiffLevel.Name = "lblDiffLevel";
            this.lblDiffLevel.Size = new System.Drawing.Size(119, 16);
            this.lblDiffLevel.TabIndex = 3;
            this.lblDiffLevel.Text = "Nivel de dificultate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imagine (optional) :";
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(190, 31);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(519, 27);
            this.QuestionBox.TabIndex = 14;
            // 
            // rdBtnEasy
            // 
            this.rdBtnEasy.AutoSize = true;
            this.rdBtnEasy.Location = new System.Drawing.Point(190, 77);
            this.rdBtnEasy.Name = "rdBtnEasy";
            this.rdBtnEasy.Size = new System.Drawing.Size(59, 20);
            this.rdBtnEasy.TabIndex = 15;
            this.rdBtnEasy.TabStop = true;
            this.rdBtnEasy.Text = "Easy";
            this.rdBtnEasy.UseVisualStyleBackColor = true;
            // 
            // rdBtnNormal
            // 
            this.rdBtnNormal.AutoSize = true;
            this.rdBtnNormal.Location = new System.Drawing.Point(190, 103);
            this.rdBtnNormal.Name = "rdBtnNormal";
            this.rdBtnNormal.Size = new System.Drawing.Size(72, 20);
            this.rdBtnNormal.TabIndex = 16;
            this.rdBtnNormal.TabStop = true;
            this.rdBtnNormal.Text = "Normal";
            this.rdBtnNormal.UseVisualStyleBackColor = true;
            // 
            // rdBtnHard
            // 
            this.rdBtnHard.AutoSize = true;
            this.rdBtnHard.Location = new System.Drawing.Point(190, 129);
            this.rdBtnHard.Name = "rdBtnHard";
            this.rdBtnHard.Size = new System.Drawing.Size(58, 20);
            this.rdBtnHard.TabIndex = 17;
            this.rdBtnHard.TabStop = true;
            this.rdBtnHard.Text = "Hard";
            this.rdBtnHard.UseVisualStyleBackColor = true;
            // 
            // rdBtnMaster
            // 
            this.rdBtnMaster.AutoSize = true;
            this.rdBtnMaster.Location = new System.Drawing.Point(190, 155);
            this.rdBtnMaster.Name = "rdBtnMaster";
            this.rdBtnMaster.Size = new System.Drawing.Size(69, 20);
            this.rdBtnMaster.TabIndex = 18;
            this.rdBtnMaster.TabStop = true;
            this.rdBtnMaster.Text = "Master";
            this.rdBtnMaster.UseVisualStyleBackColor = true;
            // 
            // rdBtnExpert
            // 
            this.rdBtnExpert.AutoSize = true;
            this.rdBtnExpert.Location = new System.Drawing.Point(190, 183);
            this.rdBtnExpert.Name = "rdBtnExpert";
            this.rdBtnExpert.Size = new System.Drawing.Size(66, 20);
            this.rdBtnExpert.TabIndex = 19;
            this.rdBtnExpert.TabStop = true;
            this.rdBtnExpert.Text = "Expert";
            this.rdBtnExpert.UseVisualStyleBackColor = true;
            // 
            // CorrectAnswerBox
            // 
            this.CorrectAnswerBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerBox.Location = new System.Drawing.Point(190, 228);
            this.CorrectAnswerBox.Name = "CorrectAnswerBox";
            this.CorrectAnswerBox.Size = new System.Drawing.Size(519, 27);
            this.CorrectAnswerBox.TabIndex = 20;
            // 
            // WrongAnswerBox
            // 
            this.WrongAnswerBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswerBox.Location = new System.Drawing.Point(190, 273);
            this.WrongAnswerBox.Name = "WrongAnswerBox";
            this.WrongAnswerBox.Size = new System.Drawing.Size(519, 27);
            this.WrongAnswerBox.TabIndex = 21;
            this.WrongAnswerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WrongAnswerBox_KeyDown);
            // 
            // AddWrongAnswer
            // 
            this.AddWrongAnswer.BackColor = System.Drawing.Color.White;
            this.AddWrongAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddWrongAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWrongAnswer.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWrongAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddWrongAnswer.Location = new System.Drawing.Point(715, 268);
            this.AddWrongAnswer.Name = "AddWrongAnswer";
            this.AddWrongAnswer.Size = new System.Drawing.Size(33, 36);
            this.AddWrongAnswer.TabIndex = 24;
            this.AddWrongAnswer.Text = "+";
            this.AddWrongAnswer.UseVisualStyleBackColor = false;
            this.AddWrongAnswer.Click += new System.EventHandler(this.AddWrongAnswer_Click);
            // 
            // AddNewQuestion
            // 
            this.AddNewQuestion.BackColor = System.Drawing.Color.White;
            this.AddNewQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddNewQuestion.Location = new System.Drawing.Point(37, 383);
            this.AddNewQuestion.Name = "AddNewQuestion";
            this.AddNewQuestion.Size = new System.Drawing.Size(116, 34);
            this.AddNewQuestion.TabIndex = 25;
            this.AddNewQuestion.Text = "Adauga";
            this.AddNewQuestion.UseVisualStyleBackColor = false;
            this.AddNewQuestion.Click += new System.EventHandler(this.AddNewQuestion_Click);
            // 
            // AddImage
            // 
            this.AddImage.BackColor = System.Drawing.Color.White;
            this.AddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddImage.Location = new System.Drawing.Point(491, 65);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(107, 37);
            this.AddImage.TabIndex = 26;
            this.AddImage.Text = "Selecteaza";
            this.AddImage.UseVisualStyleBackColor = false;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // WrongAnswerList
            // 
            this.WrongAnswerList.FormattingEnabled = true;
            this.WrongAnswerList.ItemHeight = 16;
            this.WrongAnswerList.Location = new System.Drawing.Point(190, 333);
            this.WrongAnswerList.Name = "WrongAnswerList";
            this.WrongAnswerList.Size = new System.Drawing.Size(519, 84);
            this.WrongAnswerList.TabIndex = 28;
            // 
            // DeleteWrongAnswer
            // 
            this.DeleteWrongAnswer.BackColor = System.Drawing.Color.White;
            this.DeleteWrongAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWrongAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWrongAnswer.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteWrongAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteWrongAnswer.Location = new System.Drawing.Point(715, 381);
            this.DeleteWrongAnswer.Name = "DeleteWrongAnswer";
            this.DeleteWrongAnswer.Size = new System.Drawing.Size(33, 36);
            this.DeleteWrongAnswer.TabIndex = 29;
            this.DeleteWrongAnswer.Text = "-";
            this.DeleteWrongAnswer.UseVisualStyleBackColor = false;
            this.DeleteWrongAnswer.Click += new System.EventHandler(this.DeleteWrongAnswer_Click);
            // 
            // ImageName
            // 
            this.ImageName.AutoSize = true;
            this.ImageName.Location = new System.Drawing.Point(488, 107);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(0, 16);
            this.ImageName.TabIndex = 30;
            // 
            // DeleteImage
            // 
            this.DeleteImage.BackColor = System.Drawing.Color.White;
            this.DeleteImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteImage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.DeleteImage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteImage.Location = new System.Drawing.Point(610, 65);
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(99, 37);
            this.DeleteImage.TabIndex = 31;
            this.DeleteImage.Text = "Sterge";
            this.DeleteImage.UseVisualStyleBackColor = false;
            this.DeleteImage.Click += new System.EventHandler(this.DeleteImageBtn_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(796, 502);
            this.Controls.Add(this.DeleteImage);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.DeleteWrongAnswer);
            this.Controls.Add(this.WrongAnswerList);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.AddNewQuestion);
            this.Controls.Add(this.AddWrongAnswer);
            this.Controls.Add(this.WrongAnswerBox);
            this.Controls.Add(this.CorrectAnswerBox);
            this.Controls.Add(this.rdBtnExpert);
            this.Controls.Add(this.rdBtnMaster);
            this.Controls.Add(this.rdBtnHard);
            this.Controls.Add(this.rdBtnNormal);
            this.Controls.Add(this.rdBtnEasy);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiffLevel);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblDiffLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.RadioButton rdBtnEasy;
        private System.Windows.Forms.RadioButton rdBtnNormal;
        private System.Windows.Forms.RadioButton rdBtnHard;
        private System.Windows.Forms.RadioButton rdBtnMaster;
        private System.Windows.Forms.RadioButton rdBtnExpert;
        private System.Windows.Forms.TextBox CorrectAnswerBox;
        private System.Windows.Forms.TextBox WrongAnswerBox;
        private System.Windows.Forms.Button AddWrongAnswer;
        private System.Windows.Forms.Button AddNewQuestion;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.ListBox WrongAnswerList;
        private System.Windows.Forms.Button DeleteWrongAnswer;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.Button DeleteImage;
    }
}