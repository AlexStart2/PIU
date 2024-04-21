
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;


namespace WindowsFormsApp1
{
    internal class AddCourse
    {
        static private Button btnAddCourse = new Button();
        static Form addCourseForm = new Form();
        static TextBox txtCourseName;

        static public Button getButton { get {
                btnAddCourse = MenuButton.NewButton("Adauga materie", 10, 90);
                btnAddCourse.Click += AddCourseEvent;
                return btnAddCourse; 
            } }



        private static void AddCourseEvent(object sender, EventArgs e)
        {
            addCourseForm = new Form
            {
                Text = "Add New Course", // Set the title of the form
                Size = new Size(300, 150) // Set the size of the form
            };
            Button btnAddNewCourse = new Button
            {
                Text = "Add Course",
                Location = new Point(20, 50),
                Size = new Size(100, 30)
            };
            btnAddNewCourse.Click += btnFormAddCourse;

            txtCourseName = new TextBox
            {
                Location = new Point(20, 20),
                Size = new Size(200, 20)
            };
            txtCourseName.KeyDown += (object send, KeyEventArgs ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    btnAddNewCourse.PerformClick();
                    ev.Handled = true;
                    ev.SuppressKeyPress = true;
                }
            };
            addCourseForm.Controls.Add(txtCourseName);

            addCourseForm.Controls.Add(btnAddNewCourse);

            addCourseForm.ShowDialog();
        }

        static void btnFormAddCourse(object sender, EventArgs ev)
        {

            string courseName = txtCourseName.Text.Trim();

            if (!Validations.LengthStringValidation(courseName))
            {
                txtCourseName.BackColor = Color.MistyRose;
                return;
            }

            if (!string.IsNullOrEmpty(courseName))
            {
                MainMenu.groupCourses.addCourse(courseName);
                addCourseForm.Close();
                MainMenu.displayedCourses = MainMenu.groupCourses.getCourses;
                SearchCourse.searchText = "";
                DisplayCourses.CourseList();
            }
            else
            {
                MessageBox.Show("Please enter a course name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}