using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnamentAccouting
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            sve.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            bl.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock se = new Stock();
            se.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sve_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.UpdateCurrentGoldVlue(Convert.ToInt16(textBox1.Text));
            MessageBox.Show("Gold value update successfull");
            textBox1.Clear();
            textBox1.Visible = false;
            sve.Visible = false;
        }
    }
}
