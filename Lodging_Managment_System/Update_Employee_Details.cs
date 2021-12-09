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
    public partial class Update_Employee_Details : Form
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

        public Update_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Add_Employee obj = new Add_Employee();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Employee_Details where Emp_ID = " + tb_Emp_ID.Text + " ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Emp_Name.Text = obj.GetString(obj.GetOrdinal("Emp_Name"));
                tb_Mobile_No.Text = (obj["Mob_No"].ToString());
                dtp_DOB.Text = (obj["DOB"].ToString());
                tb_Gender.Text = obj.GetString(obj.GetOrdinal("Gender"));
                tb_Aadhar_No.Text = (obj["Aadhar_No"].ToString());
                Cb_Designation.Text = obj.GetString(obj.GetOrdinal("Designation"));
                tb_Salary.Text = (obj["Salary"].ToString());
                dtp_Hire_Date.Text = (obj["Hire_Date"].ToString());
                tb_Email.Text = obj.GetString(obj.GetOrdinal("Email_Id"));
                tb_PAN_No.Text = obj.GetString(obj.GetOrdinal("PAN_No"));
                tb_Shift.Text = obj.GetString(obj.GetOrdinal("Shift_Time"));

                if ( tb_Gender.Text == "Female")
                {
                    rb_Female.Checked = true;
                }
                else if (tb_Gender.Text == "Male")
                {
                    rb_Male.Checked = true;
                }

                if (tb_Shift.Text == "Morning")
                {
                    rb_Morning.Checked = true;
                }
                else if(tb_Shift.Text == "Night")
                {
                    rb_Night.Checked = true;
                }
                
               

            }
            else
            {
                MessageBox.Show("Invaild Roll Number...");
                tb_Emp_ID.Clear();
                tb_Emp_ID.Focus();
            }
            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Emp_ID.Text != "")
            {
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

                UserName_Updt = Global_Login.U_Name;

                SqlDataAdapter sda = new SqlDataAdapter("Update Employee_Details Set Emp_Name = '" + tb_Emp_Name.Text + "' , Mob_No = " + tb_Mobile_No.Text + " , DOB = '" + dtp_DOB.Text + "' , Aadhar_No = " + tb_Aadhar_No.Text + " , PAN_No = '" + tb_PAN_No.Text + "' , Designation = '" + Cb_Designation.Text + "', Salary = " + tb_Salary.Text + " , Hire_Date = '" + dtp_Hire_Date.Text + "' , Email_Id = '" + tb_Email.Text + "' , Gender = '" + Gender + "' , Shift_Time = '" + Shift + "', UserName_Updt = '" + UserName_Updt + "'  where Emp_ID = " + tb_Emp_ID.Text + "", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("Update Successfully..", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
               
            }
            else
            {
                MessageBox.Show("Plz , Fill All The FieldsS");
            }

            Con_Close();
        }

        public void Clear()
        {
            tb_Emp_ID.Text = "";
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
            tb_Shift.Text = "";
            tb_Gender.Text = "";
            Cb_Designation.Text = "";
            tb_Emp_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
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
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Deleted_Emp(Emp_Id , Emp_Name , Mob_No , DOB , Gender , Aadhar_No , PAN_No , Designation , Salary , Hire_date , Email_Id , Shift_Time , UserName) values(" + tb_Emp_ID.Text + ",'" + tb_Emp_Name.Text + "'," + tb_Mobile_No.Text + ",'" + dtp_DOB.Text + "','" + Gender + "'," + tb_Aadhar_No.Text + ",'" + tb_PAN_No.Text + "','" + Cb_Designation.Text + "'," + tb_Salary.Text + ",'" + dtp_Hire_Date.Text + "','" + tb_Email.Text + "','" + Shift + "','" + U_Name + "')", Con);
                
                DataTable dt = new DataTable();

                sda.Fill(dt);

            }


            Con_Open();

            SqlCommand cmd = new SqlCommand("Delete from Employee_Details where Emp_Id = " + tb_Emp_ID.Text + "", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Deleted Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();

            Con_Close();
        }

        public string U_Name { get; set; }

        public string UserName { get; set; }

        public string UserName_Updt { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
