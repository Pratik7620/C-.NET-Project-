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
    public partial class View_Employee_Details : Form
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
        public View_Employee_Details()
        {
            InitializeComponent();
        }

        private void View_Employee_Details_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Employee_Details", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Employee_Details.DataSource = dt;

            Con_Close();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee obj = new Add_Employee();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();

        }

        private void btn_Remove_Employee_Click(object sender, EventArgs e)
        {
            View_Remove_Employee obj = new View_Remove_Employee();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From Employee_Details Where Emp_ID = " + tb_Emp_Id.Text + " ", Con);

            DataTable dt = new DataTable();

            dgv_Employee_Details.DataSource = dt;

            sda.Fill(dt);

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Employee_Details", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Employee_Details.DataSource = dt;

            Con_Close();
        }
    }
}
