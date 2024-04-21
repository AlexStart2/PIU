using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp1
{
    public partial class CourseForm : Form
    {
        private Course course = new Course();
        private readonly Form main = new Form();

        private Button Exam = new Button();
        private Button EditName = new Button();

        public CourseForm(Course course, Form main)
        {
            MenuButton.nrButton = 0;

            EditName = MenuButton.NewButton("Editează numele cursului",10,10);
            Exam = MenuButton.NewButton("Raspunde la intrebari");

            this.course = course;
            this.main = main;
            InitializeComponent();

            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            EditName.Click += (object sender, EventArgs e) =>
            {
                Form editName = new Form 
                {
                    Text = "Schimba numele", // Set the title of the form
                    Size = new Size(300, 150) // Set the size of the form
                };

                Button btnEditCourseName = new Button
                {
                    Text = "Schimba",
                    Location = new Point(20, 50),
                    Size = new Size(100, 30),
                    Cursor = Cursors.Hand
                };

                btnEditCourseName.Click += (object send, EventArgs ev) =>
                {

                };

                TextBox text = new TextBox();
                text.Text = course.getName;

                editName.Controls.Add(btnEditCourseName);
                editName.Controls.Add(text);

                editName.ShowDialog();
            };

            this.Controls.AddRange(new Button[] { Exam, EditName });
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            this.Text = course.getName;

            this.FormClosed += (object send, FormClosedEventArgs ev) => 
            {
                this.Hide();
                main.Show();
            };
        }
    }
}
