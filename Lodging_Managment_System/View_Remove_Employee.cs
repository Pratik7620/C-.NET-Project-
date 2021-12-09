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
    public partial class View_Remove_Employee : Form
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
        public View_Remove_Employee()
        {
            InitializeComponent();
        }

       

      

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee obj = new Add_Employee();
            obj.MdiParent = this.MdiParent;
       
            obj.Show();
            this.Close();
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            View_Employee_Details obj = new View_Employee_Details();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet18.Deleted_Emp' table. You can move, or remove it, as needed.
            this.deleted_EmpTableAdapter.Fill(this.lodging_Managment_System_DBDataSet18.Deleted_Emp);


            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Deleted_Emp", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Employee_Delete.DataSource = dt;

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From Deleted_Emp Where Emp_ID = " + tb_Emp_Id.Text + " ", Con);

            DataTable dt = new DataTable();

            dgv_Employee_Delete.DataSource = dt;

            sda.Fill(dt);

            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Deleted_Emp", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Employee_Delete.DataSource = dt;

            Con_Close();
        }

       
    }
}
