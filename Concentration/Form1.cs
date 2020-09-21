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

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (!IsMatching(pictureBox.Image, Resources.shawarma))
            {
                pictureBox.Image = Resources.shawarma;
            }
            else
            {
                switch (pictureBox.Name)
                {
                    case "card_1":
                        pictureBox.Image = Resources.green_banana;
                        break;
                    case "card_2":
                        pictureBox.Image = Resources.green_banana;
                        break;
                    case "card_3":
                        pictureBox.Image = Resources.green_banana;
                        break;
                    case "card_4":
                        pictureBox.Image = Resources.green_banana;
                        break;
                    case "card_5":
                        pictureBox.Image = Resources.green_banana;
                        break;
                    case "card_6":
                        pictureBox.Image = Resources.green_banana;
                        break;
                }
            }
        }
    }
}