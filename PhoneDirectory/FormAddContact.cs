using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneDirectory
{
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();

        }

        public int ProcessId { get; set; }
        public String Process { get; set; }


        SqlConnection connection = Form1.connection;
        List<Form1.Contact> contacts = Form1.Contacts;

        private void addBackBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM contacts WHERE id = " + ProcessId, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void addPhoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSaveBtn_Click(object sender, EventArgs e)
        {
            if (Process == "detail") updateContact();
            else newContact();
        }

        private void updateContact() {  
            String name = addNameTxt.Text,
                surname = addSurnameTxt.Text,
                phone = addPhoneTxt.Text,
                mail = addMailTxt.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname)
                || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Boş yer bırakma", "Telefon Rehberi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();
            String sorgu = "UPDATE contacts SET first_name = @firstname, last_name = @lastname, email = @email, phone = @phone WHERE id = @id";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@firstname", name);
            command.Parameters.AddWithValue("@lastname", surname);
            command.Parameters.AddWithValue("@email", mail);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@id", ProcessId);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void newContact() {
            String name = addNameTxt.Text,
                surname = addSurnameTxt.Text,
                phone = addPhoneTxt.Text,
                mail = addMailTxt.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname)
                || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Boş yer bırakma", "Telefon Rehberi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO contacts (first_name, last_name, email, phone) VALUES (@firstname, @lastname, @email, @phone)", connection);
            command.Parameters.AddWithValue("@firstname", name);
            command.Parameters.AddWithValue("@lastname", surname);
            command.Parameters.AddWithValue("@email", mail);
            command.Parameters.AddWithValue("@phone", phone);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void FormAddContact_Load(object sender, EventArgs e)
        {
            if (Process == "detail")
            {
                addBackBtn.Text = "Sil";
                this.Text = "Kişi Detayları";
                addGroupBox.Text = "Kişi Detayları";
                Form1.Contact targetContact = contacts.FirstOrDefault(c => c.id == ProcessId);
                if (targetContact != null)
                {
                    string[] parts = targetContact.name.Split(' ');
                    addNameTxt.Text = parts[0];
                    addSurnameTxt.Text = parts[1];
                    addPhoneTxt.Text = targetContact.number;
                    addMailTxt.Text = targetContact.mail;
                }
            }
            else addBackBtn.Visible = false;
        }

        private void textboxClear(object sender, EventArgs e)
        {
            if (Process != "detail") {  
                TextBox text = (TextBox) sender;
                text.Clear();
            }
        }

        private void FormAddContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 merhabalar = new Form1();
            merhabalar.Show();
        }
    }
}
