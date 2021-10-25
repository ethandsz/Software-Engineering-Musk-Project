
namespace SiteInspection
{
    partial class AdminForm
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
            this.cmbBox_SortBy = new System.Windows.Forms.ComboBox();
            this.dgvViewData = new System.Windows.Forms.DataGridView();
            this.btn_updateGrd = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBox_SortBy
            // 
            this.cmbBox_SortBy.FormattingEnabled = true;
            this.cmbBox_SortBy.Items.AddRange(new object[] {
            "Date [Oldest-Newest]",
            "Date [Newest-Oldest]",
            "Site",
            "Type"});
            this.cmbBox_SortBy.Location = new System.Drawing.Point(12, 12);
            this.cmbBox_SortBy.Name = "cmbBox_SortBy";
            this.cmbBox_SortBy.Size = new System.Drawing.Size(249, 33);
            this.cmbBox_SortBy.TabIndex = 0;
            this.cmbBox_SortBy.Text = "Sort By";
            // 
            // dgvViewData
            // 
            this.dgvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewData.Location = new System.Drawing.Point(13, 99);
            this.dgvViewData.Name = "dgvViewData";
            this.dgvViewData.RowHeadersWidth = 82;
            this.dgvViewData.RowTemplate.Height = 33;
            this.dgvViewData.Size = new System.Drawing.Size(1395, 589);
            this.dgvViewData.TabIndex = 1;
            // 
            // btn_updateGrd
            // 
            this.btn_updateGrd.Location = new System.Drawing.Point(268, 12);
            this.btn_updateGrd.Name = "btn_updateGrd";
            this.btn_updateGrd.Size = new System.Drawing.Size(126, 43);
            this.btn_updateGrd.TabIndex = 2;
            this.btn_updateGrd.Text = "Go";
            this.btn_updateGrd.UseVisualStyleBackColor = true;
            this.btn_updateGrd.Click += new System.EventHandler(this.btn_updateGrd_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(400, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(164, 43);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Home";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_updateGrd);
            this.Controls.Add(this.dgvViewData);
            this.Controls.Add(this.cmbBox_SortBy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_SortBy;
        private System.Windows.Forms.DataGridView dgvViewData;
        private System.Windows.Forms.Button btn_updateGrd;
        private System.Windows.Forms.Button btn_back;
    }
}