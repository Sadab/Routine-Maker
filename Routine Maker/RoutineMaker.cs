using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routine_Maker
{
    public partial class RoutineMaker : Form
    {
        string courseSelect;
        public RoutineMaker()
        {
            InitializeComponent();
        }

        private void comboCourseSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseSelect = comboCourseSelect.Text;
        }

        private void courseSelectBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from Course where CourseName like('%"+ comboCourseSelect.Text + "%')";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.ExecuteNonQuery();
            SqlDataReader dr = myCommand.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                courseListGrid.DataSource = dt;
            }
            myConnection.Close();
        }
    }
}
