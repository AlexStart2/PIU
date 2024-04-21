
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class MenuButton
    {
        private const int MarginLeft = 10;
        private const int MarginTop = 80;
        private const int Width = 100;
        private const int Height = 70;

        static public int nrButton { get; set; }

        static public Button NewButton(string text, int x = 0, int y = 0, int width = Width, int height = Height)
        {
            int xCoord = MarginLeft;
            int yCoord = MarginTop*nrButton + 10;

            if (x != 0)
            {
                xCoord = x;
            }
            if (y != 0)
            {
                yCoord = y;
            }
            ++nrButton;
            return new Button()
            {
                Text = text,
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(width, height),
                Location = new Point(xCoord, yCoord),
                Cursor = Cursors.Hand
            };
        }
    }
}