using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class UserControl1 : UserControl
    {
        FinnishContext context = new();
        public UserControl1()
        {
            InitializeComponent();
            GetData();

        }

        private void GetData()
        {
            var get_data = from x in context.TelephoneBooks
                           select new db1
                           {
                               Name = x.LastName + " " + x.FirstName,
                               Region = x.Region,
                               Sex = x.Sex,
                               PostalCode = x.PostalCodeId
                           };
            dataGridView1.DataSource = get_data.ToList();

        }

    }
    public  class db1
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Sex { get; set; }
        public int? PostalCode { get; set; }

    }


}
