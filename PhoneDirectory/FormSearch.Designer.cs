
namespace PhoneDirectory
{
    partial class FormSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.srcGroupBox = new System.Windows.Forms.GroupBox();
            this.srcSearchTxt = new System.Windows.Forms.TextBox();
            this.srcDgwList = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcDgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // srcGroupBox
            // 
            this.srcGroupBox.Controls.Add(this.srcDgwList);
            this.srcGroupBox.Controls.Add(this.srcSearchTxt);
            this.srcGroupBox.ForeColor = System.Drawing.Color.White;
            this.srcGroupBox.Location = new System.Drawing.Point(13, 13);
            this.srcGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srcGroupBox.Name = "srcGroupBox";
            this.srcGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srcGroupBox.Size = new System.Drawing.Size(388, 416);
            this.srcGroupBox.TabIndex = 2;
            this.srcGroupBox.TabStop = false;
            this.srcGroupBox.Text = "Arama";
            // 
            // srcSearchTxt
            // 
            this.srcSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.srcSearchTxt.ForeColor = System.Drawing.Color.Gray;
            this.srcSearchTxt.Location = new System.Drawing.Point(28, 23);
            this.srcSearchTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srcSearchTxt.Name = "srcSearchTxt";
            this.srcSearchTxt.Size = new System.Drawing.Size(337, 34);
            this.srcSearchTxt.TabIndex = 0;
            this.srcSearchTxt.Text = "Ara..";
            this.srcSearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.srcSearchTxt.TextChanged += new System.EventHandler(this.srcSearchTxt_TextChanged);
            // 
            // srcDgwList
            // 
            this.srcDgwList.AllowUserToAddRows = false;
            this.srcDgwList.AllowUserToDeleteRows = false;
            this.srcDgwList.AllowUserToResizeColumns = false;
            this.srcDgwList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.srcDgwList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.srcDgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srcDgwList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPhone});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.srcDgwList.DefaultCellStyle = dataGridViewCellStyle6;
            this.srcDgwList.EnableHeadersVisualStyles = false;
            this.srcDgwList.Location = new System.Drawing.Point(28, 65);
            this.srcDgwList.Margin = new System.Windows.Forms.Padding(4);
            this.srcDgwList.MultiSelect = false;
            this.srcDgwList.Name = "srcDgwList";
            this.srcDgwList.ReadOnly = true;
            this.srcDgwList.RowHeadersVisible = false;
            this.srcDgwList.RowHeadersWidth = 51;
            this.srcDgwList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.srcDgwList.Size = new System.Drawing.Size(337, 334);
            this.srcDgwList.TabIndex = 2;
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
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(413, 440);
            this.Controls.Add(this.srcGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehberinde Ara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearch_FormClosed);
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.srcGroupBox.ResumeLayout(false);
            this.srcGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcDgwList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox srcGroupBox;
        private System.Windows.Forms.TextBox srcSearchTxt;
        private System.Windows.Forms.DataGridView srcDgwList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
    }
}