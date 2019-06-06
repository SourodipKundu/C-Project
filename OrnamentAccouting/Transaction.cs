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
    public partial class Transaction : Form
    {
        string connectionString = @"Data Source=DESKTOP-HKCVFM7;Initial Catalog=AlankaraDB;Integrated Security=True";
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void Transaction_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Show_Data"))
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

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
