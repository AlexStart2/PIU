using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        private Button btnDisplayCourses;
        private Button btnAddCourse;
        private Button btnEditCourse;
        private Button btnStoreCourses;
        private Button btnCourse;
        private Button btnSearchCourse;

        private GroupCourses groupCourses = new GroupCourses();

        public MainMenu()
        {

            groupCourses.readDataFromFile();

            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnDisplayCourses = newButton("Afiseaza materii",10,10);
            btnAddCourse = newButton("Adauga materie", 10, 90);
            btnStoreCourses = newButton("Salveaza materiile", 10, 170);

            btnSearchCourse = new Button();
            btnSearchCourse.Text = "Cauta";
            btnSearchCourse.BackColor = Color.AliceBlue;
            btnSearchCourse.Font = new Font("Arial", 8, FontStyle.Bold);
            btnSearchCourse.Location = new Point(600, 10);



            this.Controls.AddRange(new Button[] { btnDisplayCourses, btnAddCourse, btnStoreCourses, btnSearchCourse });
        }

        
        private Button newButton(string text, int x = 0, int y = 0)
        {
            return new Button() { 
                Text = text, 
                BackColor = Color.LightBlue, 
                ForeColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 70),
                Location = new Point(x, y),
                Cursor = Cursors.Hand
            };
        }

        private void DisplayCourse(Course a, int x, int y)
        {
            if (a == null)
            {
                return;
            }
            btnCourse = new Button();
            btnCourse.Location = new Point(x, y);
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.Size = new Size(300, 30);
            this.Controls.Add(btnCourse);
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
