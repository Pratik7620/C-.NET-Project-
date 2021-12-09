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
    public partial class Update_Room_Booking_Details : Form
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

        public Update_Room_Booking_Details()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
             Con_Open();

             SqlCommand cmd = new SqlCommand("Select * From Cust_Booking_Room_Info where ID = " + tb_ID.Text + " And Room_No = " + tb_Room_No.Text + "", Con);

            var obj12 = cmd.ExecuteReader();

            if (obj12.Read())
            {
                dtp_Ckeck_In_Date.Text = (obj12["Check_In_Date"].ToString());
                dtp_Check_Out_Date.Text = (obj12["Check_Out_Date"].ToString());
                cb__Room_Type.Text = obj12.GetString(obj12.GetOrdinal("Room_Type"));
                cb_Bed_Type.Text = obj12.GetString(obj12.GetOrdinal("Bed_Type"));
               // tb_Room_No.Text = (obj12["Room_No"].ToString());
                tb_Count_Of_Rooms.Text = (obj12["Count_Of_Rooms"].ToString());
                tb_Day.Text = (obj12["Day"].ToString());
                tb_Hrs.Text = (obj12["Hrs"].ToString());
                tb_Amount.Text = (obj12["Amount"].ToString());
                tb_Total.Text = (obj12["Total"].ToString());
              
            }
            else
            {
                MessageBox.Show("Invaild Roll Number...");
                tb_ID.Clear();
                tb_ID.Focus();
            }
            Con_Close();

        }

        private void dtp_Check_Out_Date_ValueChanged(object sender, EventArgs e)
        {

            DateTime date1 = dtp_Ckeck_In_Date.Value.Date;
            DateTime date2 = dtp_Check_Out_Date.Value.Date;

            int Days = ((TimeSpan)(date2 - date1)).Days;

            tb_Day.Text = Days.ToString();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            string Total = (Convert.ToInt32(tb_Day.Text) * Convert.ToDecimal(tb_Amount.Text)).ToString();
            tb_Total.Text = Total;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Pay_Amount where ID = " + tb_ID.Text + "  And Room_No = "+tb_Room_No.Text+"", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
               
                tb_Discount.Text = (obj["Discount"].ToString());
                tb_Pay.Text = (obj["Pay"].ToString());

            }
            else
            {
                MessageBox.Show("Invaild Roll Number...");
                tb_ID.Clear();
                tb_ID.Focus();
            }
            Con_Close();


        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            double Rprice = 0;
            double Discount, Total, TPrice = 0;

            Rprice = double.Parse(tb_Total.Text);
            Discount = double.Parse(tb_Discount.Text);

            Total = Rprice * (Discount / 100);
            TPrice = Rprice - Total;

            tb_Tot.Text = TPrice.ToString();
        }

        private void tb_Pay_TextChanged(object sender, EventArgs e)
        {
            double a = double.Parse(tb_Tot.Text);
            double b = double.Parse(tb_Pay.Text);
            tb_Remaining.Text = Convert.ToString(a - b);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Update Cust_Booking_Room_Info Set Check_Out_Date = '" + dtp_Check_Out_Date.Text + "' , Day = " + tb_Day.Text + " , Hrs = " + tb_Hrs.Text + " , Total = " + tb_Total.Text + " where ID = " + tb_ID.Text + " And Room_No = " + tb_Room_No.Text + "", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

          //  MessageBox.Show("Update Successfully..", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con_Close();


            Con_Open();

            UserName_Updt = Global_Login.U_Name;

            SqlDataAdapter s = new SqlDataAdapter("Update Pay_Amount Set Room_Bill = " + tb_Total.Text + " ,Total = " + tb_Tot.Text + " , Remaining = " + tb_Remaining.Text + " , UserName_Updt = '" + UserName_Updt + "' where ID = " + tb_ID.Text + " And Room_No = " + tb_Room_No.Text + "", Con);

            DataTable d = new DataTable();

            s.Fill(d);

            MessageBox.Show("Update Successfully..", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con_Close();
           
        }

        public string UserName { get; set; }



        public string UserName_Updt { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
