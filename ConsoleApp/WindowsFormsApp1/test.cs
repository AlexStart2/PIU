using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class test : Form
    {
        //private Course course;
        List<Question> questions;
        const int marginLeft = 50;
        const int ImageWidth = 400;
        const int QuestionSize = 10;
        readonly Color AnswerColor = Color.Green;
        readonly Color WrongAnswerColor = Color.Red;
        PictureBox pictureBox = new PictureBox();

        private int nrQuestion = 0;
        private Label selectAnswer = MainMenu.newErrorLbl();

        public test(Course course)
        {
            //this.course = course;
            questions = course.getQuestions;
            InitializeComponent();

            displayQuestion(questions[nrQuestion]);  

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void displayQuestion(Question question)
        {
            selectAnswer.Text = "";

            pictureBox.Size = new Size(0, 0);
            Label labelQuestion = new Label();

            if (question.ImagePath != null && question.ImagePath != "Images/" && question.ImagePath != "")
            {

                try
                {
                    pictureBox.Image = Image.FromFile(question.ImagePath);

                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    int width = pictureBox.Image.Width;
                    int height = pictureBox.Image.Height;
                    if (width > height)
                    {
                        pictureBox.Width = ImageWidth;
                        pictureBox.Height = ImageWidth * height / width;
                    }
                    else
                    {
                        pictureBox.Height = ImageWidth;
                        pictureBox.Width = ImageWidth * width / height;
                    }

                    pictureBox.Location = new Point(marginLeft, 50);
                
                    this.Controls.Add(pictureBox);
                    }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Eroare", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }

            labelQuestion.Text = question.getQuestion;
            labelQuestion.Font = new Font("Arial", QuestionSize);
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(marginLeft, 50 + pictureBox.Height + 10);
            this.Controls.Add(labelQuestion);

            Label difficulty = new Label
            {
                Text = "Nivel de dificultate: " + question.getDifficultyLevel,
                AutoSize = true,
                Location = new Point(marginLeft, labelQuestion.Location.Y + labelQuestion.Height + 20),
                Font = new Font("Arial", QuestionSize)
            };

            this.Controls.Add(difficulty);

            List<string> answers = question.getPossibleAnswers;

            int nr = 0;
            RadioButton radioButton = new RadioButton();
            foreach (string answer in answers)
            {
                nr++;
                radioButton = new RadioButton();
                radioButton.Text = answer;
                radioButton.Font = new Font("Arial", QuestionSize);
                radioButton.AutoSize = true;
                radioButton.Location = new Point(marginLeft, difficulty.Location.Y + 
                    difficulty.Height + 18 * nr);
                radioButton.Click += HideWarning;
                this.Controls.Add(radioButton);
            }

            Button Submit = new Button
            {
                Text = "Next",
                AutoSize = true,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };

            Submit.Location = new Point(marginLeft, radioButton.Location.Y + 60);
            Submit.Click += Submit_Click;

            this.Controls.Add(Submit);
        }

        private void HideWarning(object sender, EventArgs e)
        {
            selectAnswer.Text = "";
        }

        private void test_Load(object sender, EventArgs e)
        {
            this.FormClosing += (object send, FormClosingEventArgs ev) =>
            {
                Console.WriteLine(pictureBox.Image);
                if (pictureBox.Image != null)
                {
                    Console.WriteLine("Dispose");
                    pictureBox.Image.Dispose();
                }
            };
        }

        void Submit_Click(object sender, EventArgs e)
        {
            Button Submit = (Button)sender;
            Submit.Enabled = false;
            bool isChecked = false;
            List<RadioButton> radioButtons = new List<RadioButton>();
            RadioButton answer = null;
            foreach (Control control in this.Controls)
            {

                if (control is RadioButton radioButton)
                {
                    radioButtons.Add((radioButton));
                    if (radioButton.Text.Equals(questions[nrQuestion].getCorrectAnswer))
                    {
                        answer = radioButton;
                    }

                    if (radioButton.Checked)
                    {
                        isChecked = true;
                        if (radioButton.Text.Equals(questions[nrQuestion].getCorrectAnswer))
                        {
                            answer.ForeColor = AnswerColor;
                            answer.Font = new Font(answer.Font, FontStyle.Bold);
                            this.Controls.Add(AwaitClick());
                        }
                        else
                        {
                            radioButton.ForeColor = WrongAnswerColor;
                            this.Controls.Add(AwaitClick());
                        }
                    }
                    else if (!radioButton.Text.Equals(questions[nrQuestion].getCorrectAnswer))
                    {
                        radioButton.Enabled = false;
                    }
                }
            }

            if (!isChecked)
            {
                selectAnswer.Text = "Select an answer";
                selectAnswer.Location = new Point(marginLeft, Submit.Location.Y - 20);
                this.Controls.Add(selectAnswer);

                foreach (RadioButton radioButton in radioButtons)
                {
                    radioButton.Enabled = true;
                }

                Submit.Enabled = true;
            }
            else
            {
                answer.ForeColor = AnswerColor;
                answer.Font = new Font(answer.Font, FontStyle.Bold);
            }
            
        }

        private void Next_Question(object sender, EventArgs e)
        {
            this.Controls.Clear();
            nrQuestion++;
            
            if (nrQuestion < questions.Count)
            {
                displayQuestion(questions[nrQuestion]);
            }
            else
            {
                MessageBox.Show("Test terminat", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private Label AwaitClick()
        {
            Label result = new Label();
            result.Size = new Size(this.Width, this.Height);
            result.Location = new Point(0,0);
            result.Click += Next_Question;
            return result;
        }
    }
}