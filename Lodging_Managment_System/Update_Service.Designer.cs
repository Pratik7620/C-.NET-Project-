﻿namespace Lodging_Managment_System
{
    partial class Update_Service
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
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add_To_Bill = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.rServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet16 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet16();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.r_ServiceTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet16TableAdapters.R_ServiceTableAdapter();
            this.tb_Charge = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Service = new System.Windows.Forms.ComboBox();
            this.lb_Charge = new System.Windows.Forms.Label();
            this.lb_Service = new System.Windows.Forms.Label();
            this.lb_Cust_ID = new System.Windows.Forms.Label();
            this.tb_Cust_ID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet16)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(778, 9);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(227, 34);
            this.dtp_Date.TabIndex = 17;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(115, 55);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.03257F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.96743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Date, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 53);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // lb_Date
            // 
            this.lb_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(661, 12);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(63, 29);
            this.lb_Date.TabIndex = 16;
            this.lb_Date.Text = "Date";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Add_To_Bill, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 452);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1005, 91);
            this.tableLayoutPanel3.TabIndex = 92;
            // 
            // btn_Add_To_Bill
            // 
            this.btn_Add_To_Bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add_To_Bill.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Add_To_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_To_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_To_Bill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add_To_Bill.Location = new System.Drawing.Point(412, 14);
            this.btn_Add_To_Bill.Name = "btn_Add_To_Bill";
            this.btn_Add_To_Bill.Size = new System.Drawing.Size(181, 62);
            this.btn_Add_To_Bill.TabIndex = 5;
            this.btn_Add_To_Bill.Text = "Add To Bill";
            this.btn_Add_To_Bill.UseVisualStyleBackColor = false;
            this.btn_Add_To_Bill.Click += new System.EventHandler(this.btn_Add_To_Bill_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(599, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(181, 50);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // rServiceBindingSource
            // 
            this.rServiceBindingSource.DataMember = "R_Service";
            this.rServiceBindingSource.DataSource = this.lodging_Managment_System_DBDataSet16;
            // 
            // lodging_Managment_System_DBDataSet16
            // 
            this.lodging_Managment_System_DBDataSet16.DataSetName = "Lodging_Managment_System_DBDataSet16";
            this.lodging_Managment_System_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 55);
            this.panel1.TabIndex = 94;
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
            this.button1.Location = new System.Drawing.Point(993, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 23);
            this.panel2.TabIndex = 93;
            // 
            // r_ServiceTableAdapter
            // 
            this.r_ServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tb_Charge
            // 
            this.tb_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Charge.Location = new System.Drawing.Point(599, 176);
            this.tb_Charge.Name = "tb_Charge";
            this.tb_Charge.Size = new System.Drawing.Size(236, 34);
            this.tb_Charge.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89706F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.57353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.73039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79902F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.Controls.Add(this.cb_Service, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Charge, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Charge, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_Service, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cust_ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cust_ID, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.58396F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.08271F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 262);
            this.tableLayoutPanel2.TabIndex = 90;
            // 
            // cb_Service
            // 
            this.cb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Service.FormattingEnabled = true;
            this.cb_Service.Items.AddRange(new object[] {
            "Laundry",
            "Room Cleaning"});
            this.cb_Service.Location = new System.Drawing.Point(203, 176);
            this.cb_Service.Name = "cb_Service";
            this.cb_Service.Size = new System.Drawing.Size(225, 37);
            this.cb_Service.TabIndex = 3;
            // 
            // lb_Charge
            // 
            this.lb_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Charge.AutoSize = true;
            this.lb_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Charge.Location = new System.Drawing.Point(501, 173);
            this.lb_Charge.Name = "lb_Charge";
            this.lb_Charge.Size = new System.Drawing.Size(92, 29);
            this.lb_Charge.TabIndex = 20;
            this.lb_Charge.Text = "Charge";
            // 
            // lb_Service
            // 
            this.lb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Service.AutoSize = true;
            this.lb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Service.Location = new System.Drawing.Point(61, 173);
            this.lb_Service.Name = "lb_Service";
            this.lb_Service.Size = new System.Drawing.Size(136, 29);
            this.lb_Service.TabIndex = 18;
            this.lb_Service.Text = "Service       ";
            // 
            // lb_Cust_ID
            // 
            this.lb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Cust_ID.AutoSize = true;
            this.lb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cust_ID.Location = new System.Drawing.Point(4, 0);
            this.lb_Cust_ID.Name = "lb_Cust_ID";
            this.lb_Cust_ID.Size = new System.Drawing.Size(193, 29);
            this.lb_Cust_ID.TabIndex = 12;
            this.lb_Cust_ID.Text = "Cust_ID                ";
            // 
            // tb_Cust_ID
            // 
            this.tb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_ID.Location = new System.Drawing.Point(203, 3);
            this.tb_Cust_ID.Name = "tb_Cust_ID";
            this.tb_Cust_ID.Size = new System.Drawing.Size(225, 34);
            this.tb_Cust_ID.TabIndex = 13;
            // 
            // Update_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 588);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Update_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Service";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Add_To_Bill;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.BindingSource rServiceBindingSource;
        private Lodging_Managment_System_DBDataSet16 lodging_Managment_System_DBDataSet16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Lodging_Managment_System_DBDataSet16TableAdapters.R_ServiceTableAdapter r_ServiceTableAdapter;
        private System.Windows.Forms.TextBox tb_Charge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_Service;
        private System.Windows.Forms.Label lb_Charge;
        private System.Windows.Forms.TextBox tb_Cust_ID;
        private System.Windows.Forms.Label lb_Cust_ID;
        private System.Windows.Forms.Label lb_Service;
    }
}