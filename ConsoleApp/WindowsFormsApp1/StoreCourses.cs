
using System.Drawing;
using System;
using System.Windows.Forms;
using ConsoleApp;


namespace WindowsFormsApp1
{
    internal class StoreCourses
    {
        static private Button btnStoreCourses = new Button();

        static public Button getButton
        {
            get
            {
                btnStoreCourses = MenuButton.NewButton("Salveaza materiile", 10, 170);
                btnStoreCourses.Click += (object sender, EventArgs e) =>
                {
                    MainMenu.groupCourses.writeDataInFile();
                    MessageBox.Show("Data was saved");
                };
                return btnStoreCourses;
            }
        }
    }
}