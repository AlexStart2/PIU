using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApp;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        private int nrDisplayedCourse = 0;
        private string searchText = "";

        private Button btnDisplayCourses;
        private Button btnAddCourse;
        private Button btnEditCourse;
        private Button btnStoreCourses;
        private Button btnSearchCourse;
        private List<Button> btnCourse = new List<Button>();
        private List<Button> btnDeleteCourse = new List<Button>();

        private TextBox txtSearchCourse;

        private GroupCourses groupCourses = new GroupCourses();
        private List<Course> displayedCourses = new List<Course>();

        private TextBox txtCourseName;

        Form addCourseForm = new Form();

        public MainMenu()
        {

            groupCourses.readDataFromFile();

            displayedCourses = groupCourses.getCourses;

            txtSearchCourse = new TextBox();
            txtSearchCourse.Location = new Point(270, 15);
            txtSearchCourse.Size = new Size(700, 30);
            txtSearchCourse.Font = new Font("Arial", 10);
            txtSearchCourse.BackColor = Color.LightGray;
            txtSearchCourse.MaxLength = 50;
            this.Controls.Add(txtSearchCourse);

            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnDisplayCourses = NewButton("Afiseaza materii",10,10);
            btnDisplayCourses.Click += (object sender, EventArgs e) => {
                searchText = "";
                displayedCourses = groupCourses.getCourses;
                CourseList(ref displayedCourses);
            };

            btnAddCourse = NewButton("Adauga materie", 10, 90);
            btnAddCourse.Click += AddCourse;

            btnStoreCourses = NewButton("Salveaza materiile", 10, 170);
            btnStoreCourses.Click += (object sender, EventArgs e) =>
            {
                groupCourses.writeDataInFile();
                MessageBox.Show("Data was saved");
            };

            btnSearchCourse = new Button
            {
                Text = "Cauta",
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand,
                Font = new Font("Arial", 8, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(750, 12)
            };

            btnSearchCourse.Click += SetSearchText;
            txtSearchCourse.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    this.SetSearchText(sender, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            CourseList(ref displayedCourses);
            
            this.Controls.AddRange(new Button[] { btnDisplayCourses, btnAddCourse, btnStoreCourses, btnSearchCourse });
        }

        
        private Button NewButton(string text, int x = 0, int y = 0)
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
            nrDisplayedCourse++;
            btnCourse.Add( new Button
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
                    int index = groupCourses.getCourses.IndexOf(a);
                    DeleteCourseList();
                    groupCourses.removeCourse(index);
                    displayedCourses = groupCourses.getCourses;
                    
                    this.SearchCourse(sender, e);
                }
            };

            this.Controls.Add(btnDeleteCourse[currentIndex]);

            this.Controls.Add(btnCourse[currentIndex]);
        }

        private void DeleteButtonHover (object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.MistyRose;
        }

        private void DeleteButtonNotHover(object sender, EventArgs e)
        {
        Button button = sender as Button;
        button.BackColor = Color.White;
        }

        private void CourseList( ref List<Course> list)
        {
            DeleteCourseList();
            for (int i = 0; i < list.Count; i++)
            {
                DisplayCourse(list[i], 200, 50 + i * 50);
            }
        }

        private void DeleteCourseList()
        {   
            for (int i = 0; i < nrDisplayedCourse; i++)
            {
                this.Controls.Remove(btnCourse[i]);
                this.Controls.Remove(btnDeleteCourse[i]);
            }
            btnCourse = new List<Button>();
            btnDeleteCourse = new List<Button>();
            nrDisplayedCourse = 0;
        }

        private void SetSearchText(object sender, EventArgs e)
        {
            searchText = txtSearchCourse.Text;
            this.SearchCourse(sender, e);
        }

        private void SearchCourse(object sender, EventArgs e)
        {
            if(searchText.Trim().Equals(""))
            {
                List<Course> l = groupCourses.getCourses;
                CourseList(ref l);
                return;
            }

            GroupCourses FoundedCourses = new GroupCourses(groupCourses.findByName(searchText));
            displayedCourses = FoundedCourses.getCourses;
            CourseList(ref displayedCourses);
        }

        private void AddCourse(object sender, EventArgs e)
        {
            Form addCourseForm = new Form
            {
                Text = "Add New Course", // Set the title of the form
                Size = new Size(300, 150) // Set the size of the form
            };


            txtCourseName = new TextBox
            {
                Location = new Point(20, 20),
                Size = new Size(200, 20)
            };
            txtCourseName.KeyDown += (object send, KeyEventArgs ev) =>
            {
                if(ev.KeyCode == Keys.Enter)
                {
                    this.AddCourseEvent(sender, ev);
                    ev.Handled = true;
                    ev.SuppressKeyPress = true;
                }
                
            };
            addCourseForm.Controls.Add(txtCourseName);


            Button btnAddCourse = new Button
            {
                Text = "Add Course",
                Location = new Point(20, 50),
                Size = new Size(100, 30)
            };
            btnAddCourse.Click += AddCourseEvent;
            addCourseForm.Controls.Add(btnAddCourse);

            addCourseForm.ShowDialog();
        }


            private void AddCourseEvent(object sender, EventArgs ev)
            {

                string courseName = txtCourseName.Text.Trim();

                if (!string.IsNullOrEmpty(courseName))
                {
                    groupCourses.addCourse(courseName); 

                    addCourseForm.Close(); /////////////// not working, don't know why

                    displayedCourses = groupCourses.getCourses;
                    CourseList(ref displayedCourses);
    }
                else
                {
                    MessageBox.Show("Please enter a course name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
