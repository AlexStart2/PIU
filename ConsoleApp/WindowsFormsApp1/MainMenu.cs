using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        private Button DisplayCoursesButton;
        private Button AddCourseButton;
        private Button StoreCoursesButton;
        private Button SearchCoursesButton;
        private TextBox SearchBar;

        public static GroupCourses groupCourses = new GroupCourses();
        public static List<Course> displayedCourses = new List<Course>();

        public MainMenu()
        {
            new SearchCourse();
            groupCourses.readDataFromFile();
            displayedCourses = groupCourses.getCourses;

            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            DisplayCoursesButton = DisplayCourses.getButton;
            AddCourseButton = AddCourse.getButton;
            StoreCoursesButton = StoreCourses.getButton;
            SearchCoursesButton = SearchCourse.getButton;
            SearchBar = SearchCourse.getSearchBar;

            this.Controls.Add(SearchBar);

            this.Controls.AddRange(new Button[] { DisplayCoursesButton, AddCourseButton, StoreCoursesButton, SearchCoursesButton });
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu";
            DisplayCoursesButton.PerformClick();
        }
    }
}
