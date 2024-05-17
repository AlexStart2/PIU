using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class AddQuestionForm : Form
    {
        const int nrWrongAnswers = 3;
        const int marginErrorTop = 2;

        private Course course;
        public const string SELECT_OPTION = "Select an option";
        string selectedImagePath= "";
        private readonly Question question;

        Label Error_WrongAnswerList = MainMenu.newErrorLbl();
        Label Error_AddWrongAnswer = MainMenu.newErrorLbl();
        Label Select_difficulty = MainMenu.newErrorLbl();
        Label EmptyQuestion = MainMenu.newErrorLbl();
        Label EmptyAnswer = MainMenu.newErrorLbl();

        public AddQuestionForm(Course course, Question question = null)
        {
            InitializeComponent();
            this.course = course;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Adauga intrebare";
            this.question = question;
            if (question != null)
            {
                AddNewQuestion.Text = "Editeaza intrebarea";
                this.Text = "Editeaza intrebare";
            }
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            if(question!=null)
            {
                QuestionBox.Text = question.getQuestion;
                CorrectAnswerBox.Text = question.getCorrectAnswer;
                switch (question.getDifficultyLevel)
                {
                    case difficultyLevel.Easy:
                        rdBtnEasy.Checked = true;
                        break;
                    case difficultyLevel.Normal:
                        rdBtnNormal.Checked = true;
                        break;
                    case difficultyLevel.Hard:
                        rdBtnHard.Checked = true;
                        break;
                    case difficultyLevel.Master:
                        rdBtnMaster.Checked = true;
                        break;
                    case difficultyLevel.Expert:
                        rdBtnExpert.Checked = true;
                        break;
                }

                foreach (string wa in question.getWrongAnswers)
                {
                    WrongAnswerList.Items.Add(wa);
                }

                if (question.ImagePath != null && question.ImagePath!=""&& question.ImagePath!="Images/")
                {
                    try
                    {
                        selectedImagePath = question.ImagePath;
                        ImageName.Text = selectedImagePath.Substring(selectedImagePath.LastIndexOf("/") + 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MainMenu.ERROR + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            DeleteImage_Click(sender, e);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedImagePath = openFileDialog.FileName;
                    ImageName.Text = selectedImagePath.Substring(selectedImagePath.LastIndexOf("\\") + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MainMenu.ERROR + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddWrongAnswer_Click(object sender, EventArgs e)
        {
            Error_AddWrongAnswer.Text = "";
            try
            {
                Validations.LengthStringValidation(WrongAnswerBox.Text, 1, 255);
                WrongAnswerList.Items.Add(WrongAnswerBox.Text);
                WrongAnswerBox.Text = "";
            }
            catch (Exception ex)
            {
                Error_AddWrongAnswer.Text = ex.Message;

                int x = WrongAnswerBox.Location.X;
                int y = WrongAnswerBox.Location.Y + WrongAnswerBox.Height + marginErrorTop;

                Error_AddWrongAnswer.Location = new Point(x, y);
                Error_AddWrongAnswer.AutoSize = true;
                Error_AddWrongAnswer.ForeColor = Color.Red;
                this.Controls.Add(Error_AddWrongAnswer);
            }
        }

        private void WrongAnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddWrongAnswer_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                EmptyQuestion.Text = "";
                EmptyAnswer.Text = "";

                if (QuestionBox.Text == "")
                {
                    EmptyQuestion.Text = "Question cannot be empty";
                    EmptyQuestion.Location = new Point(QuestionBox.Location.X, QuestionBox.Location.Y + 
                        QuestionBox.Height + marginErrorTop);
                    this.Controls.Add(EmptyQuestion);
                    return;
                }

                difficultyLevel l;
                Select_difficulty.Text = "";
                Select_difficulty.AutoSize = true;
                Select_difficulty.ForeColor = Color.Red;
                int x = rdBtnExpert.Location.X;
                int y = rdBtnExpert.Location.Y + rdBtnExpert.Height + marginErrorTop;

                Select_difficulty.Location = new Point(x, y);

                switch (true)
                {
                    case true when rdBtnEasy.Checked:
                        l = difficultyLevel.Easy;
                        break;
                    case true when rdBtnNormal.Checked:
                        l = difficultyLevel.Normal;
                        break;
                    case true when rdBtnHard.Checked:
                        l = difficultyLevel.Hard;
                        break;
                    case true when rdBtnMaster.Checked:
                        l = difficultyLevel.Master;
                        break;
                    case true when rdBtnExpert.Checked:
                        l = difficultyLevel.Expert;
                        break;
                    default:
                        Select_difficulty.Text = SELECT_OPTION;
                        this.Controls.Add(Select_difficulty);
                        return;
                }

                if (CorrectAnswerBox.Text == "")
                {
                    EmptyAnswer.Text = "Correct answer cannot be empty";
                    EmptyAnswer.Location = new Point(CorrectAnswerBox.Location.X, CorrectAnswerBox.Location.Y +
                        CorrectAnswerBox.Height + marginErrorTop);
                    this.Controls.Add(EmptyAnswer);
                    return;
                }

                int nrWA = WrongAnswerList.Items.Count;

                if (nrWA < nrWrongAnswers)
                {
                    Error_WrongAnswerList.Text = "Intrebarea trebuie sa aiba cel putin " +nrWrongAnswers +" raspunsuri gresite";
                    Error_WrongAnswerList.Location = new Point(WrongAnswerList.Location.X, WrongAnswerList.Location.Y 
                        + WrongAnswerList.Height + marginErrorTop);
                    this.Controls.Add(Error_WrongAnswerList);
                    return;
                }

                string[] wrongAnswers = new string[WrongAnswerList.Items.Count];

                for (int i = 0; i < WrongAnswerList.Items.Count; i++)
                {
                    wrongAnswers[i] = WrongAnswerList.Items[i].ToString();
                }

                string ImgName="";


                if (ImageName.Text != "")
                {
                    string projectDirectory = Directory.GetCurrentDirectory()+"\\Images";
                    string targetImagePath = Path.Combine(projectDirectory, Path.GetFileName(selectedImagePath));
                    File.Copy(selectedImagePath, targetImagePath, true);

                    ImgName = selectedImagePath.Substring(selectedImagePath.LastIndexOf("\\") + 1);
                }

                if(question != null)
                {
                    int index = course.getQuestions.FindIndex(q => q.getQuestion == question.getQuestion);
                    course.editQuestion(index, QuestionBox.Text, wrongAnswers, CorrectAnswerBox.Text, (int)l, "Images/" + ImgName);
                    this.Close();
                    return;
                }

                course.addQuestion(QuestionBox.Text, wrongAnswers, CorrectAnswerBox.Text, (int)l, "Images/" + ImgName);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(MainMenu.ERROR + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteWrongAnswer_Click(object sender, EventArgs e)
        {
            Error_WrongAnswerList.Text = "";

            if (WrongAnswerList.SelectedItem == null)
            {
                
                Error_WrongAnswerList.Text = SELECT_OPTION;

                int x = WrongAnswerList.Location.X;
                int y = WrongAnswerList.Location.Y + WrongAnswerList.Height + marginErrorTop;

                Error_WrongAnswerList.Location = new Point(x, y);
                this.Controls.Add(Error_WrongAnswerList);
                return;
            }
            WrongAnswerList.Items.Remove(WrongAnswerList.SelectedItem);
        }

        private void DeleteImage_Click(object sender, EventArgs e)
        {
            ImageName.Text = "";
            if(question != null && question.ImagePath != "" && question.ImagePath != "Images/")
            {
                File.Delete(question.ImagePath);
            }
        }
    }
}
