using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2__1__2_ex_
{
    public partial class Form1 : Form
    {
        private List<string> shapeCommands = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Спочатку очищуємо полотно
            g.Clear(pictureBoxCanvas.BackColor);

            // Створюємо всі наші інструменти
            Pen blackPen = new Pen(Color.Black, 2);
            Pen greenPen = new Pen(Color.Green, 2);
            SolidBrush greenBrush = new SolidBrush(Color.DarkGreen);
            Pen bluePen = new Pen(Color.Blue, 2);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen yellowPen = new Pen(Color.Yellow, 2);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            // Проходимо по списку команд і малюємо все по черзі
            foreach (string command in shapeCommands)
            {
                switch (command)
                {
                    case "line":
                        g.DrawLine(blackPen, 100, 100, 400, 200);
                        break;
                    case "rect":
                        g.DrawRectangle(greenPen, 150, 150, 200, 100);
                        break;
                    case "fillRect":
                        g.FillRectangle(greenBrush, 170, 170, 160, 80);
                        break;
                    case "ellipse":
                        g.DrawEllipse(greenPen, 150, 280, 200, 100);
                        break;
                    case "fillEllipse":
                        g.FillEllipse(greenBrush, 170, 290, 160, 80);
                        break;
                    case "sector":
                        g.FillPie(blueBrush, 50, 200, 150, 150, 180, 90);
                        break;
                    case "star":
                        Point[] starPoints = new Point[] {
                            new Point(250, 50), new Point(280, 150), new Point(380, 150),
                            new Point(300, 200), new Point(350, 300), new Point(250, 250),
                            new Point(150, 300), new Point(200, 200), new Point(120, 150),
                            new Point(220, 150)
                        };
                        g.FillPolygon(yellowBrush, starPoints);
                        g.DrawPolygon(yellowPen, starPoints);
                        break;
                }
            }

        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("line"); 
            pictureBoxCanvas.Invalidate();
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("rect");
            pictureBoxCanvas.Invalidate();
        }

        private void btnFillRect_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("fillRect");
            pictureBoxCanvas.Invalidate();
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("ellipse");
            pictureBoxCanvas.Invalidate();
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("fillEllipse");
            pictureBoxCanvas.Invalidate();
        }

        private void btnDrawSector_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("sector");
            pictureBoxCanvas.Invalidate();
        }

        private void btnDrawStar_Click(object sender, EventArgs e)
        {
            shapeCommands.Add("star");
            pictureBoxCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            shapeCommands.Clear(); 
            pictureBoxCanvas.Invalidate();
        }
    }
} 