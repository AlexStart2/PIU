
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    internal class DisplayCourses
    {
        static private Button btnDisplayCourses = new Button();
        static private int nrDisplayedCourse = 0;
        static private Form form = new Form();

        static private List<Button> btnCourse = new List<Button>();
        static private List<Button> btnDeleteCourse = new List<Button>();

        public DisplayCourses(Form _form)
        {
            form = _form;
        }

        static public Button getButton
        {
            get
            {
                btnDisplayCourses = MenuButton.NewButton("Afiseaza materii");
                btnDisplayCourses.Click += (object sender, EventArgs e) => {
                    SearchCourse.searchText = "";
                    MainMenu.displayedCourses = MainMenu.groupCourses.getCourses;
                    CourseList();
                };
                return btnDisplayCourses;
            }
        }

        static public void DisplayCourse(Course a, int x, int y)
        {
            if (a == null)
            {
                return;
            }
            nrDisplayedCourse++;
            btnCourse.Add(new Button
            {
                Location = new Point(x, y),
                Cursor = Cursors.Hand,
                Size = new Size(625, 40),
                Text = a.getName,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightBlue
            });

            btnDeleteCourse.Add(new Button
            {
                Text = "X",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Size = new Size(25, 25),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Location = new Point(x + 580, y + 7),
                Cursor = Cursors.Hand
            });

            int currentIndex = btnDeleteCourse.Count - 1;

            btnDeleteCourse[currentIndex].MouseEnter += DeleteButtonHover;

            btnDeleteCourse[currentIndex].MouseLeave += DeleteButtonNotHover;

            btnDeleteCourse[currentIndex].Click += (object sender, EventArgs e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + btnCourse[currentIndex].Text + "\" ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = MainMenu.groupCourses.getCourses.IndexOf(a);
                    DeleteCourseList();
                    MainMenu.groupCourses.removeCourse(index);
                    SearchCourse.SearchCourseEvent(sender, e);
                    CourseList();
                }
            };

            btnCourse[currentIndex].Click += (object sender, EventArgs e) =>
            {
                form.Hide();
                new CourseForm(a, form).Show();
            };

            form.Controls.Add(btnDeleteCourse[currentIndex]);

            form.Controls.Add(btnCourse[currentIndex]);
        }

        public static void CourseList()
        {
            DeleteCourseList();
            for (int i = 0; i < MainMenu.displayedCourses.Count; i++)
            {
                DisplayCourse(MainMenu.displayedCourses[i], 200, 50 + i * 50);
            }
        }


        static private void DeleteButtonHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.MistyRose;
        }

        static private void DeleteButtonNotHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
        }

        static public void DeleteCourseList()
        {
            for (int i = 0; i < nrDisplayedCourse; i++)
            {
                form.Controls.Remove(btnCourse[i]);
                form.Controls.Remove(btnDeleteCourse[i]);
            }
            btnCourse = new List<Button>();
            btnDeleteCourse = new List<Button>();
            nrDisplayedCourse = 0;
        }
    }
}