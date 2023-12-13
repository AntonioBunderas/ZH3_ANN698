using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_ANN698.Models;

namespace ZH3_ANN698
{
    public partial class Form3 : Form
    {
        FinnishContext context = new();

        public Form3()
        {
            InitializeComponent();
            postalCodeBindingSource.DataSource = context.PostalCodes.ToList();
            GetData();
        }

        private void GetData()
        {
            var get_data = from x in context.TelephoneBooks
                           where x.FirstName.Contains(textBox1.Text) || x.LastName.Contains(textBox1.Text)
                           select x;
            telephoneBookBindingSource.DataSource = get_data.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                dynamic del = dataGridView1.CurrentRow.DataBoundItem;
                int _delete = del.PersonId;
                var delete_row = (from x in context.TelephoneBooks
                                  where x.PersonId == _delete
                                  select x).FirstOrDefault();
                try
                {
                    context.TelephoneBooks.Remove(delete_row);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
