using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        private Button btnDisplayCourses;
        private Button btnAddCourse;
        private Button btnEditCourse;
        private Button btnStoreCourses;
        private Button btnSearchCourse;

        private TextBox txtSearchCourse;

        private GroupCourses groupCourses = new GroupCourses();

        public MainMenu()
        {

            groupCourses.readDataFromFile();

            txtSearchCourse = new TextBox();
            txtSearchCourse.Location = new Point(270, 15);
            txtSearchCourse.Size = new Size(700, 30);
            txtSearchCourse.Font = new Font("Arial", 10);  // Change font and size
            txtSearchCourse.BackColor = Color.LightGray;  // Change background color
            txtSearchCourse.MaxLength = 50;
            this.Controls.Add(txtSearchCourse);

            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnDisplayCourses = newButton("Afiseaza materii",10,10);
            btnAddCourse = newButton("Adauga materie", 10, 90);
            btnStoreCourses = newButton("Salveaza materiile", 10, 170);

            btnSearchCourse = new Button();
            btnSearchCourse.Text = "Cauta";
            btnSearchCourse.BackColor = Color.LightBlue;
            btnSearchCourse.ForeColor = Color.Black;
            btnSearchCourse.Cursor = Cursors.Hand;
            btnSearchCourse.Font = new Font("Arial", 8, FontStyle.Bold);
            btnSearchCourse.FlatStyle = FlatStyle.Flat;
            btnSearchCourse.Location = new Point(750, 12);


            for(int i = 0; i < groupCourses.getNrCourse-1; i++)
            {
                DisplayCourse(groupCourses.GetCourse(i), 200, 50 + i * 50);
            }
            
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
            Button btnCourse = new Button();
            btnCourse.Location = new Point(x, y);
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.Size = new Size(625, 40);
            btnCourse.Text = a.getName;
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.BackColor = Color.LightBlue;

            Button btnDeleteCourse = new Button();

            btnDeleteCourse.Text = "X"; // Display "X" as the button text
            btnDeleteCourse.Font = new Font("Arial", 8, FontStyle.Bold); // Set the font
            btnDeleteCourse.Size = new Size(25, 25); // Set the size
            btnDeleteCourse.FlatStyle = FlatStyle.Flat; // Use flat style to remove the default button border
            btnDeleteCourse.BackColor = Color.White; // Set the initial background color
            btnDeleteCourse.ForeColor = Color.Black;
            btnDeleteCourse.Location = new Point(x+580, y+7);
            btnDeleteCourse.Cursor = Cursors.Hand;
            btnDeleteCourse.MouseEnter += (object sender, EventArgs e) =>
            {
                btnDeleteCourse.BackColor = Color.MistyRose;
            };

            btnDeleteCourse.MouseLeave += (object sender, EventArgs e) =>
            {
                btnDeleteCourse.BackColor = Color.White;
            };

            btnDeleteCourse.Click += (object sender, EventArgs e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + btnCourse.Text + "\" ?", 
                    "Confirmation", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = groupCourses.getCourses.IndexOf(a);
                    groupCourses.removeCourse(index);
                }
            };

            this.Controls.Add(btnDeleteCourse);

            this.Controls.Add(btnCourse);
        }




        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
