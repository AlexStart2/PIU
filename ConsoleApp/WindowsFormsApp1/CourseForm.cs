using ConsoleApp;
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
            dataGridViewQuestions.DataSource = course.getQuestions;
        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            switch (dataGridViewQuestions.SelectedRows.Count)
            {
                case 1:
                    string selected = dataGridViewQuestions.SelectedRows[0].Cells[0].Value.ToString();

                    course.removeQuestion(course.getQuestions.FindIndex(q => q.getQuestion == selected));
                    dataGridViewQuestions.DataSource = null;
                    dataGridViewQuestions.DataSource = course.getQuestions;
                    break;
                case 0:
                    MessageBox.Show(MainMenu.SELECT_ROW, MainMenu.infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(MainMenu.SELECT_ONE_ROW, MainMenu.infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void SaveCourse_Click(object sender, EventArgs e)
        {
            mainForm.groupCourses.writeDataInFile();
            MessageBox.Show(MainMenu.SAVE_SUCCESS, MainMenu.infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void displayQuestions_Click(object sender, EventArgs e)
        {
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = course.getQuestions;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchBar.Text == "")
            {
                displayQuestions_Click(sender, e);
                return;
            }

            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = course.findQuestions(SearchBar.Text);
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(sender, e);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            new AddQuestionForm(course).ShowDialog();
        }
    }
}
