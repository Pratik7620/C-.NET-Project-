using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lodging_Managment_System
{
    public partial class View_All_Rooms : Form
    {
        public View_All_Rooms()
        {
            InitializeComponent();
        }

       

        private void btn_Add_Room_Click(object sender, EventArgs e)
        {
            Add_Room obj = new Add_Room();

            obj.MdiParent = this.MdiParent;
           
            obj.Show();
            this.Close();
        }

        private void View_All_Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet19.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter2.Fill(this.lodging_Managment_System_DBDataSet19.Rooms);
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet11.Rooms' table. You can move, or remove it, as needed.
            //this.roomsTableAdapter1.Fill(this.lodging_Managment_System_DBDataSet11.Rooms);

        }
    }
}
