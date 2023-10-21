
namespace PhoneDirectory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainHeader = new System.Windows.Forms.Label();
            this.mainDirectoryList = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDirectoryCountLbl = new System.Windows.Forms.Label();
            this.mainAddContactBtn = new System.Windows.Forms.Button();
            this.mainSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDirectoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.AutoSize = true;
            this.mainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainHeader.ForeColor = System.Drawing.Color.White;
            this.mainHeader.Location = new System.Drawing.Point(58, 27);
            this.mainHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(303, 46);
            this.mainHeader.TabIndex = 0;
            this.mainHeader.Text = "Telefon Rehberi";
            // 
            // mainDirectoryList
            // 
            this.mainDirectoryList.AllowUserToAddRows = false;
            this.mainDirectoryList.AllowUserToDeleteRows = false;
            this.mainDirectoryList.AllowUserToResizeColumns = false;
            this.mainDirectoryList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDirectoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDirectoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDirectoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPhone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDirectoryList.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainDirectoryList.EnableHeadersVisualStyles = false;
            this.mainDirectoryList.Location = new System.Drawing.Point(16, 140);
            this.mainDirectoryList.Margin = new System.Windows.Forms.Padding(4);
            this.mainDirectoryList.MultiSelect = false;
            this.mainDirectoryList.Name = "mainDirectoryList";
            this.mainDirectoryList.ReadOnly = true;
            this.mainDirectoryList.RowHeadersVisible = false;
            this.mainDirectoryList.RowHeadersWidth = 51;
            this.mainDirectoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDirectoryList.Size = new System.Drawing.Size(408, 437);
            this.mainDirectoryList.TabIndex = 1;
            this.mainDirectoryList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDirectoryList_CellDoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnName.HeaderText = "İsim Soyisim";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 113;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPhone.HeaderText = "Telefon Numarası";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // mainDirectoryCountLbl
            // 
            this.mainDirectoryCountLbl.AutoSize = true;
            this.mainDirectoryCountLbl.ForeColor = System.Drawing.Color.White;
            this.mainDirectoryCountLbl.Location = new System.Drawing.Point(16, 117);
            this.mainDirectoryCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainDirectoryCountLbl.Name = "mainDirectoryCountLbl";
            this.mainDirectoryCountLbl.Size = new System.Drawing.Size(143, 17);
            this.mainDirectoryCountLbl.TabIndex = 2;
            this.mainDirectoryCountLbl.Text = "Rehberde 25 kişi var.";
            // 
            // mainAddContactBtn
            // 
            this.mainAddContactBtn.Location = new System.Drawing.Point(391, 103);
            this.mainAddContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mainAddContactBtn.Name = "mainAddContactBtn";
            this.mainAddContactBtn.Size = new System.Drawing.Size(33, 30);
            this.mainAddContactBtn.TabIndex = 3;
            this.mainAddContactBtn.Text = "+";
            this.mainAddContactBtn.UseVisualStyleBackColor = true;
            this.mainAddContactBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainSearchBtn
            // 
            this.mainSearchBtn.Location = new System.Drawing.Point(349, 103);
            this.mainSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mainSearchBtn.Name = "mainSearchBtn";
            this.mainSearchBtn.Size = new System.Drawing.Size(33, 30);
            this.mainSearchBtn.TabIndex = 4;
            this.mainSearchBtn.Text = "🔍";
            this.mainSearchBtn.UseVisualStyleBackColor = true;
            this.mainSearchBtn.Click += new System.EventHandler(this.mainSearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(440, 582);
            this.Controls.Add(this.mainSearchBtn);
            this.Controls.Add(this.mainAddContactBtn);
            this.Controls.Add(this.mainDirectoryCountLbl);
            this.Controls.Add(this.mainDirectoryList);
            this.Controls.Add(this.mainHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDirectoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeader;
        private System.Windows.Forms.DataGridView mainDirectoryList;
        private System.Windows.Forms.Label mainDirectoryCountLbl;
        private System.Windows.Forms.Button mainAddContactBtn;
        private System.Windows.Forms.Button mainSearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
    }
}

