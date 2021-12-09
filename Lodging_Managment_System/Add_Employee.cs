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
    public partial class Add_Employee : Form
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
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            View_Employee_Details obj = new View_Employee_Details();
            obj.MdiParent = this.MdiParent;
           // obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void btn_Remove_Employee_Click(object sender, EventArgs e)
        {
            View_Remove_Employee obj = new View_Remove_Employee();

            obj.MdiParent = this.MdiParent;
           // obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();

            Con_Open();

            cmd.CommandText = "Select Count(Emp_Id) from Employee_Details";
            cmd.Connection = Con;
            Cnt = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            if (Cnt > 0)
            {
                cmd.CommandText = "Select Max(Emp_Id) from Employee_Details";
                cmd.Connection = Con;
                Cnt = Convert.ToInt32(cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();
            return Cnt;
        }

        public void Clear_Controls()
        {
            
            tb_Emp_Name.Text = "";
            tb_Mobile_No.Text = "";
            dtp_DOB.ResetText();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Night.Checked = false;
            tb_Aadhar_No.Text = "";
            tb_PAN_No.Text = "";
            Cb_Designation.SelectedIndex = -1;
            tb_Salary.Text = "";
            dtp_Hire_Date.ResetText();
            tb_Email.Text = "";
            Cb_Designation.Text = "";
            tb_Emp_Name.Focus();
        }
      

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Digit_Letters(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            View_Employee_Details obj = new View_Employee_Details();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Remove_Employee_Click_1(object sender, EventArgs e)
        {
            View_Remove_Employee obj = new View_Remove_Employee();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            Con_Open();

            String Gender = "";

            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }
            else if (rb_Female.Checked)
            {
                Gender = rb_Female.Text;
            }

            string Shift = "";

            if (rb_Morning.Checked)
            {
                Shift = rb_Morning.Text;
            }
            else if (rb_Night.Checked)
            {
                Shift = rb_Night.Text;
            }

            U_Name = Global_Login.U_Name;

            if (tb_Emp_ID.Text != "" && tb_Emp_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Aadhar_No.Text != "" && tb_PAN_No.Text != "" && Cb_Designation.Text != "" && tb_Salary.Text != "" && tb_Email.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Employee_Details(Emp_Id , Emp_Name , Mob_No , DOB , Gender , Aadhar_No , PAN_No , Designation , Salary , Hire_date , Email_Id , Shift_Time , UserName ) values(" + tb_Emp_ID.Text + ",'" + tb_Emp_Name.Text + "'," + tb_Mobile_No.Text + ",'" + dtp_DOB.Text + "','" + Gender + "'," + tb_Aadhar_No.Text + ",'" + tb_PAN_No.Text + "','" + Cb_Designation.Text + "'," + tb_Salary.Text + ",'" + dtp_Hire_Date.Text + "','" + tb_Email.Text + "','" + Shift + "','" + U_Name + "')", Con);
                DataTable dt = new DataTable();
        
                sda.Fill(dt);

                MessageBox.Show("Employee Add Successfully...", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please , Fill All The Fields...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Cb_Designation.Text == "Manager" || Cb_Designation.Text == "Cashier" || Cb_Designation.Text == "Receiptionist")
            {
                User_Managment obj = new User_Managment();
                this.Close();
                obj.Show();
            }

            Clear_Controls();
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());

            Con_Close();
        }

      

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Details_Click(object sender, EventArgs e)
        {
            Update_Employee_Details obj = new Update_Employee_Details();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }


        public string U_Name { get; set; }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

      
    }
}
