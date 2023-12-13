using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_ANN698.Models;

namespace ZH3_ANN698
{
    public partial class Form2 : Form
    {
        FinnishContext context = new();
        public Form2()
        {
            InitializeComponent();
            postalCodeBindingSource.DataSource = context.PostalCodes.ToList();
            telephoneBookBindingSource.DataSource = context.TelephoneBooks.ToList();
        }
        private bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
        private bool CheckPhone(string phone)
        {
            Regex r = new(@"^\+?[0-9]{12}");
            return r.IsMatch(phone);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Confirm == DialogResult.Yes)
            {
                TelephoneBook save = new();
                save.FirstName = textBox1.Text;
                save.LastName = textBox2.Text;
                save.Region = textBox3.Text;
                save.Sex = comboBox1.SelectedText;
                save.PhoneNumber = textBox4.Text;
                save.PostalCodeId = comboBox2.SelectedIndex;
                context.TelephoneBooks.Add(save);
                try
                {
                    context.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.Message);
                }

            }
            else
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Name cannot be empty!");
                e.Cancel = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "");
                e.Cancel = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPhone(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Wrong Phone format!");
                e.Cancel = true;
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox4, "");
        }
    }
}
