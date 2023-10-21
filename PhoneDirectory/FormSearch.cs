using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        List<Form1.Contact> contacts = Form1.Contacts;

        private void FormSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 sa = new Form1();
            sa.Show();
        }

        private void srcSearchTxt_TextChanged(object sender, EventArgs e) {
            string searchText = srcSearchTxt.Text.ToLower(); 
            srcDgwList.Rows.Clear(); 
            foreach (Form1.Contact contact in contacts) {
                string name = contact.name.ToLower();
                string number = contact.number;
                if (name.Contains(searchText) || number.Contains(searchText)) {
                    srcDgwList.Rows.Add(contact.name, contact.number);
                }
            }
        }


        private void FormSearch_Load(object sender, EventArgs e) {
            foreach (Form1.Contact contact in contacts)
            {
                string name = contact.name;
                string number = contact.number;
                srcDgwList.Rows.Add(name, number);
            }
        }
    }
}
