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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBox_Form = new System.Windows.Forms.ComboBox();
            this.btn_CreateForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvForm_type = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbBox_pdf_form = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm_type)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBox_Form
            // 
            this.cmbBox_Form.BackColor = System.Drawing.Color.White;
            this.cmbBox_Form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Form.FormattingEnabled = true;
            this.cmbBox_Form.Items.AddRange(new object[] {
            "Site Inspection",
            "----",
            "----",
            "----",
            "----"});
            this.cmbBox_Form.Location = new System.Drawing.Point(12, 129);
            this.cmbBox_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBox_Form.Name = "cmbBox_Form";
            this.cmbBox_Form.Size = new System.Drawing.Size(530, 33);
            this.cmbBox_Form.TabIndex = 0;
            this.cmbBox_Form.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Form_SelectedIndexChanged);
            // 
            // btn_CreateForm
            // 
            this.btn_CreateForm.BackColor = System.Drawing.Color.DarkGray;
            this.btn_CreateForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_CreateForm.ForeColor = System.Drawing.Color.Black;
            this.btn_CreateForm.Location = new System.Drawing.Point(12, 188);
            this.btn_CreateForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateForm.Name = "btn_CreateForm";
            this.btn_CreateForm.Size = new System.Drawing.Size(530, 56);
            this.btn_CreateForm.TabIndex = 1;
            this.btn_CreateForm.Text = "Create Form";
            this.btn_CreateForm.UseVisualStyleBackColor = false;
            this.btn_CreateForm.Click += new System.EventHandler(this.btn_CreateForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 637);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.exit_btn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 567);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.admin_login_btn);
            // 
            // dgvForm_type
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvForm_type.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForm_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm_type.Location = new System.Drawing.Point(670, 342);
            this.dgvForm_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvForm_type.Name = "dgvForm_type";
            this.dgvForm_type.ReadOnly = true;
            this.dgvForm_type.RowHeadersWidth = 51;
            this.dgvForm_type.RowTemplate.Height = 24;
            this.dgvForm_type.Size = new System.Drawing.Size(516, 235);
            this.dgvForm_type.TabIndex = 4;
            this.dgvForm_type.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForm_type_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SiteInspection.Properties.Resources.WhatsApp_Image_2021_10_25_at_7_37_26_AM;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(828, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 187);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(828, 629);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Generate pdf";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // cmbBox_pdf_form
            // 
            this.cmbBox_pdf_form.FormattingEnabled = true;
            this.cmbBox_pdf_form.Location = new System.Drawing.Point(1104, 614);
            this.cmbBox_pdf_form.Name = "cmbBox_pdf_form";
            this.cmbBox_pdf_form.Size = new System.Drawing.Size(121, 33);
            this.cmbBox_pdf_form.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.cmbBox_pdf_form);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbBox_Form);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvForm_type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_CreateForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm_type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_Form;
        private System.Windows.Forms.Button btn_CreateForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvForm_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbBox_pdf_form;
    }
}

