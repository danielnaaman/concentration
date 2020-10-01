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
        private const int card = 8;
        private Image[] images = new Image[card];

        private bool isFirst = true;
        private PictureBox firstPictureBox;
        private PictureBox secondPictureBox;

        public bool IsMatching(Image image1, Image image2)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];

                imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

                System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
                byte[] imgHash1 = sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);

                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
                {
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void SetImagesArray()
        {
            images[0] = Resources.green_banana;
            images[1] = Resources.green_banana;
            images[2] = Resources.yellow_banana;
            images[3] = Resources.yellow_banana;
            images[4] = Resources.red_banana;
            images[5] = Resources.red_banana;
            images[6] = Resources.blue_banana;
            images[7] = Resources.blue_banana;
        }

        public Form1()
        {
            InitializeComponent();
            SetImagesArray();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            int k = int.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 1));
            k--;

            if (!IsMatching(pictureBox.Image, Resources.shawarma))
            {
                pictureBox.Image = Resources.shawarma;
            }

            else
            {
                pictureBox.Image = images[k];
            }

            if (!isFirst)
            {
                secondPictureBox = pictureBox;
                timer.Start();
            }

            else
            {
                firstPictureBox = pictureBox;
            }
            isFirst = !isFirst;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            firstPictureBox.Image = Resources.shawarma;
            secondPictureBox.Image = Resources.shawarma;

            timer.Stop();
        }
    }
}