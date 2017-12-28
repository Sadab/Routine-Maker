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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userName.Text.Equals("")||passwordTB.Text.Equals("")) { MessageBox.Show("Insert UserName And Password"); }
            else if (userName.Text.Equals("1"))
            {
                string query = "select * from userInfo where UserId =" + userName.Text + "AND UserPass='" + passwordTB.Text + "'";
                string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader dataReader = myCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    MainWindow m = new MainWindow();
                    m.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password");
                }
                myConnection.Close();
            }
            else
            {
                string query = "select * from userInfo where UserId =" + userName.Text + "AND UserPass='" + passwordTB.Text + "'";
                string myConnectionString = ConfigurationManager.ConnectionStrings["routineDB"].ConnectionString.ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader dataReader = myCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    RoutineMaker rm = new RoutineMaker();
                    rm.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
                myConnection.Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentLoginBtn_Click(object sender, EventArgs e)
        {
            StudentLoginFrom sl = new StudentLoginFrom();
            sl.Visible = true;
            this.Visible = false;
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
