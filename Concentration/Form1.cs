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
        private int countCorrectGuesses = 0; // Count Correct Guesses
        private const int card = 8; // Number. of Cards
        private Image[] images = new Image[card]; // Array of Cards

        private bool isFirst = true; // Is (PictureBox) First Object
        private PictureBox firstPictureBox; // First PictureBox
        private PictureBox secondPictureBox; // Second PictureBox

        public bool IsMatching(Image image1, Image image2) // Tested - Confirmed 
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

        private void Swap(int i, int j) // Tested - Confirmed 
        {
            Image image = images[i];
            images[i] = images[j];
            images[j] = image;
        } 

        private void SetImagesArray() // Tested - Confirmed 
        {
            images[0] = Resources.Green;
            images[1] = Resources.Green;
            images[2] = Resources.Yellow;
            images[3] = Resources.Yellow;
            images[4] = Resources.Red;
            images[5] = Resources.Red;
            images[6] = Resources.Blue;
            images[7] = Resources.Blue;

            Random rnd = new Random();
            for (int i = 0; i < card; i++)
            {
                Swap(i, rnd.Next(card));
            }
        }

        public Form1() // Constructor - NaN 
        {
            InitializeComponent();
            SetImagesArray();
        }

        private void PictureBox_Click(object sender, EventArgs e) // Tested - Confirmed 
        {
            PictureBox pictureBox = sender as PictureBox;

            int k = int.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 1));
            k--;

            if (!IsMatching(pictureBox.Image, Resources.Reverse))
            {
                pictureBox.Image = Resources.Reverse;
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
            if (IsMatching(firstPictureBox.Image, secondPictureBox.Image))
            {
                firstPictureBox.Enabled = false;
                secondPictureBox.Enabled = false;
                countCorrectGuesses += 2;
            }

            else
            {
                firstPictureBox.Image = Resources.Reverse;
                secondPictureBox.Image = Resources.Reverse;
            }

            timer.Stop();

            if (countCorrectGuesses == card)
            {
                Form2 winForm = new Form2();
                winForm.Show();
            }
        }
    }
}