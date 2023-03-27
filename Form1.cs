//COMP-213 - Visual Programming
//Assigment 1
//Dmitrii Frolov
//U214N1483
//20.03.2023
//
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace assigment1
{
    public partial class Form1 : Form
    {
        private Point startPosition;
        private Point endPosition;
        private int totalDistance;
        private int currentDistance = 0;
        private Point P,P1;
        bool doDrag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void imgRedCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDrag)
            {
                imgRedCard.Left = imgRedCard.Left + e.X - P.X;
                imgRedCard.Top = imgRedCard.Top + e.Y - P.Y;
            }
        }

        private void imgRedCard_MoseDown(object sender, MouseEventArgs e)
        {
            P = e.Location;
            doDrag = true;
        }

        private void imgRedCard_MoseUp(object sender, MouseEventArgs e)
        {
            doDrag = false;
        }
        private void imgBlackCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDrag)
            {
                imgBlackCard.Left = imgBlackCard.Left + e.X - P.X;
                imgBlackCard.Top = imgBlackCard.Top + e.Y - P.Y;
            }
        }

        private void imgBlackCard_MoseDown(object sender, MouseEventArgs e)
        {
            P = e.Location;
            doDrag = true;
        }

        private void imgBlackCard_MoseUp(object sender, MouseEventArgs e)
        {
            doDrag = false;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            startPosition = imgBlackCard.Location;
            endPosition = imgRedCard.Location;
            timer1.Enabled = true;
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (imgBlackCard.Location != imgRedCard.Location)//block to change card position
            {
                startPosition = imgBlackCard.Location;
                currentDistance += 5;
                totalDistance = (int)Math.Sqrt(Math.Pow(endPosition.X - startPosition.X, 2) + Math.Pow(endPosition.Y - startPosition.Y, 2));
                P1.X = startPosition.X + (int)(((double)currentDistance / totalDistance) * (endPosition.X - startPosition.X) );
                P1.Y = startPosition.Y + (int)(((double)currentDistance / totalDistance) * (endPosition.Y - startPosition.Y) );
                imgBlackCard.Location = new Point(P1.X, P1.Y);
                if (currentDistance > totalDistance)
                {
                    imgBlackCard.Location = imgRedCard.Location;
                }
            }
            else //reset all and stop moving prosses
            {

                totalDistance = 0;
                currentDistance = 0;
                timer1.Enabled=false;
            }
        }
    }
} 