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
    public partial class Gallary : Form
    {
        int i = 0;
        public Gallary()
        {
            InitializeComponent();
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            i++;

            if (i > 6)
            {
                i = 1;
            }
            changeImage(i);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 6;
            }
            changeImage(i);
        }

        private void changeImage(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.hall1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.hall2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.hall3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.hall4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.hall5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.hall6;
                    break;
                
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
      

    }
}
