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
    public partial class Pay_Amount : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");
        private double val;
   
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

        public Pay_Amount()
        {
            InitializeComponent();            
            
        }

        public Pay_Amount(double val)
        {
            InitializeComponent(); 
            // TODO: Complete member initialization
            tb_Room_Bill.Text = val.ToString();
        }

        int Auto_Incr1()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Cust_ID) From  Cust_Personal_Info", Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1001 + Cnt - 1;

            Con_Close();

            return Cnt;
        }
       
        private void Pay_Amount_Load(object sender, EventArgs e)
        {
           
            tb_Cust_ID.Text = Convert.ToString(Auto_Incr1());
            
            
        }

      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Room_Bill.Text != "")
            {
                double val = double.Parse(tb_Total.Text) / 2;
                double Money = double.Parse(tb_Pay.Text);

                if (val <= Money)
                {
                    UserName = Global_Login.U_Name;
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Pay_Amount(Cust_ID,Room_Bill,Discount,Total,Pay,Remaining,UserName) values(" + tb_Cust_ID.Text + "," + tb_Room_Bill.Text + " , " + tb_Discount.Text + " , " + tb_Total.Text + " , " + tb_Pay.Text + " , " + tb_Remaining.Text + " ,'" + UserName + "')", Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("Booking Succesfull !!");

                    tb_Pay.Clear();
                    tb_Remaining.Clear();
                    tb_Room_Bill.Clear();
                    tb_Total.Clear();
                    tb_Discount.Clear();
              
                }
                else
                {
                    MessageBox.Show("Pay Minimum 50% value ");
                    tb_Pay.Clear();
                    tb_Remaining.Clear();
                }

            }
            else
            {
                MessageBox.Show(" Please Filled All Fields");
            }

        }

        private void btn_Add_Room_Click(object sender, EventArgs e)
        {
            Booking_Next obj = new Booking_Next();
            obj.MdiParent = this.MdiParent;
            obj.Show();

        }

        public string UserName { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double Pay { get; set; }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            double Rprice = 0;
            double Discount, Total, TPrice = 0;

            Rprice = double.Parse(tb_Room_Bill.Text);
            Discount = double.Parse(tb_Discount.Text);

            Total = Rprice * (Discount / 100);
            TPrice = Rprice - Total;

            tb_Total.Text = TPrice.ToString();
        }

        private void btn_Remaining_Bill_Click(object sender, EventArgs e)
        {
             double a = double.Parse(tb_Total.Text);
             double b = double.Parse(tb_Pay.Text);
           
             tb_Remaining.Text = Convert.ToString(a - b);
        }

       

       
    }
}
