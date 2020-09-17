using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Concentration.Properties;

namespace Concentration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isBack0 = true;
        private bool isBack1 = true;
        private bool isBack2 = true;
        private bool isBack3 = true;
        private bool isBack4 = true;
        private bool isBack5 = true;

        private void card_1_Click(object sender, EventArgs e)
        {
            {
                if (!isBack0)
                {
                    card_1.Image = Resources.shawarma;
                    isBack0 = true;
                }
                else
                {
                    card_1.Image = Resources.green_banana;
                    isBack0 = false;
                }
            }
        }

        private void card_2_Click(object sender, EventArgs e)
        {
            {
                if (!isBack1)
                {
                    card_2.Image = Resources.shawarma;
                    isBack1 = true;
                }
                else
                {
                    card_2.Image = Resources.green_banana;
                    isBack1 = false;
                }
            }
        }

        private void card_3_Click(object sender, EventArgs e)
        {
            {
                if (!isBack2)
                {
                    card_3.Image = Resources.shawarma;
                    isBack2 = true;
                }
                else
                {
                    card_3.Image = Resources.green_banana;
                    isBack2 = false;
                }
            }
        }

        private void card_4_Click(object sender, EventArgs e)
        {
            {
                if (!isBack3)
                {
                    card_4.Image = Resources.shawarma;
                    isBack3 = true;
                }
                else
                {
                    card_4.Image = Resources.green_banana;
                    isBack3 = false;
                }
            }
        }

        private void card_5_Click(object sender, EventArgs e)
        {
            {
                if (!isBack4)
                {
                    card_5.Image = Resources.shawarma;
                    isBack4 = true;
                }
                else
                {
                    card_5.Image = Resources.green_banana;
                    isBack4 = false;
                }
            }
        }

        private void card_6_Click(object sender, EventArgs e)
        {
            {
                if (!isBack5)
                {
                    card_6.Image = Resources.shawarma;
                    isBack5 = true;
                }
                else
                {
                    card_6.Image = Resources.green_banana;
                    isBack5 = false;
                }
            }
        }
    }
}
