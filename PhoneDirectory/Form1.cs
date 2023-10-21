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
using System.Data.Sql;

namespace PhoneDirectory
{
    public partial class Form1 : Form
    {

        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\musta\OneDrive\Masaüstü\PhoneDirectory\database\mustafagur.mdf;Integrated Security=True;Connect Timeout=30");

        public static List<Contact> Contacts = new List<Contact>();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            Contacts.Clear();
            SqlCommand commands = new SqlCommand("SELECT * FROM contacts", connection);
            connection.Open();
            SqlDataReader reader = commands.ExecuteReader();
            while(reader.Read()) {
                Contacts.Add(new Contact {
                    id = Convert.ToInt32(reader["id"]),
                    name = reader["first_name"].ToString() + " " + reader["last_name"],
                    mail = reader["email"].ToString(),
                    number = reader["phone"].ToString()
                }) ;
                mainDirectoryList.Rows.Add(reader["first_name"].ToString() + " " + reader["last_name"], 
                    reader["phone"].ToString());
                int rowId = (int)reader["id"]; 
                mainDirectoryList.Rows[mainDirectoryList.Rows.Count - 1].Tag = rowId;
            }
            connection.Close();
            mainDirectoryCountLbl.Text = "Rehberde " + Contacts.Count + " kişi var.";
        }

        private void button1_Click(object sender, EventArgs e) {
            FormAddContact addcontact = new FormAddContact();
            addcontact.Process = "newcontact";
            addcontact.Show();
            this.Hide();
        }

        private void mainSearchBtn_Click(object sender, EventArgs e) {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
            this.Hide();
        }

        public class Contact
        {
            public int id { get; set; }
            public string name { get; set; }
            public string number { get; set; }
            public string mail { get; set; }
        }

        private void mainDirectoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow selectedRow = mainDirectoryList.Rows[e.RowIndex];
                int selectedId = (int)selectedRow.Tag;
                FormAddContact addContact = new FormAddContact();
                addContact.Process = "detail";
                addContact.ProcessId = selectedId;
                addContact.Show();
                this.Hide();
            }
        }
    }


}

