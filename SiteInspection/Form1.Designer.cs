namespace SiteInspection
{
    partial class Form1
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
            this.cmbBox_Form = new System.Windows.Forms.ComboBox();
            this.btn_CreateForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBox_Form
            // 
            this.cmbBox_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cmbBox_Form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Form.FormattingEnabled = true;
            this.cmbBox_Form.Items.AddRange(new object[] {
            "Site Inspection",
            "----",
            "----",
            "----",
            "----"});
            this.cmbBox_Form.Location = new System.Drawing.Point(9, 357);
            this.cmbBox_Form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBox_Form.Name = "cmbBox_Form";
            this.cmbBox_Form.Size = new System.Drawing.Size(267, 21);
            this.cmbBox_Form.TabIndex = 0;
            this.cmbBox_Form.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Form_SelectedIndexChanged);
            // 
            // btn_CreateForm
            // 
            this.btn_CreateForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btn_CreateForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateForm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btn_CreateForm.Location = new System.Drawing.Point(9, 271);
            this.btn_CreateForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateForm.Name = "btn_CreateForm";
            this.btn_CreateForm.Size = new System.Drawing.Size(266, 81);
            this.btn_CreateForm.TabIndex = 1;
            this.btn_CreateForm.Text = "New Form";
            this.btn_CreateForm.UseVisualStyleBackColor = false;
            this.btn_CreateForm.Click += new System.EventHandler(this.btn_CreateForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_CreateForm);
            this.panel1.Controls.Add(this.cmbBox_Form);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 693);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.button3.Location = new System.Drawing.Point(9, 602);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiteInspection.Properties.Resources.home_1822_1096104;
            this.pictureBox1.Location = new System.Drawing.Point(22, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 263);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(9, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_Form;
        private System.Windows.Forms.Button btn_CreateForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}

