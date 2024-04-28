
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    internal class Search
    {
        public string searchText = "";
        private Button btnSearch;
        private TextBox txtSearch;

        public Button getButton
        {
            get
            {
                return btnSearch;
            }
        }

        public TextBox getSearchBar { get { return txtSearch; } }

        public Search(object type)
        {
            btnSearch = MenuButton.NewButton("Cauta", 750, 12, 75, 25, textSize: 8, nextBtn: false);

            txtSearch = new TextBox
            {
                Location = new Point(200, 12),
                Size = new Size(530, 30),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGray,
                MaxLength = 50
            };

            btnSearch.Click += (object sender, EventArgs e) =>
            {
                searchText = txtSearch.Text;
                if(type.GetType() == typeof(Course))
                {
                    SearchCourseEvent(sender, e);
                }else if(type.GetType() == typeof(Question))
                {
                    SearchQuestionEvent(sender, e);
                }
                
            };


            txtSearch.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };
        }

        public void SearchCourseEvent(object sender, EventArgs e)
        {
            if (searchText.Trim().Equals(""))
            {
                MainMenu.displayedCourses = MainMenu.groupCourses.getCourses;
                MainMenu.displayCourses.CourseList();
                return;
            }

            GroupCourses FoundedCourses = new GroupCourses(MainMenu.groupCourses.findByName(searchText));
            MainMenu.displayedCourses = FoundedCourses.getCourses;
            MainMenu.displayCourses.CourseList();
        }

        public void SearchQuestionEvent(object sender, EventArgs e)
        {
            if (searchText.Trim().Equals(""))
            {
                //DisplayItems.QuestionList();
                return;
            }


            List<Question> question = CourseForm.course.findQuestions(searchText);

            if (question == null)
            {
                // Ar fi ok  sa afisezi un mesaj ca nu s-a gasit nimic
            }

            //DisplayItems.QuestionList();
        }
    }
}