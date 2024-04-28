using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp1
{
    public partial class CourseForm : Form
    {
        static public Course course = new Course();
        private readonly Form main = new Form();

        private Button Exam = new Button();
        private Button EditName = new Button();
        private Button DeleteQuestion = new Button();
        private Button SaveQuestion = new Button();
        private Button AddQuestion = new Button();
        private Button SearchQuestionButton = new Button();
        private TextBox SearchQuestionBar = new TextBox();

        internal static Search CourseSearch = new Search(new Question());
        internal static DisplayItems displayQuestion = new DisplayItems(new Form());
        public static List<Question> displayedQuestions = new List<Question>();

        public CourseForm(Course _course, Form _main)
        {
            displayQuestion = new DisplayItems(this);

            MenuButton.nrButton = 0;

            Exam = MenuButton.NewButton("Raspunde la intrebari");
            AddQuestion = MenuButton.NewButton("Adauga intrebare");
            DeleteQuestion = MenuButton.NewButton("Sterge intrebare");
            SaveQuestion = MenuButton.NewButton("Salveaza modificari");
            EditName = MenuButton.NewButton("Editează numele cursului");

            SearchQuestionButton = CourseSearch.getButton;
            SearchQuestionBar = CourseSearch.getSearchBar;


            course = _course;
            this.main = _main;
            InitializeComponent();

            Size = new System.Drawing.Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;

            EditName.Click += (object sender, EventArgs e) =>
            {
                Form editName = new Form 
                {
                    Text = "Schimba numele", // Set the title of the form
                    Size = new Size(300, 150) // Set the size of the form
                };

                Button btnEditCourseName = new Button
                {
                    Text = "Schimba",
                    Location = new Point(20, 50),
                    Size = new Size(100, 30),
                    Cursor = Cursors.Hand
                };

                TextBox text = new TextBox();
                text.Text = course.getName;

                btnEditCourseName.Click += (object send, EventArgs ev) =>
                {
                    if(Validations.LengthStringValidation(text.Text).Length != 0)
                    {

                    }
                    course.setName = text.Text;
                    editName.Close();
                };


                editName.StartPosition = FormStartPosition.CenterScreen;

                editName.Controls.Add(btnEditCourseName);
                editName.Controls.Add(text);

                editName.ShowDialog();
            };

            this.Controls.Add(SearchQuestionBar);

            this.Controls.AddRange(new Button[] { Exam, EditName, AddQuestion, DeleteQuestion, SaveQuestion, SearchQuestionButton });
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            Text = course.getName;
            //DisplayItems.getQuestionsButton.PerformClick();

            this.FormClosed += (object send, FormClosedEventArgs ev) =>
            {
                main.Show();
                this.Hide();
            };
        }
    }
}
