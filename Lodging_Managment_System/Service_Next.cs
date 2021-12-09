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
    public partial class Service_Next : Form
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
        public Service_Next()
        {
            InitializeComponent();
        }

        private void Service_Next_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet22.R_Service' table. You can move, or remove it, as needed.
            this.r_ServiceTableAdapter3.Fill(this.lodging_Managment_System_DBDataSet22.R_Service);
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet17.R_Service' table. You can move, or remove it, as needed.
            //this.r_ServiceTableAdapter2.Fill(this.lodging_Managment_System_DBDataSet17.R_Service);
            
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet15.R_Service' table. You can move, or remove it, as needed.
            //this.r_ServiceTableAdapter1.Fill(this.lodging_Managment_System_DBDataSet15.R_Service);
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet14.R_Service' table. You can move, or remove it, as needed.
            //this.r_ServiceTableAdapter.Fill(this.lodging_Managment_System_DBDataSet14.R_Service);
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet13.Service' table. You can move, or remove it, as needed.
            //this.serviceTableAdapter.Fill(this.lodging_Managment_System_DBDataSet13.Service);

        }

        private void btn_Amount_Click(object sender, EventArgs e)
        {
            tb_Amount.Text = "0";

            for (int i = 0; i < dgv_Service.Rows.Count; i++)
            {
                tb_Amount.Text = Convert.ToString(double.Parse(tb_Amount.Text) + double.Parse(dgv_Service.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            //Con.Open();
          
            //    SqlDataAdapter sda = new SqlDataAdapter("Insert into Service_Charge(ID,Room_No,Service) values(" + tb_ID.Text + "," + room.Text + ", " + tb_Amount.Text + ") ", Con);

            //    DataTable dt = new DataTable();

            //    sda.Fill(dt);

            //    MessageBox.Show("Successfully Added");
            //    this.Close();

            //Con_Close();
        
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Service obj = new Service();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Id_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service Where  Cust_ID = " + tb_ID.Text + " ", Con);

            DataTable dt = new DataTable();

            dgv_Service.DataSource = dt;

            sda.Fill(dt);

            Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service  ", Con);

            DataTable dt = new DataTable();

            dgv_Service.DataSource = dt;

            sda.Fill(dt);

            Con_Close();
        }

      

       

       
            
            
            
            
        

      

       
    }
}
