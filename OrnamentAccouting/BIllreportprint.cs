using CrystalDecisions.CrystalReports.Engine;
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
    public partial class BIllreportprint : Form
    {
        private string billinID;
        public BIllreportprint(string BillingID)
        {
            InitializeComponent();
            billinID = BillingID;
            //string filepath = @"G:\OrnamentAccouting\OrnamentAccouting\BillPrintreport.rpt";


            //DataAccessLayer dal = new DataAccessLayer();
            //DataSet ds = new BillingDataset();
            //ReportDocument rd = new ReportDocument();
            //rd.Load(filepath);
            //rd.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = rd;


        }

        private void BIllreportprint_Load(object sender, EventArgs e)
        {
            BillPrintreport crystalReport = new BillPrintreport();
            DataAccessLayer dal = new DataAccessLayer();
            BillingDataset dsCustomers = dal.GetBillInfo(billinID);
            crystalReport.SetDataSource(dsCustomers);
            this.crystalReportViewer1.ReportSource = crystalReport;
            this.crystalReportViewer1.RefreshReport();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
