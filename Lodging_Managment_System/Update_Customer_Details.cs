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
    public partial class Update_Customer_Details : Form
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

        public Update_Customer_Details()
        {
            InitializeComponent();
        }

        private void btn_Personal_Details_Click(object sender, EventArgs e)
        {
            frm_Booking1 obj = new frm_Booking1();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void btn_Booking_Details_Updt_Click(object sender, EventArgs e)
        {
            Update_Room_Booking_Details obj = new Update_Room_Booking_Details();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            UserName = Global_Login.U_Name;

            SqlDataAdapter s = new SqlDataAdapter("Update Cust_Personal_Info Set Name = '"+tb_Name.Text+"' ,Mobile_No = "+tb_Mob_No.Text+",Alternate_Mon_No = "+tb_Alternate_Mob_No.Text+",Email = '"+tb_Email.Text+"',DOB = '"+dtp_DOB.Text+"',Address = '"+tb_Address.Text+"',AdharCard_No = "+tb_Adhar_No.Text+",PAN_No = '"+tb_PAN_No.Text+"',UserName_Updt = " + UserName + " where ID = " + tb_ID.Text + "", Con);

            DataTable d = new DataTable();

            s.Fill(d);

            MessageBox.Show("Update Successfully..", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con_Close();
        }



        public string UserName { get; set; }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Cust_Personal_Info where ID = " + tb_ID.Text + " ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                tb_Email.Text = obj.GetString(obj.GetOrdinal("Email"));
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                dtp_DOB.Text = (obj["DOB"].ToString());
                tb_Mob_No.Text = (obj["Mobile_No"].ToString());
                tb_Alternate_Mob_No.Text = (obj["Alternate_Mob_No"].ToString());
                tb_Adhar_No.Text = (obj["AdharCard_No"].ToString());
                tb_PAN_No.Text = obj.GetString(obj.GetOrdinal("PAN_No"));

            }
            else
            {
                MessageBox.Show("Invaild ID...");
                tb_ID.Clear();
                tb_ID.Focus();
            }
        }
    }
}
