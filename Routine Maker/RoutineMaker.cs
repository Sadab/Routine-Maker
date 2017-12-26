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
        List<string> a = new List<string>();
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

        private void courseListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(courseListGrid.SelectedCells[0].Value.ToString());
            string query = "select * from Course where CourseId="+i+"";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                courseNameLbl.Text = dr["CourseName"].ToString();
                courseDayLbl.Text = dr["CourseDay"].ToString();
                courseTimeLbl.Text = dr["CourseTime"].ToString();
                courseSecLbl.Text = dr["CourseSection"].ToString();
            }
            myConnection.Close();
        }

        public void DisplayData()
        {
            string query = "select * from Routine";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            SqlDataReader dr = myCommand.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                addedCourseGrid.DataSource = dt;
            }
            myConnection.Close();
        }
        public void CourseChecker()
        {

        }
        private void addCourseToListBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Routine (CourseName,CourseTime,CourseDay,CourseSection) VALUES (@CourseName,@CourseTime,@CourseDay,@CourseSection)";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(myConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@CourseName", courseNameLbl.Text);
            cmd.Parameters.Add("@CourseTime", courseTimeLbl.Text);
            cmd.Parameters.Add("@CourseDay", courseDayLbl.Text);
            cmd.Parameters.Add("@CourseSection", courseSecLbl.Text);
            cmd.ExecuteNonQuery();
            DisplayData();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            string query = "TRUNCATE TABLE Routine";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            SqlDataReader dr = myCommand.ExecuteReader();
            Application.Exit();

        }
    }
}
