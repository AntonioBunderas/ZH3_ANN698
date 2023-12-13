using ZH3_ANN698.Models;

namespace ZH3_ANN698
{
    public partial class Form1 : Form
    {
        FinnishContext context = new();

        public Form1()
        {
            InitializeComponent();
            Combobox2();
            PostalCodeSum();
            Summerise();
        }

        private void Summerise()
        {
            var get_sum2 = (from x in context.TelephoneBooks
                            where x.Region == comboBox2.SelectedItem
                            select x).Count();
            label2.Text ="No/Ppl: " + get_sum2.ToString();
        }

        private void Combobox2()
        {
            telephoneBookBindingSource.DataSource = context.PostalCodes.ToList();
            telephoneBookBindingSource1.DataSource = context.TelephoneBooks.ToList();
            var regions = (from x in context.TelephoneBooks
                           select x.Region).Distinct();
            comboBox2.DataSource = regions.ToList();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Summerise();
        }
    }
}