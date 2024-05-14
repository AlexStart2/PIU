namespace WindowsFormsApp1
{
    partial class CourseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.SaveCourse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.DeleteQuestion = new System.Windows.Forms.Button();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.displayQuestions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.getQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDifficultyLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveCourse
            // 
            this.SaveCourse.BackColor = System.Drawing.Color.White;
            this.SaveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCourse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SaveCourse.Location = new System.Drawing.Point(12, 275);
            this.SaveCourse.Name = "SaveCourse";
            this.SaveCourse.Size = new System.Drawing.Size(124, 59);
            this.SaveCourse.TabIndex = 18;
            this.SaveCourse.Text = "Salveaza";
            this.SaveCourse.UseVisualStyleBackColor = false;
            this.SaveCourse.Click += new System.EventHandler(this.SaveCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AllowUserToAddRows = false;
            this.dataGridViewQuestions.AutoGenerateColumns = false;
            this.dataGridViewQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getQuestionDataGridViewTextBoxColumn,
            this.getDifficultyLevelDataGridViewTextBoxColumn});
            this.dataGridViewQuestions.DataSource = this.questionBindingSource;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(163, 80);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.RowHeadersWidth = 51;
            this.dataGridViewQuestions.RowTemplate.Height = 24;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(714, 383);
            this.dataGridViewQuestions.TabIndex = 15;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchButton.Location = new System.Drawing.Point(752, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 31);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Cauta";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(111, 25);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(618, 27);
            this.SearchBar.TabIndex = 13;
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            // 
            // DeleteQuestion
            // 
            this.DeleteQuestion.BackColor = System.Drawing.Color.White;
            this.DeleteQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteQuestion.Location = new System.Drawing.Point(12, 340);
            this.DeleteQuestion.Name = "DeleteQuestion";
            this.DeleteQuestion.Size = new System.Drawing.Size(124, 59);
            this.DeleteQuestion.TabIndex = 12;
            this.DeleteQuestion.Text = "Sterge";
            this.DeleteQuestion.UseVisualStyleBackColor = false;
            this.DeleteQuestion.Click += new System.EventHandler(this.DeleteQuestion_Click);
            // 
            // AddQuestion
            // 
            this.AddQuestion.BackColor = System.Drawing.Color.White;
            this.AddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddQuestion.Location = new System.Drawing.Point(12, 210);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(124, 59);
            this.AddQuestion.TabIndex = 11;
            this.AddQuestion.Text = "Adauga intrebare";
            this.AddQuestion.UseVisualStyleBackColor = false;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // displayQuestions
            // 
            this.displayQuestions.BackColor = System.Drawing.Color.White;
            this.displayQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQuestions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.displayQuestions.Location = new System.Drawing.Point(12, 145);
            this.displayQuestions.Name = "displayQuestions";
            this.displayQuestions.Size = new System.Drawing.Size(124, 59);
            this.displayQuestions.TabIndex = 10;
            this.displayQuestions.Text = "Afiseaza intrebari";
            this.displayQuestions.UseVisualStyleBackColor = false;
            this.displayQuestions.Click += new System.EventHandler(this.displayQuestions_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sustine testul";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // getQuestionDataGridViewTextBoxColumn
            // 
            this.getQuestionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.getQuestionDataGridViewTextBoxColumn.DataPropertyName = "getQuestion";
            this.getQuestionDataGridViewTextBoxColumn.HeaderText = "Intrebare";
            this.getQuestionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.getQuestionDataGridViewTextBoxColumn.Name = "getQuestionDataGridViewTextBoxColumn";
            this.getQuestionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getDifficultyLevelDataGridViewTextBoxColumn
            // 
            this.getDifficultyLevelDataGridViewTextBoxColumn.DataPropertyName = "getDifficultyLevel";
            this.getDifficultyLevelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.getDifficultyLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.getDifficultyLevelDataGridViewTextBoxColumn.Name = "getDifficultyLevelDataGridViewTextBoxColumn";
            this.getDifficultyLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.getDifficultyLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(ConsoleApp.Question);
            // 
            // CourseF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(909, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveCourse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.DeleteQuestion);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.displayQuestions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseF";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveCourse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button DeleteQuestion;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Button displayQuestions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn getQuestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getDifficultyLevelDataGridViewTextBoxColumn;
    }
}