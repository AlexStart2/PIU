﻿using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public const string SELECT_ROW = "Selecteaza intreaga linie";
        public const string SELECT_ONE_ROW = "Selecteaza un singur curs";
        public const string SELECT_COURSE = "Selecteaza un curs pentru a vedea detaliile";
        public const string SAVE_SUCCESS = "Datele au fost salvate";
        public const int WIDTH = 700;
        public const int HEIGHT = 450;
        public const string ERROR = "An error occurred: ";
        
        public const string COURSE_NOT_FOUND = "Cursul nu a fost gasit";
        public const string colName = "Name";
        public const string colNrQuestions = "NrQuestions";
        public const string infoTxt = "Information";



        public GroupCourses groupCourses = new GroupCourses();

        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(WIDTH, HEIGHT);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = groupCourses.getCourses;
        }

        private void displayCourses_Click(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = groupCourses.getCourses;
            dataGridViewCourses_setHeader();
        }

        private void AdaugaCurs_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Adauga curs";
            form.Size = new Size(300, 150);
            form.StartPosition = FormStartPosition.CenterScreen;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(30, 20);
            textBox.Size = new Size(200, 20);
            textBox.TabIndex = 0;

            Button button = new Button();
            button.Location = new Point(30, 60);
            button.Size = new Size(100, 30);
            button.Text = "Adauga";
            button.Cursor = Cursors.Hand;

            textBox.KeyDown += (object send, KeyEventArgs ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    button.PerformClick();
                }
            };

            button.Click += (object send, EventArgs ev) =>
            {
                try
                {
                    Validations.LengthStringValidation(textBox.Text);
                    groupCourses.addCourse(textBox.Text);
                    dataGridViewCourses.DataSource = null;
                    dataGridViewCourses.DataSource = groupCourses.getCourses;
                    form.Close();

                    dataGridViewCourses_setHeader();

                }
                catch(Exception ex)
                {
                    Label label = new Label();
                    label.Text = ex.Message;
                    label.Location = new Point(30, 40);
                    label.Size = new Size(240, 20);
                    label.ForeColor = Color.Red;
                    form.Controls.Add(label);
                }
            };

            form.Controls.Add(textBox);
            form.Controls.Add(button);

            form.ShowDialog();
        }

        private void SaveCourses_Click(object sender, EventArgs e)
        {
            groupCourses.writeDataInFile();

            MessageBox.Show(SAVE_SUCCESS, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchBar.Text == "")
            {
                return;
            }
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = groupCourses.findByName(SearchBar.Text);
            dataGridViewCourses_setHeader();
        }


        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(sender, e);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (dataGridViewCourses.SelectedRows.Count)
            {
                case 1:
                    string selected = dataGridViewCourses.SelectedRows[0].Cells[0].Value.ToString();
                    groupCourses.removeCourse(groupCourses.getCourses.FindIndex(x => x.Name == selected));

                    dataGridViewCourses.DataSource = null;
                    dataGridViewCourses.DataSource = groupCourses.getCourses;
                    dataGridViewCourses_setHeader();
                    break;
                case 0:
                    MessageBox.Show(SELECT_ROW, infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(SELECT_ONE_ROW, infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        private void CourseDetails_Click(object sender, EventArgs e)
        {
            if(dataGridViewCourses.SelectedCells.Count == 0)
            {
                MessageBox.Show(SELECT_COURSE, infoTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch(dataGridViewCourses.SelectedCells.Count)
            {
                case 1:
                    string selected = dataGridViewCourses.SelectedCells[0].Value.ToString();

                    Course course = groupCourses.getCourses.Find(x => x.Name == selected);
                    if(course == null)
                    {
                        MessageBox.Show(COURSE_NOT_FOUND, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    new CourseForm(course, this).Show();
                    this.Hide();
                    break;
                case 0:
                    MessageBox.Show(SELECT_ROW, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(SELECT_ONE_ROW, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataGridViewCourses_setHeader()
        {
            dataGridViewCourses.Columns[colName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCourses.Columns[colName].HeaderText = "Nume curs";
            dataGridViewCourses.Columns[colNrQuestions].HeaderText = "Nr. intrebari";
        }
    }
}
