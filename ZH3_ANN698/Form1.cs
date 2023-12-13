using ZH3_ANN698.Models;

namespace ZH3_ANN698
{
    public partial class Form1 : Form
    {
        FinnishContext context = new();

        public Form1()
        {
            InitializeComponent();
            telephoneBookBindingSource.DataSource = context.PostalCodes.ToList();
            PostalCodeSum();
        }

        private void PostalCodeSum()
        {
            var get_sum = (from x in context.TelephoneBooks
                           where x.PostalCodeId == comboBox1.SelectedIndex
                           select x).Count();
            label1.Text = "Quanity of Peoples On this Postal Code: " + get_sum.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you really want to Close?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 us1 = new();
            panel1.Controls.Add(us1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 us2 = new();
            panel1.Controls.Add(us2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new();
            f3.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostalCodeSum();
        }
    }
}