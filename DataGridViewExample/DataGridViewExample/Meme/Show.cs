using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Meme
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        public Show shw;

        private void Show_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            startXPoss = new Random().Next(0, 1000);
            startLocationY = new Random().Next(0, 800);
            timer1.Interval = new Random().Next(0, 200);

            timer1.Start();
        }

        int startXPoss = 0;
        int startLocationY = 0;
        bool incrementX = true;
        bool incrementY = true;


        public void ReturnY()
        {
            if (incrementY)
            {
                startLocationY = startLocationY + 5;

                if ((startLocationY + 149) >= 800)
                {
                    incrementY = false;
                }
            }
            else
            {
                startLocationY = startLocationY - 5;

                if (startLocationY <= 0)
                {
                    incrementY = true;
                }
            }
        }

        public void ReturnX()
        {
            if (incrementX)
            {
                startXPoss = startXPoss + 5;

                if ((startXPoss + 223) >= 1380)
                {
                    incrementX = false;
                }
            }
            else
            {
                startXPoss = startXPoss - 5;

                if (startXPoss <= 0)
                {
                    incrementX = true;
                }
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            this.Location = new Point(startXPoss, startLocationY);
            ReturnY();
            ReturnX();
        }
    }
}
