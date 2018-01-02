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
    public partial class MainWindow : Form
    {
        string day, time;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createCouseBtn_Click(object sender, EventArgs e)
        {
            if (courseNameTB.Text.Equals("") || comboDay.Text.Equals("") || comboTime.Text.Equals("") || secTB.Text.Equals("")) { MessageBox.Show("Insert All Feilds"); }
            else
            {
                string courseName = courseNameTB.Text;
                string sec = secTB.Text;
                string query = "INSERT INTO Course (CourseName,CourseTime,CourseDay,CourseSection) VALUES (@CourseName,@CourseTime,@CourseDay,@CourseSection)";
                string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
                SqlConnection con = new SqlConnection(myConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@CourseName", courseNameTB.Text);
                cmd.Parameters.Add("@CourseTime", time);
                cmd.Parameters.Add("@CourseDay", day);
                cmd.Parameters.Add("@CourseSection", secTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Created");
            }
        }
    

        private void loadCourseBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from Course";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            SqlDataReader dr = myCommand.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                courseList.DataSource = dt;
            }
            myConnection.Close();
        }

        private void editCourse_Click(object sender, EventArgs e)
        {
            if (EditCourseIdTB.Text == "")
            {
                MessageBox.Show("Insert Course Id");
            }
            else
            {
                string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                if (courseNameTB.Text != "")
                {
                    string query = "update Course set CourseName='" + courseNameTB.Text + "'where CourseId=" + EditCourseIdTB.Text;
                    SqlCommand myCommand = new SqlCommand(query, myConnection);
                    myCommand.ExecuteNonQuery();
                }
                if (comboTime.Text != "")
                {
                    string query = "update Course set CourseTime='" + comboTime.Text + "'where CourseId=" + EditCourseIdTB.Text;
                    SqlCommand myCommand = new SqlCommand(query, myConnection);
                    myCommand.ExecuteNonQuery();
                }
                if (comboDay.Text != "")
                {
                    string query = "update Course set CourseDay='" + comboDay.Text + "'where CourseId=" + EditCourseIdTB.Text;
                    SqlCommand myCommand = new SqlCommand(query, myConnection);
                    myCommand.ExecuteNonQuery();
                }
                if (secTB.Text != "")
                {
                    string query = "update Course set CourseSection='" + secTB.Text + "'where CourseId=" + EditCourseIdTB.Text;
                    SqlCommand myCommand = new SqlCommand(query, myConnection);
                    myCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Update Done");
                myConnection.Close();
                EditCourseIdTB.Text = "";
            }
        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            day = comboDay.Text;
        }

        private void comboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = comboTime.Text;
        }

        private void courseNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearDBbtn_Click(object sender, EventArgs e)
        {
            string query = "TRUNCATE TABLE Course";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            SqlDataReader dr = myCommand.ExecuteReader();
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void delCourseBrn_Click(object sender, EventArgs e)
        {
            if (delCourseTB.Text == "")
            {
                MessageBox.Show("Enter Course ID");
            }
            else
            {
                string query = "delete from Course where CourseId=" + delCourseTB.Text;
                string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Delete Done");
                delCourseTB.Text = "";
            }
        }

    }
}
