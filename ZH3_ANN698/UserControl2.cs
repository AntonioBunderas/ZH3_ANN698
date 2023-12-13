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
    public partial class UserControl2 : UserControl
    {
        FinnishContext context = new();
        public UserControl2()
        {
            InitializeComponent();
            GetName();
            GetRegion();
        }

        private void GetRegion()
        {
            var get_loc = from x in context.TelephoneBooks
                          where x.FirstName + " " + x.LastName == listBox1.Text
                          select x.Region;
            listBox2.DataSource = get_loc.ToList();
            listBox2.DisplayMember = "Region";
        }

        private void GetName()
        {
            var get_names = from x in context.TelephoneBooks
                            where x.FirstName.Contains(textBox1.Text) || x.LastName.Contains(textBox1.Text)
                            select new
                            {
                                Name = x.FirstName + " " + x.LastName,
                            };
            listBox1.DataSource = get_names.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetName();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRegion();
        }
    }
}
