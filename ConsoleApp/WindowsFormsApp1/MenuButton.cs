
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class MenuButton
    {
        static public Button NewButton(string text, int x = 0, int y = 0)
        {
            return new Button()
            {
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
    }
}