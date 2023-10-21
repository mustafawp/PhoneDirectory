
namespace PhoneDirectory
{
    partial class FormAddContact
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
            this.addBackBtn = new System.Windows.Forms.Button();
            this.addSaveBtn = new System.Windows.Forms.Button();
            this.addNameTxt = new System.Windows.Forms.TextBox();
            this.addPhoneTxt = new System.Windows.Forms.TextBox();
            this.addMailTxt = new System.Windows.Forms.TextBox();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addSurnameTxt = new System.Windows.Forms.TextBox();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBackBtn
            // 
            this.addBackBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBackBtn.ForeColor = System.Drawing.Color.Red;
            this.addBackBtn.Location = new System.Drawing.Point(31, 238);
            this.addBackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBackBtn.Name = "addBackBtn";
            this.addBackBtn.Size = new System.Drawing.Size(196, 44);
            this.addBackBtn.TabIndex = 6;
            this.addBackBtn.Text = "Geri";
            this.addBackBtn.UseVisualStyleBackColor = true;
            this.addBackBtn.Click += new System.EventHandler(this.addBackBtn_Click);
            // 
            // addSaveBtn
            // 
            this.addSaveBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaveBtn.ForeColor = System.Drawing.Color.Blue;
            this.addSaveBtn.Location = new System.Drawing.Point(239, 238);
            this.addSaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSaveBtn.Name = "addSaveBtn";
            this.addSaveBtn.Size = new System.Drawing.Size(196, 44);
            this.addSaveBtn.TabIndex = 7;
            this.addSaveBtn.Text = "Kaydet";
            this.addSaveBtn.UseVisualStyleBackColor = true;
            this.addSaveBtn.Click += new System.EventHandler(this.addSaveBtn_Click);
            // 
            // addNameTxt
            // 
            this.addNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addNameTxt.Location = new System.Drawing.Point(15, 25);
            this.addNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNameTxt.Name = "addNameTxt";
            this.addNameTxt.Size = new System.Drawing.Size(403, 37);
            this.addNameTxt.TabIndex = 1;
            this.addNameTxt.Text = "İsim";
            this.addNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addNameTxt.Click += new System.EventHandler(this.textboxClear);
            // 
            // addPhoneTxt
            // 
            this.addPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPhoneTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addPhoneTxt.Location = new System.Drawing.Point(15, 116);
            this.addPhoneTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPhoneTxt.Name = "addPhoneTxt";
            this.addPhoneTxt.Size = new System.Drawing.Size(403, 37);
            this.addPhoneTxt.TabIndex = 3;
            this.addPhoneTxt.Text = " Telefon";
            this.addPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPhoneTxt.Click += new System.EventHandler(this.textboxClear);
            this.addPhoneTxt.TextChanged += new System.EventHandler(this.addPhoneTxt_TextChanged);
            // 
            // addMailTxt
            // 
            this.addMailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addMailTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addMailTxt.Location = new System.Drawing.Point(15, 161);
            this.addMailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMailTxt.Name = "addMailTxt";
            this.addMailTxt.Size = new System.Drawing.Size(403, 37);
            this.addMailTxt.TabIndex = 4;
            this.addMailTxt.Text = " Eposta";
            this.addMailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addMailTxt.Click += new System.EventHandler(this.textboxClear);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addSurnameTxt);
            this.addGroupBox.Controls.Add(this.addMailTxt);
            this.addGroupBox.Controls.Add(this.addPhoneTxt);
            this.addGroupBox.Controls.Add(this.addNameTxt);
            this.addGroupBox.ForeColor = System.Drawing.Color.White;
            this.addGroupBox.Location = new System.Drawing.Point(16, 15);
            this.addGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addGroupBox.Size = new System.Drawing.Size(435, 215);
            this.addGroupBox.TabIndex = 6;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Kişi Ekle";
            // 
            // addSurnameTxt
            // 
            this.addSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addSurnameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addSurnameTxt.Location = new System.Drawing.Point(15, 70);
            this.addSurnameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSurnameTxt.Name = "addSurnameTxt";
            this.addSurnameTxt.Size = new System.Drawing.Size(403, 37);
            this.addSurnameTxt.TabIndex = 2;
            this.addSurnameTxt.Text = "Soyisim";
            this.addSurnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addSurnameTxt.Click += new System.EventHandler(this.textboxClear);
            // 
            // FormAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(463, 297);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.addSaveBtn);
            this.Controls.Add(this.addBackBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddContact_FormClosing);
            this.Load += new System.EventHandler(this.FormAddContact_Load);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBackBtn;
        private System.Windows.Forms.Button addSaveBtn;
        private System.Windows.Forms.TextBox addNameTxt;
        private System.Windows.Forms.TextBox addPhoneTxt;
        private System.Windows.Forms.TextBox addMailTxt;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addSurnameTxt;
    }
}