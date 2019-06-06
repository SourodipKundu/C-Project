using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnamentAccouting
{
    class DataAccessLayer
    {
        string connectionString = @"Data Source=DESKTOP-BAKQNPQ;Initial Catalog=AlankaraDB;Integrated Security=True";

        public bool SaveBill(DataTable dt, string BillingID,string ProductsAmount,string IGST, string NetAmount, string Cash, string ChequeAmount,string BankName,
            string BranchName, string ChequeNo,string BuyerName,string Address,string PhoneNo, string AmountInWord,string cgst,string sgst)
        {
            bool Result = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertProductTransaction";
            cmd.Parameters.Add("@Procuts", SqlDbType.Structured).Value = dt;
            cmd.Parameters.Add("@BillingID", SqlDbType.VarChar).Value = BillingID;
            cmd.Parameters.Add("@ProductsAmount", SqlDbType.VarChar).Value = ProductsAmount;
            cmd.Parameters.Add("@IGST", SqlDbType.VarChar).Value = IGST;
            cmd.Parameters.Add("@NetAmount", SqlDbType.VarChar).Value = NetAmount;
            cmd.Parameters.Add("@Cash", SqlDbType.VarChar).Value = Cash;
            cmd.Parameters.Add("@ChequeAmount", SqlDbType.VarChar).Value = ChequeAmount;
            cmd.Parameters.Add("@BankName", SqlDbType.VarChar).Value = BankName;
            cmd.Parameters.Add("@BranchName", SqlDbType.VarChar).Value = BranchName;
            cmd.Parameters.Add("@ChequeNo", SqlDbType.VarChar).Value = ChequeNo;
            cmd.Parameters.Add("@BuyerName", SqlDbType.VarChar).Value = BuyerName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = PhoneNo;
            cmd.Parameters.Add("@AmountInWord",SqlDbType.VarChar).Value = AmountInWord;
            //cmd.Parameters.Add("@AmountInWord", SqlDbType.VarChar).Value = AmountInWord;
            cmd.Parameters.Add("@CGST", SqlDbType.VarChar).Value = cgst;
            cmd.Parameters.Add("@SGST", SqlDbType.VarChar).Value = sgst;
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Result = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return Result;
        }
                    
        //Stock entry-----------------------
        public bool SaveStock(string prc, string prd,string weight)
        {
            bool Result = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertStock";
            cmd.Parameters.Add("@ProcutsCode", SqlDbType.VarChar).Value = prc;
            cmd.Parameters.Add("@ProcutsDetails", SqlDbType.VarChar).Value = prd;
            cmd.Parameters.Add("@Weight", SqlDbType.VarChar).Value = weight;
            cmd.Connection = con;
            try
            {
                con.Open();
                //cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This product is already exist");
            }
            finally
            {
                con.Close();
                //con.Dispose();
            }
            return Result;
        }
        //strock entry finish---------------------------------------------------------
        public BillingDataset GetBillInfo(string BillingID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetProductTransaction"))
                {
                    cmd.Parameters.Add(new SqlParameter("@BillingID", BillingID));
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (BillingDataset dsCustomers = new BillingDataset())
                        {
                            sda.TableMappings.Add("Table", "DataTable1");
                            sda.TableMappings.Add("Table1", "DataTable2");
                            sda.Fill(dsCustomers);
                            return dsCustomers;
                        }
                    }
                }
            }

        }
        
        public bool UpdateCurrentGoldVlue(int Price)
        {
            bool Result = false;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE tbl_CurrentGoldValue SET GoldValue = @GoldValue",con);
            cmd.Parameters.AddWithValue("@GoldValue", Price);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Result = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return Result;
        }

        public string GetCurrentGoldValue()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable ds = new DataTable();
            string Value;
            SqlConnection con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("SELECT * FROM tbl_CurrentGoldValue", con);
            da.SelectCommand = cmd;
            da.Fill(ds);
            con.Close();
            Value = Convert.ToString(ds.Rows[0][0]);
            return Value;
        }

    }
}
