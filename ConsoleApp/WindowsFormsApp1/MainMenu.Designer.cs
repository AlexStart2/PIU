namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.displayCourses = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.SaveCourses = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteCourse = new System.Windows.Forms.Button();
            this.CourseDetails = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrQuestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // displayCourses
            // 
            this.displayCourses.BackColor = System.Drawing.Color.White;
            this.displayCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayCourses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCourses.ForeColor = System.Drawing.SystemColors.WindowText;
            this.displayCourses.Location = new System.Drawing.Point(12, 77);
            this.displayCourses.Name = "displayCourses";
            this.displayCourses.Size = new System.Drawing.Size(124, 59);
            this.displayCourses.TabIndex = 0;
            this.displayCourses.Text = "Afiseaza cursuri";
            this.displayCourses.UseVisualStyleBackColor = false;
            this.displayCourses.Click += new System.EventHandler(this.displayCourses_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.BackColor = System.Drawing.Color.White;
            this.AddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddCourse.Location = new System.Drawing.Point(12, 142);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(124, 59);
            this.AddCourse.TabIndex = 1;
            this.AddCourse.Text = "Adauga curs";
            this.AddCourse.UseVisualStyleBackColor = false;
            this.AddCourse.Click += new System.EventHandler(this.AdaugaCurs_Click);
            // 
            // SaveCourses
            // 
            this.SaveCourses.BackColor = System.Drawing.Color.White;
            this.SaveCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCourses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCourses.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SaveCourses.Location = new System.Drawing.Point(12, 272);
            this.SaveCourses.Name = "SaveCourses";
            this.SaveCourses.Size = new System.Drawing.Size(124, 59);
            this.SaveCourses.TabIndex = 2;
            this.SaveCourses.Text = "Salveaza";
            this.SaveCourses.UseVisualStyleBackColor = false;
            this.SaveCourses.Click += new System.EventHandler(this.SaveCourses_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(110, 24);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(618, 27);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchButton.Location = new System.Drawing.Point(765, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 31);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Cauta";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.BackColor = System.Drawing.Color.White;
            this.DeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCourse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteCourse.Location = new System.Drawing.Point(12, 337);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Size = new System.Drawing.Size(124, 59);
            this.DeleteCourse.TabIndex = 8;
            this.DeleteCourse.Text = "Sterge";
            this.DeleteCourse.UseVisualStyleBackColor = false;
            this.DeleteCourse.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CourseDetails
            // 
            this.CourseDetails.BackColor = System.Drawing.Color.White;
            this.CourseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CourseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDetails.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CourseDetails.Location = new System.Drawing.Point(12, 207);
            this.CourseDetails.Name = "CourseDetails";
            this.CourseDetails.Size = new System.Drawing.Size(124, 59);
            this.CourseDetails.TabIndex = 9;
            this.CourseDetails.Text = "Detalii";
            this.CourseDetails.UseVisualStyleBackColor = false;
            this.CourseDetails.Click += new System.EventHandler(this.CourseDetails_Click);
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AllowUserToDeleteRows = false;
            this.dataGridViewCourses.AutoGenerateColumns = false;
            this.dataGridViewCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.nrQuestionsDataGridViewTextBoxColumn});
            this.dataGridViewCourses.DataSource = this.courseBindingSource;
            this.dataGridViewCourses.Location = new System.Drawing.Point(177, 77);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(713, 377);
            this.dataGridViewCourses.TabIndex = 10;
            this.dataGridViewCourses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellDoubleClick);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(ConsoleApp.Course);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nume curs";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nrQuestionsDataGridViewTextBoxColumn
            // 
            this.nrQuestionsDataGridViewTextBoxColumn.DataPropertyName = "NrQuestions";
            this.nrQuestionsDataGridViewTextBoxColumn.HeaderText = "Nr. intrebari";
            this.nrQuestionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrQuestionsDataGridViewTextBoxColumn.Name = "nrQuestionsDataGridViewTextBoxColumn";
            this.nrQuestionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrQuestionsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nrQuestionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(902, 483);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.CourseDetails);
            this.Controls.Add(this.DeleteCourse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SaveCourses);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.displayCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayCourses;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteCourse;
        private System.Windows.Forms.Button CourseDetails;
        private System.Windows.Forms.Button SaveCourses;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrQuestionsDataGridViewTextBoxColumn;
    }
}