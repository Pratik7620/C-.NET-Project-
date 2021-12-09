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
   
    public partial class frm_Booking1 : Form    
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");

        public frm_Booking1()
        {
            InitializeComponent();
        }

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

        public void ClearData()
        {
            tb_Name.Clear();
            tb_Mob_No.Clear();
            tb_Alternative_Mob_No.Clear();
            tb_Email.Clear();
            tb_Address.Clear();
            tb_Adhar_No.Clear();
            tb_PAN_No.Clear();
        }


        public string key { get; set; }

        private void frm_Booking1_Load(object sender, EventArgs e)
        {
            tb_Cust_ID.Text = Convert.ToString(Auto_Incr1());
            
        }
        int Auto_Incr1()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Cust_ID) From  Cust_Personal_Info", Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1001 + Cnt ;

            Con_Close();

            return Cnt;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Insert into Cust_Personal_Info(Cust_ID,Name,Booking_Date,Mobile_Number,Alternate_Mob_No,Email,DOB,Address,AdharCard_No,PAN_No) values(" + tb_Cust_ID.Text + ",'" + tb_Name.Text + "','" + dtp_Booking_Date.Text + "'," + tb_Mob_No.Text + "," + tb_Alternative_Mob_No.Text + ",'" + tb_Email.Text + "','" + dtp_DOB.Text + "','" + tb_Address.Text + "'," + tb_Adhar_No.Text + ",'" + tb_PAN_No.Text + "')", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            MessageBox.Show("Succesfull");

            ClearData();

            Booking_Next obj = new Booking_Next();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();

            Con.Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_AlphNumeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit (e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update_Customer_Details obj = new Update_Customer_Details();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();
           
        }
    }
}
