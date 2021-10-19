namespace SiteInspection
{
    partial class InspectionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtSupr = new System.Windows.Forms.TextBox();
            this.txtCmpltd = new System.Windows.Forms.TextBox();
            this.txtInspc = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtWrk_Area = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(5, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Completed By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(9, 534);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Work Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(5, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(5, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supervisor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(9, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inspector:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(9, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(170, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(517, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Health, Safety, Quality and Environmental Site Inspection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.label9.Location = new System.Drawing.Point(4, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 150);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 39);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSite
            // 
            this.txtSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtSite.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(61, 89);
            this.txtSite.Margin = new System.Windows.Forms.Padding(2);
            this.txtSite.Multiline = true;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(726, 34);
            this.txtSite.TabIndex = 10;
            // 
            // txtSupr
            // 
            this.txtSupr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtSupr.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtSupr.Location = new System.Drawing.Point(118, 285);
            this.txtSupr.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupr.Multiline = true;
            this.txtSupr.Name = "txtSupr";
            this.txtSupr.Size = new System.Drawing.Size(668, 34);
            this.txtSupr.TabIndex = 11;
            // 
            // txtCmpltd
            // 
            this.txtCmpltd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCmpltd.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtCmpltd.Location = new System.Drawing.Point(141, 217);
            this.txtCmpltd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCmpltd.Multiline = true;
            this.txtCmpltd.Name = "txtCmpltd";
            this.txtCmpltd.Size = new System.Drawing.Size(646, 34);
            this.txtCmpltd.TabIndex = 12;
            // 
            // txtInspc
            // 
            this.txtInspc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtInspc.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtInspc.Location = new System.Drawing.Point(109, 349);
            this.txtInspc.Margin = new System.Windows.Forms.Padding(2);
            this.txtInspc.Multiline = true;
            this.txtInspc.Name = "txtInspc";
            this.txtInspc.Size = new System.Drawing.Size(678, 34);
            this.txtInspc.TabIndex = 13;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtType.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtType.Location = new System.Drawing.Point(69, 475);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(718, 34);
            this.txtType.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtDesc.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtDesc.Location = new System.Drawing.Point(158, 412);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(625, 34);
            this.txtDesc.TabIndex = 15;
            // 
            // txtWrk_Area
            // 
            this.txtWrk_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtWrk_Area.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.txtWrk_Area.Location = new System.Drawing.Point(118, 534);
            this.txtWrk_Area.Margin = new System.Windows.Forms.Padding(2);
            this.txtWrk_Area.Multiline = true;
            this.txtWrk_Area.Name = "txtWrk_Area";
            this.txtWrk_Area.Size = new System.Drawing.Size(668, 34);
            this.txtWrk_Area.TabIndex = 16;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btn_Save.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.btn_Save.Location = new System.Drawing.Point(14, 601);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(232, 42);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.button1.Location = new System.Drawing.Point(264, 600);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(890, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 248);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1402, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtWrk_Area);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtInspc);
            this.Controls.Add(this.txtCmpltd);
            this.Controls.Add(this.txtSupr);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InspectionForm";
            this.Load += new System.EventHandler(this.InspectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtSupr;
        private System.Windows.Forms.TextBox txtCmpltd;
        private System.Windows.Forms.TextBox txtInspc;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtWrk_Area;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}