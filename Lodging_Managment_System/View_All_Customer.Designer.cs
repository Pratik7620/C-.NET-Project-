namespace Lodging_Managment_System
{
    partial class View_All_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_View_All_Customer = new System.Windows.Forms.DataGridView();
            this.btn_Search_Customer = new System.Windows.Forms.Button();
            this.lodging_Managment_System_DBDataSet10 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet10();
            this.custIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cust_IDTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet10TableAdapters.Cust_IDTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_View_All_Customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custIDBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_View_All_Customer
            // 
            this.dgv_View_All_Customer.AllowUserToAddRows = false;
            this.dgv_View_All_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_All_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Customer.Location = new System.Drawing.Point(29, 145);
            this.dgv_View_All_Customer.Name = "dgv_View_All_Customer";
            this.dgv_View_All_Customer.RowTemplate.Height = 24;
            this.dgv_View_All_Customer.Size = new System.Drawing.Size(1061, 565);
            this.dgv_View_All_Customer.TabIndex = 0;
            // 
            // btn_Search_Customer
            // 
            this.btn_Search_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Search_Customer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Search_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Customer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Search_Customer.Location = new System.Drawing.Point(0, 0);
            this.btn_Search_Customer.Name = "btn_Search_Customer";
            this.btn_Search_Customer.Size = new System.Drawing.Size(246, 55);
            this.btn_Search_Customer.TabIndex = 79;
            this.btn_Search_Customer.Text = "Search Customer";
            this.btn_Search_Customer.UseVisualStyleBackColor = false;
            this.btn_Search_Customer.Click += new System.EventHandler(this.btn_Search_Customer_Click);
            // 
            // lodging_Managment_System_DBDataSet10
            // 
            this.lodging_Managment_System_DBDataSet10.DataSetName = "Lodging_Managment_System_DBDataSet10";
            this.lodging_Managment_System_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custIDBindingSource
            // 
            this.custIDBindingSource.DataMember = "Cust_ID";
            this.custIDBindingSource.DataSource = this.lodging_Managment_System_DBDataSet10;
            // 
            // cust_IDTableAdapter
            // 
            this.cust_IDTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 23);
            this.panel2.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btn_Search_Customer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 55);
            this.panel1.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1057, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_View_All_Customer
            // 
            this.lbl_View_All_Customer.AutoSize = true;
            this.lbl_View_All_Customer.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Customer.Location = new System.Drawing.Point(335, 81);
            this.lbl_View_All_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_View_All_Customer.Name = "lbl_View_All_Customer";
            this.lbl_View_All_Customer.Size = new System.Drawing.Size(274, 35);
            this.lbl_View_All_Customer.TabIndex = 90;
            this.lbl_View_All_Customer.Text = "View All Customer";
            // 
            // View_All_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 757);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_View_All_Customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_View_All_Customer);
            this.Name = "View_All_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_All_Customer";
            this.Load += new System.EventHandler(this.View_All_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custIDBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_All_Customer;
        private System.Windows.Forms.Button btn_Search_Customer;
        private Lodging_Managment_System_DBDataSet10 lodging_Managment_System_DBDataSet10;
        private System.Windows.Forms.BindingSource custIDBindingSource;
        private Lodging_Managment_System_DBDataSet10TableAdapters.Cust_IDTableAdapter cust_IDTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_View_All_Customer;
    }
}