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
        private Course course;

        public AddQuestionForm(Course course)
        {
            InitializeComponent();
            this.course = course;
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;

                    //string projectDirectory = Directory.GetCurrentDirectory();
                    //string targetImagePath = Path.Combine(projectDirectory, Path.GetFileName(selectedImagePath));
                    //File.Copy(selectedImagePath, targetImagePath, true);

                    imagePreview.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MainMenu.ERROR + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
