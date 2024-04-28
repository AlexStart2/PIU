
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    internal class DisplayItems
    {
        private Button btnDisplayCourses = new Button();
        private Button btnDisplayQuestions = new Button();

        private int nrDisplayedItem = 0;
        private Form form = new Form();

        private List<Button> btnItem = new List<Button>();
        private List<Button> btnDeleteItem = new List<Button>();

        private Form course;

        public DisplayItems(Form _form)
        {
            form = _form;
        }

        public Button getQuestionsButton
        {
            get
            {
                btnDisplayQuestions = MenuButton.NewButton("Afiseaza intrebari");
                btnDisplayQuestions.Click += (object sender, EventArgs e) =>
                {
                    CourseForm.CourseSearch.searchText = "";
                    CourseForm.displayedQuestions = CourseForm.course.getQuestions;
                    QuestionList();
                };
                return btnDisplayQuestions;
            }
        }

        public Button getCoursesButton
        {
            get
            {
                btnDisplayCourses = MenuButton.NewButton("Afiseaza materii");
                btnDisplayCourses.Click += (object sender, EventArgs e) => {
                    MainMenu.MainSearch.searchText = "";
                    MainMenu.displayedCourses = MainMenu.groupCourses.getCourses;
                    CourseList();
                };
                return btnDisplayCourses;
            }
        }

        public void DisplayItem(object a, int x, int y)
        {
            Course course = new Course();
            Question question = new Question();
            string text = "";
            if (a == null)
            {
                return;
            }else if(a.GetType() == course.GetType())
            {
                course = (Course)a;
                text = course.getName;
            }
            else if (a.GetType() == question.GetType())
            {
                question = (Question)a;
                text = question.getQuestion;
            }
            nrDisplayedItem++;

            

            btnItem.Add(new Button
            {
                Location = new Point(x, y),
                Cursor = Cursors.Hand,
                Size = new Size(625, 40),
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightBlue
            });

            btnDeleteItem.Add(new Button
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

            int currentIndex = btnDeleteItem.Count - 1;

            btnDeleteItem[currentIndex].MouseEnter += DeleteButtonHover;

            btnDeleteItem[currentIndex].MouseLeave += DeleteButtonNotHover;

            btnDeleteItem[currentIndex].Click += (object sender, EventArgs e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + btnItem[currentIndex].Text + "\" ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(a.GetType() == typeof(Course))
                    {
                        int index = MainMenu.groupCourses.getCourses.IndexOf(course);
                        DeleteItemsList();
                        MainMenu.groupCourses.removeCourse(index);
                        MainMenu.MainSearch.SearchCourseEvent(sender, e);
                        CourseList();
                    }
                    else
                    {
                        int index = CourseForm.course.getQuestions.IndexOf(question);
                        CourseForm.course.removeQuestion(index);
                        CourseForm.CourseSearch.SearchQuestionEvent(sender, e);
                        QuestionList();
                    }
                    
                }
            };

            btnItem[currentIndex].Click += (object sender, EventArgs e) =>
            {
                if (a.GetType() == course.GetType())
                {
                    new CourseForm(course, form).Show();   //// here is the problem
                }
            };

            form.Controls.Add(btnDeleteItem[currentIndex]);

            form.Controls.Add(btnItem[currentIndex]);
        }

        public void CourseList()
        {
            DeleteItemsList();
            for (int i = 0; i < MainMenu.displayedCourses.Count; i++)
            {
                DisplayItem(MainMenu.displayedCourses[i], 200, 50 + i * 50);
            }
        }

        public void QuestionList()
        {
            DeleteItemsList();
            for (int i = 0; i < CourseForm.displayedQuestions.Count; i++)
            {
                DisplayItem(CourseForm.displayedQuestions[i], 200, 50 + i * 50);
            }
        }


        private void DeleteButtonHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.MistyRose;
        }

        private void DeleteButtonNotHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
        }

        public void DeleteItemsList()
        {
            for (int i = 0; i < nrDisplayedItem; i++)
            {
                form.Controls.Remove(btnItem[i]);
                form.Controls.Remove(btnDeleteItem[i]);
            }
            btnItem = new List<Button>();
            btnDeleteItem = new List<Button>();
            nrDisplayedItem = 0;
        }
    }
}