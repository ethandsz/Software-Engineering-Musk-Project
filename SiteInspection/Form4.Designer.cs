
namespace SiteInspection
{
    partial class Form4
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
            this.uploadPic1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadPic1
            // 
            this.uploadPic1.Location = new System.Drawing.Point(12, 316);
            this.uploadPic1.Name = "uploadPic1";
            this.uploadPic1.Size = new System.Drawing.Size(130, 43);
            this.uploadPic1.TabIndex = 5;
            this.uploadPic1.Text = "upload";
            this.uploadPic1.UseVisualStyleBackColor = true;
            this.uploadPic1.Click += new System.EventHandler(this.uploadPic1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(497, 272);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 7;
            this.image1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "upload";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "upload";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadPic1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadPic1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}