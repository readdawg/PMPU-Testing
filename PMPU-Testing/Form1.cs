using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPU_Testing
{
    public partial class Form1 : Form
    {
        //Initialize data table
        DataTable dt1 = new DataTable();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hard set DataConnectionString
            PMPU_Testing.Properties.Settings.Default.DataConnectioString = @"Data Source=localhost\MSSQL2012;Initial Catalog=InsightEnt;User ID=sa;Password=V4in$ight";

            //Clear and create DataTable
            dt1.Clear();
            //dt1.Columns.Add("Monitor");
            dt1.Columns.Add("Type");
            dt1.Columns.Add("Class");

            
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            //Set Data Row
            dt1.Clear();
            //DataRow _single = dt1.NewRow();
            //_single["Monitor"] = "1";
            //_single["Type"] = "0";
            //_single["Class"] = "445667709 - 928337671";

            dt1.Rows.Add("0", "445667709 - 785451355");

            dataGridView1.DataSource = dt1;
        }

        private void btn_quad_Click(object sender, EventArgs e)
        {
            dt1.Clear();
            //DataRow _quad = dt1.NewRow();
            //_quad["Monitor"] = "1";
            //_quad["Type"] = "4";
            //_quad["Class"] = "445667709 - 928337671, 445667709 - 928337671, 445667709 - 928337671, 445667709 - 928337671";

            dt1.Rows.Add("1", "445667709 - 785451355, 445667709 - 785451355, 445667709 - 785451355, 445667709 - 785451355");

            dataGridView1.DataSource = dt1;
        }

        private void btn_changeMonitor_Click(object sender, EventArgs e)
        {
            dt1.Clear();
            //DataRow _quadChange = dt1.NewRow();
            //_quadChange["Monitor"] = "1";
            //_quadChange["Type"] = "4";
            //_quadChange["Class"] = "";

            dt1.Rows.Add("1", "445667709 - 785451355, 445667709 - 785451355, 445667709 - 1903839689, 445667709 - 785451355");

            dataGridView1.DataSource = dt1;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //Open connection
            SqlConnection con = new SqlConnection(PMPU_Testing.Properties.Settings.Default.DataConnectioString);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand("usp_PmpuChange3", con);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@VideoWallUpdate", dt1);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Video Wall Change Push Complete");
            con.Close();

            //Close Video Wall
            System.Diagnostics.Process[] procs = null;

            try
            {
                procs = Process.GetProcessesByName("videowall");
                Process videowallProc = procs[0];
                if(!videowallProc.HasExited)
                {
                    videowallProc.Kill();
                    videowallProc.Dispose();
                }
            }

            finally
            {
                if(procs!=null)
                {
                    foreach (Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }


            //Wait and Launch Video Wall
            //Sleep for 1 second
            System.Threading.Thread.Sleep(1000);

            //Start new Video Wall Process
            Process startVideo = Process.Start(@"C:\Program Files\VI Enterprise\Video Wall\VideoWall.exe");
        }
    }
}
