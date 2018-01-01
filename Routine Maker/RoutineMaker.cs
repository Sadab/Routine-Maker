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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Routine_Maker
{
    public partial class RoutineMaker : Form
    {
        string courseSelect;
        List<string> a = new List<string>();
        public RoutineMaker()
        {
            InitializeComponent();
            getComboBoxData();
        }
        private void getComboBoxData()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            string Sql = "select distinct CourseName from Course";
            SqlConnection conn = new SqlConnection(myConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboCourseSelect.Items.Add(DR[0]);
            }
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

        private void addCourseToListBtn_Click(object sender, EventArgs e)
        {
            bool flag=false;
            string query = "INSERT INTO Routine (CourseName,CourseTime,CourseDay,CourseSection) VALUES (@CourseName,@CourseTime,@CourseDay,@CourseSection)";
            string query2 = "select * from Routine";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();

            if (courseNameLbl.Text == "" && courseDayLbl.Text == "" && courseTimeLbl.Text == "" && courseSecLbl.Text == "")
            {
                MessageBox.Show("Fill up all feilds");
            }
            else
            {
                SqlConnection con = new SqlConnection(myConnectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query2, con);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[1].ToString() == courseNameLbl.Text && rd[2].ToString() == courseTimeLbl.Text && rd[3].ToString() == courseDayLbl.Text)
                    {
                        flag = true;
                        break;
                    }
                    else if(rd[1].ToString()==courseNameLbl.Text && rd[2].ToString() == courseTimeLbl.Text)
                    {
                        flag = true;
                        break;
                    }
                    else if (rd[2].ToString() == courseTimeLbl.Text)
                    {
                        flag = true;
                        break;
                    }
                    else if (rd[1].ToString() == courseNameLbl.Text)
                    {
                        flag = true;
                        break;
                    }
                    
                }
            }
            
            
            if (flag == true)
            {
                MessageBox.Show("Clash!!!");
            }
            else
            {
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

        private void RoutineMaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "TRUNCATE TABLE Routine";
            string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            SqlDataReader dr = myCommand.ExecuteReader();
            Application.Exit();
        }

        private void courseListGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            courseListGrid.ReadOnly=true;
        }

        private void addedCourseGrid_DoubleClick(object sender, EventArgs e)
        {
            addedCourseGrid.ReadOnly = true;
        }

        private void genPdfBtn_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\SadabRahman\source\repos\Routine Maker\Routine.pdf", FileMode.Create));
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfPTable pdf = new PdfPTable(addedCourseGrid.Columns.Count);
            doc.Open();
            
            for (int i=0; i<addedCourseGrid.Columns.Count; i++)
            {
                pdf.AddCell(new Phrase(addedCourseGrid.Columns[i].HeaderText));
            }
            pdf.HeaderRows = 1;
            for(int i=0; i<addedCourseGrid.Rows.Count; i++)
            {
                for(int j=0; j<addedCourseGrid.Columns.Count; j++)
                {
                    if (addedCourseGrid[j, i].Value != null)
                    {
                        pdf.AddCell(new Phrase(addedCourseGrid[j, i].Value.ToString()));
                    }
                }
            }
            doc.Add(pdf);
            doc.Close();
            MessageBox.Show("Pdf Generated");
        }
    }
}
