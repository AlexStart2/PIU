
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;


namespace WindowsFormsApp1
{
    internal class SearchCourse
    {
        static public string searchText = "";
        static private Button btnSearchCourse;
        static  private TextBox txtSearchCourse;

        static public Button getButton
        {
            get
            {
                return btnSearchCourse;
            }
        }

        static public TextBox getSearchBar { get { return txtSearchCourse; } }

        public SearchCourse()
        {
            btnSearchCourse = new Button  //// de pus cu MainButton cu mai multi parametri si de selectat manual fontul
            {
                Text = "Cauta",
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Arial", 8, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(750, 12)
            };

            txtSearchCourse = new TextBox
            {
                Location = new Point(200, 12),
                Size = new Size(530, 30),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGray,
                MaxLength = 50
            };

            btnSearchCourse.Click += SetSearchText;
            txtSearchCourse.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearchCourse.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };
        }

        private void SetSearchText(object sender, EventArgs e)
        {
            searchText = txtSearchCourse.Text;
            SearchCourseEvent(sender, e);
        }

        static public void SearchCourseEvent(object sender, EventArgs e)
        {
            if (searchText.Trim().Equals(""))
            {
                MainMenu.displayedCourses = MainMenu.groupCourses.getCourses;
                DisplayCourses.CourseList();
                return;
            }

            GroupCourses FoundedCourses = new GroupCourses(MainMenu.groupCourses.findByName(searchText));
            MainMenu.displayedCourses = FoundedCourses.getCourses;
            DisplayCourses.CourseList();
        }
    }
}