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
    public partial class Update_Service : Form
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

        public Update_Service()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Service obj = new Service();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Add_To_Bill_Click(object sender, EventArgs e)
        {
             if(tb_Cust_ID.Text != "")
             {
                    UserName_Updt = Global_Login.U_Name;

                    SqlDataAdapter sda = new SqlDataAdapter("Update Employee_Details Set Sevice = '" + cb_Service.Text + "', Charge = " + tb_Charge.Text + ", UserName_Updt = '" + UserName_Updt + "'  where Cust_ID = " + tb_Cust_ID.Text + "", Con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("Update Successfully..");
               
            }
            else
            {
                MessageBox.Show("Plz , Fill All The FieldsS");
            }
        }

        public string UserName_Updt { get; set; }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From R_Service where Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                cb_Service.Text = obj.GetString(obj.GetOrdinal("Service"));
                tb_Charge.Text = (obj["Charge"].ToString());
               
            }
            else
            {
                MessageBox.Show("Invaild ID...");
                tb_Cust_ID.Clear();
                tb_Cust_ID.Focus();
            }
            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
