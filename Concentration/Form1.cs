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

        private const int card = 8;
        private Image[] m_Images = new Image[card];

        private void SetImagesArray()
        {
            m_Images[0] = Resources.green_banana;
            m_Images[1] = Resources.green_banana;
            m_Images[2] = Resources.yellow_banana;
            m_Images[3] = Resources.yellow_banana;
            m_Images[4] = Resources.red_banana;
            m_Images[5] = Resources.red_banana;
            m_Images[6] = Resources.blue_banana;
            m_Images[7] = Resources.blue_banana;
        }

        public Form1()
        {
            InitializeComponent();
            SetImagesArray();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            string picName = pictureBox.Name;
            int k = int.Parse(picName.Substring(picName.Length - 1));

            k--;
            if (!IsMatching(pictureBox.Image, Resources.shawarma))
                pictureBox.Image = Resources.shawarma;
            else
                pictureBox.Image = m_Images[k];
        }
    }
}