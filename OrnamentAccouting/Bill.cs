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
    public partial class Bill : Form
    {
        public static double NetAmount = 0;
        public Bill()
        {
            InitializeComponent();


        }

        private void Bill_Load(object sender, EventArgs e)
        {
            toallbl.Text = "0";
            DataAccessLayer dal = new DataAccessLayer();
            valauegram.Text = dal.GetCurrentGoldValue();
            SearchProduct();
        }
        //=======================================================//
        public void SearchProduct()
        {
            if (!string.IsNullOrEmpty(prctxt.Text)) {
                string connectionString = @"Data Source=DESKTOP-BAKQNPQ;Initial Catalog=AlankaraDB;Integrated Security=True";
                //SqlConnection con = new SqlConnection(connectionString);
                ////SqlCommand cmd = new SqlCommand("SELECT Product Details,Weight FROM StockDetails WHERE Product code='"+prctxt.Text+"'",con);
                ////cmd.CommandType = CommandType.Text();
                //con.Open();
                //SqlDataAdapter sdr = new SqlDataAdapter("SELECT Product Details,Weight FROM StockDetails WHERE Product code='" + prctxt.Text + "'", con);
                //prdtext.Text= sdr["Product Details"].ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Product Details,Weight FROM StockDetails WHERE Product code='" + prctxt.Text + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        try
                        {
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                sdr.Read();
                                prdtext.Text = sdr["Product Details"].ToString();
                                weighttxt.Text = sdr["Weight"].ToString();

                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        }
        //========================================================//
        private void button1_Click(object sender, EventArgs e)
        {//
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex != 8)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                }
                dt.Rows.Add(dRow);
            }

            dt.Columns.Remove("Column9");

            DataTable de = new DataTable();
            de.Columns.Add("Name");
            de.Columns.Add("Address");
            de.Columns.Add("Contact Number");
            de.Columns.Add("Cash Amount");
            de.Columns.Add("Bank Name");
            de.Columns.Add("Branch");
            de.Columns.Add("Number");
            de.Columns.Add("Amount");
            de.Columns.Add("Rupees in words");
            de.Columns.Add("CGST");
            de.Columns.Add("SGST");


            DataRow dr;
            dr = de.NewRow();
            dr["Name"] = byerstext.Text;
            dr["Address"] = addrtext.Text;
            dr["Contact Number"] = igst.Text;
            dr["Cash Amount"] = cashtxt.Text;
            dr["Bank Name"] = banktxt.Text;
            dr["Branch"] = brantxt.Text;
            dr["Number"] = chqnotxt.Text;
            dr["Amount"] = chamtxt.Text;
            dr["Rupees in words"] = wordstxt.Text;
            dr["CGST"] = textBox1.Text;
            dr["SGST"] = textBox2.Text;
            de.Rows.Add(dr);

            string BillingID = "BL00" + DateTime.Now.ToString("HHmmm");
            string ProductAmount = prvtxt.Text;
            string gst = igst.Text;
            string nm = byerstext.Text;
            string addr = addrtext.Text;
            string contactnum = context.Text;
            string banknm = banktxt.Text;
            string brnch = brantxt.Text;
            string chnum = chqnotxt.Text;
            string chamt = chamtxt.Text;
            string csh = cashtxt.Text;
            string amtinwrd = wordstxt.Text;
            string ntemt = NetAmounttxt.Text;
            string cgs = textBox1.Text;
            string sgs = textBox2.Text;







            DataAccessLayer d = new DataAccessLayer();
            if (d.SaveBill(dt, BillingID, ProductAmount, gst, ntemt, csh, chamt, banknm, brnch, chnum, nm, addr, contactnum, amtinwrd, cgs, sgs))
            {
                BIllreportprint ob = new BIllreportprint(BillingID);
                ob.Show();
            }
            //BIllreportprint bl = new BIllreportprint("BL001");
            //bl.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cashlbl.Visible = true;
                cashtxt.Visible = true;
            }
            else
            {
                cashlbl.Visible = false;
                cashtxt.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mctxt.Text))
            {
                mctxt.Text = 0.ToString();
            }
            if (String.IsNullOrEmpty(octxt.Text))
            {
                octxt.Text = 0.ToString();
            }
            if (qntytxt.Text != null && qntytxt.Text != "")
            {
                toallbl.Text = (Convert.ToInt32(qntytxt.Text) * ((Convert.ToDouble(weighttxt.Text) * Convert.ToDouble(valauegram.Text)) + Convert.ToDouble(mctxt.Text) + Convert.ToDouble(octxt.Text))).ToString();
            }
            else
            {
                toallbl.Text = "0";
            }
        }

        private void Addrtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string prcname = prctxt.Text;
                string prdname = prdtext.Text;
                int quantiy = Convert.ToInt32(qntytxt.Text);
                double weight = Convert.ToDouble(weighttxt.Text);
                double provalue = Convert.ToDouble(prvtxt.Text);
                double mccahrge = Convert.ToDouble(mctxt.Text);
                double occharge = Convert.ToDouble(octxt.Text);
                double rspergram = Convert.ToDouble(valauegram.Text);
                double calrspergram = weight * rspergram;


                double n = Convert.ToDouble(toallbl.Text);
                double totalcharge = quantiy * (calrspergram + mccahrge + occharge);
                totalcharge = n;

                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["ProductID", row].Value = prcname;
                dataGridView1["ProductName", row].Value = prdname;
                dataGridView1["Quantity", row].Value = quantiy;
                dataGridView1["Weight", row].Value = weight;
                dataGridView1["ProductValue", row].Value = provalue;
                dataGridView1["MakingCharges", row].Value = mccahrge;
                dataGridView1["OtherCharges", row].Value = occharge;
                dataGridView1["TotalAmount", row].Value = totalcharge;

                double sum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                }
                NetAmounttxt.Text = sum.ToString();
                NetAmount = sum;
                prctxt.Clear();
                prdtext.Clear();
                weighttxt.Clear();
                prvtxt.Clear();
                mctxt.Clear();
                octxt.Clear();
                qntytxt.Clear();
                toallbl.Text.Remove(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nothing to add");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if (dataGridView1.Rows.Count >= 1)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(row);
                    double sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum =sum- Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                    }
                    sum = sum * -1;
                    NetAmounttxt.Text = sum.ToString();
                    NetAmount = sum;

                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Nothing to delete");
            }
        }
        //------------------------------------//
        //private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    MessageBox.Show("Hello");

          


        //}

        //------------------------------------//

        private void valauegram_TextChanged(object sender, EventArgs e)
        {

        }

        private void prvtxt_TextChanged(object sender, EventArgs e)
        {



        }

        private void weighttxt_TextChanged(object sender, EventArgs e)
        {
            if (weighttxt.Text.Trim() != "")
            {
                prvtxt.Text = (Convert.ToDouble(valauegram.Text) * Convert.ToDouble(weighttxt.Text)).ToString();
            }
        }

        private void igst_TextChanged(object sender, EventArgs e)
        {
          
            try
            {
                if(string.IsNullOrEmpty(NetAmounttxt.Text) || NetAmounttxt.Text == "0")
                {
                    NetAmounttxt.Text = 0.ToString();
                }
                if (string.IsNullOrEmpty(igst.Text) || igst.Text=="0")
                {
                    igst.Text = 0.ToString();
                    NetAmounttxt.Text = NetAmount.ToString();
                }
                NetAmounttxt.Text = NetAmount.ToString();
                double gst = (Convert.ToDouble(igst.Text) / 100);
                double gstcal = (Convert.ToDouble(NetAmounttxt.Text) * gst);
                NetAmounttxt.Text = Math.Round((Convert.ToDouble(NetAmounttxt.Text) + gstcal), 2).ToString();
                textBox1.Text = Math.Round((gst / 2), 2).ToString();
                textBox2.Text = Math.Round((gst / 2), 2).ToString();

            }
            //--------------------------------------------------//
            catch (Exception ex) {

                MessageBox.Show("Hello");
                 //string ob = ex.ToString();
                
                //if (string.IsNullOrEmpty(igst.Text) && !string.IsNullOrEmpty(NetAmounttxt.Text) )
                //{
                    
                //    double gstam = (Convert.ToDouble(igst.Text) / 100);
                //    double gstcalam = (Convert.ToDouble(NetAmounttxt.Text) * gstam);
                //    NetAmounttxt.Text = Math.Round((Convert.ToDouble(NetAmounttxt.Text) - gstcalam), 2).ToString();
                //}

            }
            //--------------------------------------------------//

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
           if (NetAmounttxt.Text != "" )
           {
                double gst = (Convert.ToDouble(igst.Text)) / 2;
              textBox1.Text = gst.ToString();
          }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            if (NetAmounttxt.Text != "") {
               double gst = (Convert.ToDouble(igst.Text)) / 2;
                textBox2.Text = gst.ToString();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void NetAmounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prctxt_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}


