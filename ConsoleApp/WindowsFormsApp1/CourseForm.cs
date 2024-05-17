﻿using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class CourseForm : Form
    {
        Course course;
        static MainMenu mainForm;

        const string colQuestion = "getQuestion";
        const string coldiffLevel = "getDifficultyLevel";

        public CourseForm(Course course, MainMenu mainForm)
        {
            InitializeComponent();
            this.course = course;
            if(mainForm != null)
            {
                CourseForm.mainForm = mainForm;
            }
            this.Text = course.Name;
            this.Size = new Size(MainMenu.WIDTH, MainMenu.HEIGHT);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Course_Load(object sender, EventArgs e)
        {
            this.FormClosed += (s, args) => { mainForm.Show(); };
            dataGridView1.DataSource = course.getQuestions;

        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            switch (dataGridView1.SelectedRows.Count)
            {
                case 1:
                    string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    course.removeQuestion(course.getQuestions.FindIndex(q => q.getQuestion == selected));
                    displayDataGridCourse(course.getQuestions);
                    break;
                case 0:
                    MessageBox.Show(MainMenu.SELECT_ROW, MainMenu.infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(MainMenu.SELECT_ONE_ROW, MainMenu.infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void SaveCourse_Click()
        {
            mainForm.groupCourses.writeDataInFile();
            MainMenu.saveMessage(this);
        }

        private void displayQuestions_Click(object sender, EventArgs e)
        {
            displayDataGridCourse(course.getQuestions);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchBar.Text == "")
            {
                displayDataGridCourse(course.getQuestions);
                return;
            }

            displayDataGridCourse(course.findQuestions(SearchBar.Text));
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                new AddQuestionForm(course).ShowDialog();
                displayDataGridCourse(course.getQuestions);
                SaveCourse_Click();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void takeTest_Click(object sender, EventArgs e)
        {
            if (course.getQuestions.Count == 0)
            {
                MessageBox.Show("Nu exista intrebari", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new test(course).Show();
            }
        }

        private void dataGridViewQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new AddQuestionForm(course, course.getQuestions[e.RowIndex]).ShowDialog();
            SaveCourse_Click();
            MainMenu.saveMessage(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = course.getQuestions;
        }


        private void displayDataGridCourse(List<Question> questions)
        {
            BindingSource Source = new BindingSource();

            Source.DataSource = questions;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Source;
        }

        private void EditCourseName_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(300, 150),
                BackColor = Color.FromArgb(158, 214, 252),
                Text = "Edit Course Name"
            };
            TextBox textBox = new TextBox
            {
                Text = course.Name,
                Location = new Point(50, 20),
                Size = new Size(200, 20)
            };
            form.Controls.Add(textBox);
            Button button = new Button
            {
                Location = new Point(50, 50),
                Size = new Size(100, 30),
                Text = "Edit",
                Cursor = Cursors.Hand
            };

            button.Click += (object send, EventArgs ev) =>
            {
                try
                {
                    Validations.LengthStringValidation(textBox.Text);
                    course.setName = textBox.Text;
                    this.Text = course.Name;
                    form.Close();
                    SaveCourse_Click();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            form.Controls.Add(button);
            form.ShowDialog();
        }
    }
}
