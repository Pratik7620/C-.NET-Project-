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
    public partial class User_Managment : Form
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

        public User_Managment()
        {
            InitializeComponent();
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Password.Text == tb_Confirm_Password.Text)
            {
                if (tb_Username.Text != "" && tb_Password.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Login_Table(Username,Password) values('" + tb_Username.Text + "' , '" + tb_Password.Text + "')", Con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("Succesfully Assign Username And Password ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_Username.Text = "";
                    tb_Password.Text = "";
                    tb_Confirm_Password.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Please , Fill All The Fields...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Check Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_Confirm_Password.Text = "";
            }

            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
