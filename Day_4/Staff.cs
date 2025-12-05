using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_4
{
    public partial class Staff : Form
    {
        public string MSNV { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Staff()
        {
            InitializeComponent();
        }

        public void SetData(string msnv, string name, string price)
        {
            txtMSNV.Text = msnv;
            txtName.Text = name;
            txtPrice.Text = price;
            txtMSNV.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSNV.Text)) return;
            MSNV = txtMSNV.Text;
            Name = txtName.Text;
            Price = double.Parse(txtPrice.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
