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
    public partial class Search_Customer : Form
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

        public Search_Customer()
        {
            InitializeComponent();
        }

        private void btn_View_All_Customer_Click(object sender, EventArgs e)
        {
            View_All_Customer obj = new View_All_Customer();

            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            tlp_Name.Visible = true;
            tlp_ID.Visible = false;
        }

        private void btn_ID_Click(object sender, EventArgs e)
        {
            tlp_ID.Visible = true;
            tlp_Name.Visible = false;
        }

        private void btn_Search_ID_Click(object sender, EventArgs e)
        {
            (dgv_Search_Customer.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cust_ID='{0}'", tb_Customer_ID.Text);
        }

        private void btn_Search_Name_Click(object sender, EventArgs e)
        {
            dgv_Search_Customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                //this code is used to search Name on the basis of txttxtSearchItem.text
                ((DataTable)dgv_Search_Customer.DataSource).DefaultView.RowFilter = string.Format("Name like '%{0}%'", tb_Search_Name.Text.Trim().Replace("'", "''"));
            }
            catch (Exception) { }
        }

        private void Search_Customer_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Cust_Personal_Info.Cust_ID,Cust_Personal_Info.Name,Cust_Personal_Info.Booking_Date,Cust_Personal_Info.Mobile_Number,Cust_Personal_Info.Alternate_Mob_No,Cust_Personal_Info.Email,Cust_Personal_Info.DOB,Cust_Personal_Info.Address,Cust_Personal_Info.AdharCard_No,Cust_Personal_Info.PAN_No,Cust_Booking_Room_Info.Room_No,Cust_Booking_Room_Info.Check_In_Date,Cust_Booking_Room_Info.Check_Out_Date,Cust_Booking_Room_Info.Room_Type,Cust_Booking_Room_Info.Bed_Type,Cust_Booking_Room_Info.Day,Cust_Booking_Room_Info.Hrs,Cust_Booking_Room_Info.Total,Pay_Amount.Room_Bill,Pay_Amount.Discount,Pay_Amount.Total,Pay_Amount.Pay,Pay_Amount.Remaining From Cust_Personal_Info INNER JOIN Cust_Booking_Room_Info ON Cust_Personal_Info.Cust_ID = Cust_Booking_Room_Info.Cust_ID INNER JOIN Pay_Amount ON Cust_Personal_Info.Cust_ID = Pay_Amount.Cust_ID ", Con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Search_Customer.DataSource = dt;

            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
