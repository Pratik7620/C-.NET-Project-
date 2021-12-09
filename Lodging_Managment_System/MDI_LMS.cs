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
    public partial class MDI_LMS : Form
    {
        private int childFormNumber = 0;

        public MDI_LMS()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btn_Customer_Resistration_Click(object sender, EventArgs e)
        {
            frm_Booking1 obj = new frm_Booking1();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

            //Pay_Amount obj = new Pay_Amount();
            //obj.MdiParent = this;
            //obj.WindowState = FormWindowState.Maximized;
            //obj.Show();
            
        }

        private void btn_Check_Out_Click(object sender, EventArgs e)
        {
            
            Check_Out obj = new Check_Out();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            Add_Room obj = new Add_Room();

            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee obj = new Add_Employee();

            obj.MdiParent = this.MdiParent;
           // obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            View_All_Customer obj = new View_All_Customer();

            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void btn_Gallary_Click(object sender, EventArgs e)
        {
            Gallary obj = new Gallary();

            obj.MdiParent = this.MdiParent;
         
            obj.Show();
        }

        private void btn_Services_Click(object sender, EventArgs e)
        {
            Service obj = new Service();

            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void MDI_LMS_Load(object sender, EventArgs e)
        {
            lb_UserName.Text = " Welcome " + Global_Login.U_Name;

            if (Global_Login.User_Role == 0)
            {
               //btn_Employee.Visible = false;
            }
           
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
