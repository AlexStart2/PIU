
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

        static public Button NewButton(string text, int x = -1, int y = -1, int width = Width, int height = Height, string Font = "Arial", float textSize = 12f, bool nextBtn = true)
        {
            int xCoord = MarginLeft;
            int yCoord = MarginTop*nrButton + 10;

            if (x != -1)
            {
                xCoord = x;
            }
            if (y != -1)
            {
                yCoord = y;
            }
            if(nextBtn)
            {
                ++nrButton;
            }
            
            return new Button()
            {
                Text = text,
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Font = new Font(Font, textSize, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(width, height),
                Location = new Point(xCoord, yCoord),
                Cursor = Cursors.Hand
            };
        }
    }
}