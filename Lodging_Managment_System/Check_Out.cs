using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Lodging_Managment_System
{
    public partial class Check_Out : Form
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


        public Check_Out()
        {
            InitializeComponent();
        }

       
        public Check_Out(double Service_Charge)
        {
            InitializeComponent();
            // TODO: Complete member initialization
           tb_Service.Text = Service_Charge.ToString();
        }

        private void btn_Check_Out_Click(object sender, EventArgs e)
        {
            Con.Open();
            UserName = Global_Login.U_Name;
            if (tb_Service.Text != "")
            {
               

                SqlDataAdapter sda = new SqlDataAdapter("Insert into Check_Out values(" + tb_Cust_ID.Text + ",'" + tb_Name.Text + "'," + tb_Service.Text + "," + tb_Room_Bill.Text + "," + tb_Remaining_Room_Bill.Text + "," + tb_Paid.Text + "," + tb_Total.Text + ", '" + UserName + "') ", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("Successfully Check-Out");

            }
            else
            {
                

                SqlDataAdapter sda = new SqlDataAdapter("Insert into Check_Out(ID,Name,Room_Bill,Remaining_Room_Bill,Paid,Total,UserName) values(" + tb_Cust_ID.Text + ",'" + tb_Name.Text + "'," + tb_Room_Bill.Text + "," + tb_Remaining_Room_Bill.Text + "," + tb_Paid.Text + "," + tb_Total.Text + " , '" + UserName + "') ", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
               
            }

            Reset();

            MessageBox.Show(" Check-Out Successfully");

           
            tb_Cust_ID.Text = "";
            tb_Name.Text = "";
            tb_Paid.Text = "";
            tb_Remaining_Room_Bill.Text = "";
            tb_Room_Bill.Text = "";
            tb_Service.Text = "";
            tb_Total.Text = "";
            tb_Cust_ID.Focus();

            Con_Close();
            
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            
            Nm();
            Room_Bill();
            Service();
            Room_Info();

           

        }

        public void Nm()
        {
            Con.Open();

            SqlCommand cm = new SqlCommand("select *From Cust_Personal_Info where Cust_ID = " + tb_Cust_ID.Text + "", Con);

            var obj1 = cm.ExecuteReader();

            if (obj1.Read())
            {
                tb_Name.Text = obj1.GetString(obj1.GetOrdinal("Name"));

            }
            else
            {
                MessageBox.Show("Inavlid ID");

            }

            Con.Close();
        }

        public void Room_Bill()
        {
            Con.Open();

            SqlCommand cm = new SqlCommand("select *From Pay_Amount where Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            var obj1 = cm.ExecuteReader();

            if (obj1.Read())
            {
                tb_Room_Bill.Text = (obj1["Total"].ToString());
                tb_Paid.Text = (obj1["Pay"].ToString());
                tb_Remaining_Room_Bill.Text = (obj1["Remaining"].ToString());
      
            }
            else
            {
                MessageBox.Show("Inavlid ID");

            }

            Con.Close();
        }


        public void Service()
        {
            Con.Open();

            double R_charge = 0;

            SqlCommand cm = new SqlCommand("select *From R_Service where Cust_ID = " + tb_Cust_ID.Text + "", Con);

            var obj1 = cm.ExecuteReader();


            while (obj1.Read())
            {
                tb_Charge.Text = (obj1["Charge"].ToString());
                double charge = Convert.ToDouble(tb_Charge.Text);
                R_charge = R_charge + charge;
            }
            tb_Service.Text = R_charge.ToString();
           
            Con_Close();
        }

        public void Reset()
        {
            Con_Open();

            
            SqlCommand cm = new SqlCommand("select * From Cust_Booking_Room_Info where Cust_ID = " + tb_Cust_ID.Text + "", Con);

            var obj1 = cm.ExecuteReader();

            ArrayList Al = new ArrayList();

            while (obj1.Read())
            {
                
                tb_Room_No.Text = (obj1["Room_No"].ToString());
                Al.Add(tb_Room_No.Text);

            }
            obj1.Close();
         
            foreach (object o in Al)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update Rooms Set Reserve = 'NO'  ", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

            }

            Con_Close();

        }

        public void Room_Info()
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From  Cust_Booking_Room_Info where Cust_ID = " + tb_Cust_ID.Text + "  ", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Rooms.DataSource = dt;

            Con_Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string UserName { get; set; }

        private void Check_Out_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet21.R_Service' table. You can move, or remove it, as needed.
           // this.r_ServiceTableAdapter.Fill(this.lodging_Managment_System_DBDataSet21.R_Service);

        }

        private void tb_Service_TextChanged(object sender, EventArgs e)
        {
            if (tb_Service.Text != "")
            {
                double a = double.Parse(tb_Remaining_Room_Bill.Text);
                double b = double.Parse(tb_Service.Text);
                tb_Total.Text = Convert.ToString(a + b);
            }
            else
            {
                tb_Total.Text = tb_Remaining_Room_Bill.Text;
            }
        }

        //private void btn_Service_charge_Click(object sender, EventArgs e)
        //{
        //    tb_Service.Text = "0";

        //    for (int i = 0; i < dgv_Service.Rows.Count; i++)
        //    {
        //        tb_Service.Text = Convert.ToString(double.Parse(tb_Service.Text) + double.Parse(dgv_Service.Rows[i].Cells[4].Value.ToString()));
        //    }
        //}

        //private void tb_Service_TextChanged(object sender, EventArgs e)
        //{
        //    if (tb_Service.Text != "")
        //    {
        //        double a = double.Parse(tb_Remaining.Text);
        //        double b = double.Parse(tb_Service.Text);
        //        tb_Total.Text = Convert.ToString(a + b);
        //    }
        //    else
        //    {
        //        tb_Total.Text = tb_Remaining.Text;
        //    }
           
        //}
    }
}
