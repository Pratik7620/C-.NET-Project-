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
    public partial class Update_Rooms : Form
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

        public Update_Rooms()
        {
            InitializeComponent();
        }

      
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Add_Room obj = new Add_Room();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Rooms where RoomNo = " + tb_Room_No.Text + " ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                cb_Room_Type.Text = obj.GetString(obj.GetOrdinal("RoomType"));
                cb_Bed_Type.Text = obj.GetString(obj.GetOrdinal("BedType"));
                tb_Room_Specification.Text = obj.GetString(obj.GetOrdinal("Specification"));
                tb_Amount_Day.Text = (obj["Amount_Day"].ToString());
                tb_Per_Hrs.Text = (obj["Per_Hrs"].ToString());
              
            }
            else
            {
                MessageBox.Show("Invaild Room Number...");
                tb_Room_No.Clear();
                tb_Room_No.Focus();
            }

            Con_Close();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();


            if (tb_Room_No.Text != "" && cb_Room_Type.Text != "" && cb_Bed_Type.Text != "" && tb_Amount_Day.Text != "")
            {
                UserName = Global_Login.U_Name;

                SqlDataAdapter sda = new SqlDataAdapter("Update Rooms Set RoomNo =  " + tb_Room_No.Text + " ,RoomType =  '" + cb_Room_Type.Text + "' ,BedType =  '" + cb_Bed_Type.Text + "' , Amount_Day =  " + tb_Amount_Day.Text + " , Specification = '" + tb_Room_Specification.Text + "' , UserName_Updt = '" + UserName + "' , Per_Hrs = " + tb_Per_Hrs.Text + " Where RoomNo = " + tb_Room_No.Text + "  ", Con);

                DataTable dt = new DataTable();


                sda.Fill(dt);


                MessageBox.Show("\t Update Room Succesfully \t");

                tb_Room_No.Clear();
                tb_Amount_Day.Clear();
                tb_Room_Specification.Clear();
                cb_Bed_Type.SelectedIndex = -1;
                cb_Room_Type.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show(" Please Filled All Fields");
            }

            Con_Close();
           
        }

        public string UserName { get; set; }
    }
}
