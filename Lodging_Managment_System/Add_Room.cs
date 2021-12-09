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
    public partial class Add_Room : Form
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

        public Add_Room()
        {
            InitializeComponent();
        }

        public void ClearData()
        {
            tb_Room_No.Clear();
            tb_Amount_Day.Clear();
            tb_Room_Specification.Clear();
            cb_Bed_Type.SelectedIndex = -1;
            cb_Room_Type.SelectedIndex = -1;

        }

        private void btn_View_All_Rooms_Click_1(object sender, EventArgs e)
        {
            View_All_Rooms obj = new View_All_Rooms();

            obj.MdiParent = this.MdiParent;
       
            obj.Show();
            this.Close();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            Con.Open();


            if (tb_Room_No.Text != "" && cb_Room_Type.Text != "" && cb_Bed_Type.Text != "" && tb_Amount_Day.Text != "")
            {
                UserName = Global_Login.U_Name;

                SqlDataAdapter sda = new SqlDataAdapter("Insert into Rooms(RoomNo,RoomType,BedType,Amount_Day,Specification,UserName,Per_Hrs) values( " + tb_Room_No.Text + " , '" + cb_Room_Type.Text + "' , '" + cb_Bed_Type.Text + "' , " + tb_Amount_Day.Text + " , '" + tb_Room_Specification.Text + "' ,'" + UserName + "'," + tb_Per_Hrs.Text + ") ", Con);

                DataTable dt = new DataTable();
              

                sda.Fill(dt);


                MessageBox.Show("\t Add Room Succesfully \t");

                ClearData();
                tb_Room_No.Text = Convert.ToString(Auto_Incr());

            }
            else
            {
                MessageBox.Show(" Please Filled All Fields");
            }

            Con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update_Rooms obj = new Update_Rooms();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }


        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(RoomNo) From  Rooms", Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 101 + Cnt;

            Con_Close();

            return Cnt;
        }


        public string UserName { get; set; }

        private void Add_Room_Load(object sender, EventArgs e)
        {
            tb_Room_No.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
