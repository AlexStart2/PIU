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
        internal static DisplayItems displayCourses = new DisplayItems(new Form());
        internal static Search MainSearch = new Search(new Course());

        public MainMenu()
        {

            groupCourses.readDataFromFile();
            displayedCourses = groupCourses.getCourses;
            displayCourses = new DisplayItems(this);

            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            
            DisplayCoursesButton = displayCourses.getCoursesButton;
            AddCourseButton = AddCourse.getButton;
            StoreCoursesButton = StoreCourses.getButton;
            SearchCoursesButton = MainSearch.getButton;
            SearchBar = MainSearch.getSearchBar;

            this.Controls.Add(SearchBar);

            this.Controls.AddRange(new Button[] { DisplayCoursesButton, AddCourseButton, StoreCoursesButton, SearchCoursesButton });
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = " - Meniu Principal";
            DisplayCoursesButton.PerformClick();
        }
    }
}
