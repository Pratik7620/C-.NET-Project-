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
    
    public partial class Service : Form
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

        public Service()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            ID();
           
        }

        public void ID()
        {
            Con.Open();


            SqlCommand cm = new SqlCommand("select *From Cust_Booking_Room_Info where Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            var obj1 = cm.ExecuteReader();


            if (obj1.Read())
            {
                tb_Cust_ID.Text = (obj1["ID"].ToString());
            }
            else
            {
                MessageBox.Show("Inavlid ");

            }

            Con.Close();
        }

        private void btn_Add_To_Bill_Click(object sender, EventArgs e)
        {
            Con.Open();

            UserName = Global_Login.U_Name;

            SqlDataAdapter sda = new SqlDataAdapter("Insert into R_Service(Cust_ID,Service,Charge,UserName) values(" + tb_Cust_ID.Text + ",'" + cb_Service.Text + "'," + tb_Charge.Text + ",'" + UserName + "')", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            MessageBox.Show("Successfully Added");
            tb_Cust_ID.Clear();
            tb_Charge.Clear();
           
            Con_Close();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet16.R_Service' table. You can move, or remove it, as needed.
            //this.r_ServiceTableAdapter.Fill(this.lodging_Managment_System_DBDataSet16.R_Service);

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            Service_Next obj = new Service_Next();
            obj.Show();
            tableLayoutPanel3.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update_Service obj = new Update_Service();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }


        public string UserName { get; set; }
    }
}
