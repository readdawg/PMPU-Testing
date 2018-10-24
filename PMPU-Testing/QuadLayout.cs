using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPU_Testing
{
    public partial class QuadLayout : Form
    {
        public QuadLayout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }
    }
}
