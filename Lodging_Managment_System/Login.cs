using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lodging_Managment_System
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public Login()
        {
            InitializeComponent();
        }

      

        private void btn_Login_Click(object sender, EventArgs e)
        {

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select count(*) from  Login_Table where Username = '" + tb_Username.Text + "'  And  Password = '" + tb_Password.Text + "'  ", Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show(" Login Sucessfull !!");

                Global_Login.U_Name = tb_Username.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Login.User_Role = 1;
                }
                else
                {
                    Global_Login.User_Role = 0;
                }


                MDI_LMS obj = new MDI_LMS();

                obj.Show();


            }
            else
            {
               lbl_Error.Text=  " Invalid Username And Password";
               lbl_Error.ForeColor = Color.Red;
                tb_Password.Clear();
                tb_Username.Clear();
                tb_Username.Focus();

            }

            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Password.Clear();
            tb_Username.Clear();
        }
    }
}
