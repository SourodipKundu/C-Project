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

namespace OrnamentAccouting
{

    public partial class Stock : Form
    {
        string connectionString = @"Data Source=DESKTOP-BAKQNPQ;Initial Catalog=AlankaraDB;Integrated Security=True";
        public Stock()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Svestbutton_Click(object sender, EventArgs e)
        {
            string prc = prctxt.Text;
            string prd = prdtxt.Text;
            string weight = (Convert.ToDouble(weighttxt.Text)).ToString();

            DataAccessLayer d = new DataAccessLayer();
            if (d.SaveStock(prc, prd, weight))

            {
                MessageBox.Show("STOCK SAVED");
                prctxt.Clear();
                prdtxt.Clear();
                weighttxt.Clear();
                ShowStock();

            }




        }

        private void Stock_Load(object sender, EventArgs e)
        {
            ShowStock();
        }

        public void ShowStock()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ShowStock"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adp = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        adp.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            adp.Fill(dt);
                            dgv1.DataSource = dt;
                        }
                    }
                }
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
