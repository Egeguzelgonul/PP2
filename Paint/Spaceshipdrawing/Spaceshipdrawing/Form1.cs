using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceshipdrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 800;
        }

        Rectangle Karachi = new Rectangle(20, 20, 20, 20);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Black);
            Brush myBrushblue = new SolidBrush(Color.Blue);
            Brush myBrushwhite = new SolidBrush(Color.White);
            Brush myBrushred = new SolidBrush(Color.Red);
            Brush myBrushgreen = new SolidBrush(Color.Green);

            Rectangle backgroundblack = new Rectangle (0, 0, 800, 600);
            g.FillRectangle(myBrush, backgroundblack);

            Rectangle backgroundblue = new Rectangle(20, 20, 740, 520);
            g.FillRectangle(myBrushblue, backgroundblue);

            g.FillEllipse(myBrushwhite, new Rectangle(80, 120, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(650, 230, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(400, 420, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(150, 360, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(90, 420, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(240, 500, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(460, 120, 30, 30));
            g.FillEllipse(myBrushwhite, new Rectangle(310, 50, 30, 30));

            void MyStar(int c, int x, int y)
            {
                Point[] star = { new Point(x, y), new Point(x+c/5, y+c/5), new Point(x+2*c/5, y+c/5), new Point(x+c/5, y+2*c/5), new Point(x + 2 * c / 5, y + 3 * c / 5), new Point(x + c / 5, y + 3 * c / 5), new Point(x, y + 4 * c / 5), new Point(x, y + 4 * c / 5), new Point(x - c / 5, y + 3 * c / 5), new Point(x - 2 * c / 5, y + 3 * c / 5), new Point(x - c / 5, y + 2 * c / 5), new Point(x - 2 * c / 5, y + c / 5), new Point(x - c / 5, y + c / 5) };

                g.FillPolygon(myBrushred, star);
            }

            MyStar(50, 100, 300);
            MyStar(50, 400, 480);
            MyStar(50, 600, 140);
            MyStar(50, 650, 400);

            g.FillRectangle(myBrushgreen, Karachi);

            g.FillRectangle(Brushes.White, 500, 50, 150, 25);
            g.DrawRectangle(Pens.Red, 500, 50, 150, 25);

            using (Font font1 = new Font("Times New Roman", 11, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                PointF pointF1 = new PointF(500, 50);
                e.Graphics.DrawString("Level:1 Score:200 Lives:***", font1, Brushes.Black, pointF1);
            }
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            bool yincrease = true;
            bool xincrease = true;
            if (Karachi.X >= 800 && xincrease)
            {
                Karachi.X -= 30;
                xincrease = false;
            }
            if (Karachi.X <= 0 && !xincrease)
            {
                Karachi.X += 30;
                xincrease = true;
            }
            if (Karachi.Y >= 600 && yincrease)
            {
                Karachi.Y -= 20;
                yincrease = false;
            }
            if (Karachi.Y <= 0 && !yincrease)
            {
                Karachi.Y += 20;
                yincrease = true;
            }
            Invalidate();
        }
    }
}
