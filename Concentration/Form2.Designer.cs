namespace Concentration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.card_3 = new System.Windows.Forms.PictureBox();
            this.card_2 = new System.Windows.Forms.PictureBox();
            this.card_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1072, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations, you have won!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have succesfully guessed all four pairs of cards!";
            // 
            // card_3
            // 
            this.card_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card_3.Image = global::Concentration.Properties.Resources.Yellow;
            this.card_3.Location = new System.Drawing.Point(548, 189);
            this.card_3.Margin = new System.Windows.Forms.Padding(6);
            this.card_3.Name = "card_3";
            this.card_3.Size = new System.Drawing.Size(314, 346);
            this.card_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_3.TabIndex = 5;
            this.card_3.TabStop = false;
            // 
            // card_2
            // 
            this.card_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card_2.Image = global::Concentration.Properties.Resources.Red;
            this.card_2.Location = new System.Drawing.Point(236, 189);
            this.card_2.Margin = new System.Windows.Forms.Padding(6);
            this.card_2.Name = "card_2";
            this.card_2.Size = new System.Drawing.Size(314, 346);
            this.card_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_2.TabIndex = 4;
            this.card_2.TabStop = false;
            // 
            // card_1
            // 
            this.card_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card_1.Image = global::Concentration.Properties.Resources.Blue;
            this.card_1.Location = new System.Drawing.Point(-45, 189);
            this.card_1.Margin = new System.Windows.Forms.Padding(6);
            this.card_1.Name = "card_1";
            this.card_1.Size = new System.Drawing.Size(314, 346);
            this.card_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_1.TabIndex = 3;
            this.card_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Concentration.Properties.Resources.Green;
            this.pictureBox1.Location = new System.Drawing.Point(857, 189);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Created by Daniel Naaman";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 685);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.card_3);
            this.Controls.Add(this.card_2);
            this.Controls.Add(this.card_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Concentration: You Have Won! (Daniel Naaman)";
            ((System.ComponentModel.ISupportInitialize)(this.card_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox card_3;
        private System.Windows.Forms.PictureBox card_2;
        private System.Windows.Forms.PictureBox card_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}