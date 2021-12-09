namespace Lodging_Managment_System
{
    partial class Check_Out
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_Payment_Date = new System.Windows.Forms.DateTimePicker();
            this.lb_Check_Out_Date = new System.Windows.Forms.Label();
            this.btn_Check_Out = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Charge = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cust_ID = new System.Windows.Forms.Label();
            this.tb_Cust_ID = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Room_Bill = new System.Windows.Forms.Label();
            this.tb_Room_Bill = new System.Windows.Forms.TextBox();
            this.lb_Paid = new System.Windows.Forms.Label();
            this.tb_Paid = new System.Windows.Forms.TextBox();
            this.lb_Remaining_Room_Bill = new System.Windows.Forms.Label();
            this.tb_Remaining_Room_Bill = new System.Windows.Forms.TextBox();
            this.lb_Service = new System.Windows.Forms.Label();
            this.tb_Service = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.rServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet21 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet21();
            this.r_ServiceTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet21TableAdapters.R_ServiceTableAdapter();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Room_No = new System.Windows.Forms.TextBox();
            this.lb_Rooms_Info = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet21)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Payment_Date
            // 
            this.dtp_Payment_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Payment_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Payment_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Payment_Date.Location = new System.Drawing.Point(1288, 18);
            this.dtp_Payment_Date.Name = "dtp_Payment_Date";
            this.dtp_Payment_Date.Size = new System.Drawing.Size(230, 34);
            this.dtp_Payment_Date.TabIndex = 17;
            // 
            // lb_Check_Out_Date
            // 
            this.lb_Check_Out_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Check_Out_Date.AutoSize = true;
            this.lb_Check_Out_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Check_Out_Date.Location = new System.Drawing.Point(1090, 21);
            this.lb_Check_Out_Date.Name = "lb_Check_Out_Date";
            this.lb_Check_Out_Date.Size = new System.Drawing.Size(181, 29);
            this.lb_Check_Out_Date.TabIndex = 16;
            this.lb_Check_Out_Date.Text = "Check Out Date";
            // 
            // btn_Check_Out
            // 
            this.btn_Check_Out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Check_Out.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Check_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check_Out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Check_Out.Location = new System.Drawing.Point(440, 14);
            this.btn_Check_Out.Name = "btn_Check_Out";
            this.btn_Check_Out.Size = new System.Drawing.Size(249, 57);
            this.btn_Check_Out.TabIndex = 26;
            this.btn_Check_Out.Text = "Check - Out";
            this.btn_Check_Out.UseVisualStyleBackColor = false;
            this.btn_Check_Out.Click += new System.EventHandler(this.btn_Check_Out_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel2.Controls.Add(this.tb_Charge, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_Check_Out_Date, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_Payment_Date, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 86);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1744, 71);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // tb_Charge
            // 
            this.tb_Charge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_Charge.Enabled = false;
            this.tb_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Charge.Location = new System.Drawing.Point(3, 3);
            this.tb_Charge.Name = "tb_Charge";
            this.tb_Charge.Size = new System.Drawing.Size(16, 34);
            this.tb_Charge.TabIndex = 91;
            this.tb_Charge.Visible = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Enter.Location = new System.Drawing.Point(756, 3);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(110, 57);
            this.btn_Enter.TabIndex = 27;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Check_Out, 0, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 808);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1761, 86);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.67064F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Enter, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cust_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cust_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Room_Bill, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Room_Bill, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Paid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Paid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Remaining_Room_Bill, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Remaining_Room_Bill, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Service, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Service, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Total, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Total, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 549);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // lb_Cust_ID
            // 
            this.lb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Cust_ID.AutoSize = true;
            this.lb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cust_ID.Location = new System.Drawing.Point(82, 0);
            this.lb_Cust_ID.Name = "lb_Cust_ID";
            this.lb_Cust_ID.Size = new System.Drawing.Size(121, 29);
            this.lb_Cust_ID.TabIndex = 76;
            this.lb_Cust_ID.Text = "Cust_ID    ";
            // 
            // tb_Cust_ID
            // 
            this.tb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_ID.Location = new System.Drawing.Point(209, 3);
            this.tb_Cust_ID.Name = "tb_Cust_ID";
            this.tb_Cust_ID.Size = new System.Drawing.Size(283, 34);
            this.tb_Cust_ID.TabIndex = 75;
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(101, 137);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(102, 29);
            this.lb_Name.TabIndex = 77;
            this.lb_Name.Text = "Name    ";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(209, 140);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(283, 34);
            this.tb_Name.TabIndex = 78;
            // 
            // lb_Room_Bill
            // 
            this.lb_Room_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Room_Bill.AutoSize = true;
            this.lb_Room_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Room_Bill.Location = new System.Drawing.Point(620, 137);
            this.lb_Room_Bill.Name = "lb_Room_Bill";
            this.lb_Room_Bill.Size = new System.Drawing.Size(130, 29);
            this.lb_Room_Bill.TabIndex = 80;
            this.lb_Room_Bill.Text = "Room Bill  ";
            // 
            // tb_Room_Bill
            // 
            this.tb_Room_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Room_Bill.Enabled = false;
            this.tb_Room_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Room_Bill.Location = new System.Drawing.Point(756, 140);
            this.tb_Room_Bill.Name = "tb_Room_Bill";
            this.tb_Room_Bill.Size = new System.Drawing.Size(249, 34);
            this.tb_Room_Bill.TabIndex = 81;
            // 
            // lb_Paid
            // 
            this.lb_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Paid.AutoSize = true;
            this.lb_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Paid.Location = new System.Drawing.Point(99, 274);
            this.lb_Paid.Name = "lb_Paid";
            this.lb_Paid.Size = new System.Drawing.Size(104, 29);
            this.lb_Paid.TabIndex = 86;
            this.lb_Paid.Text = "Paid       ";
            // 
            // tb_Paid
            // 
            this.tb_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Paid.Enabled = false;
            this.tb_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid.Location = new System.Drawing.Point(209, 277);
            this.tb_Paid.Name = "tb_Paid";
            this.tb_Paid.Size = new System.Drawing.Size(283, 34);
            this.tb_Paid.TabIndex = 87;
            // 
            // lb_Remaining_Room_Bill
            // 
            this.lb_Remaining_Room_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Remaining_Room_Bill.AutoSize = true;
            this.lb_Remaining_Room_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Remaining_Room_Bill.Location = new System.Drawing.Point(498, 274);
            this.lb_Remaining_Room_Bill.Name = "lb_Remaining_Room_Bill";
            this.lb_Remaining_Room_Bill.Size = new System.Drawing.Size(252, 29);
            this.lb_Remaining_Room_Bill.TabIndex = 84;
            this.lb_Remaining_Room_Bill.Text = "Remaining Room  Bill ";
            // 
            // tb_Remaining_Room_Bill
            // 
            this.tb_Remaining_Room_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Remaining_Room_Bill.Enabled = false;
            this.tb_Remaining_Room_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining_Room_Bill.Location = new System.Drawing.Point(756, 277);
            this.tb_Remaining_Room_Bill.Name = "tb_Remaining_Room_Bill";
            this.tb_Remaining_Room_Bill.Size = new System.Drawing.Size(249, 34);
            this.tb_Remaining_Room_Bill.TabIndex = 85;
            // 
            // lb_Service
            // 
            this.lb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Service.AutoSize = true;
            this.lb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Service.Location = new System.Drawing.Point(73, 411);
            this.lb_Service.Name = "lb_Service";
            this.lb_Service.Size = new System.Drawing.Size(130, 29);
            this.lb_Service.TabIndex = 64;
            this.lb_Service.Text = "Service      ";
            // 
            // tb_Service
            // 
            this.tb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Service.Enabled = false;
            this.tb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Service.Location = new System.Drawing.Point(209, 414);
            this.tb_Service.Name = "tb_Service";
            this.tb_Service.Size = new System.Drawing.Size(283, 34);
            this.tb_Service.TabIndex = 79;
            this.tb_Service.TextChanged += new System.EventHandler(this.tb_Service_TextChanged);
            // 
            // lb_Total
            // 
            this.lb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(646, 411);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(104, 29);
            this.lb_Total.TabIndex = 91;
            this.lb_Total.Text = "Total      ";
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(756, 414);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(249, 34);
            this.tb_Total.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1788, 55);
            this.panel1.TabIndex = 88;
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
            this.button1.Location = new System.Drawing.Point(1728, 0);
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
            this.panel2.Location = new System.Drawing.Point(0, 940);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1788, 23);
            this.panel2.TabIndex = 89;
            // 
            // dgv_Rooms
            // 
            this.dgv_Rooms.AllowUserToAddRows = false;
            this.dgv_Rooms.AllowUserToDeleteRows = false;
            this.dgv_Rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rooms.Location = new System.Drawing.Point(3, 88);
            this.dgv_Rooms.Name = "dgv_Rooms";
            this.dgv_Rooms.ReadOnly = true;
            this.dgv_Rooms.RowTemplate.Height = 24;
            this.dgv_Rooms.Size = new System.Drawing.Size(661, 290);
            this.dgv_Rooms.TabIndex = 90;
            // 
            // rServiceBindingSource
            // 
            this.rServiceBindingSource.DataMember = "R_Service";
            this.rServiceBindingSource.DataSource = this.lodging_Managment_System_DBDataSet21;
            // 
            // lodging_Managment_System_DBDataSet21
            // 
            this.lodging_Managment_System_DBDataSet21.DataSetName = "Lodging_Managment_System_DBDataSet21";
            this.lodging_Managment_System_DBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r_ServiceTableAdapter
            // 
            this.r_ServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lb_Rooms_Info, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tb_Room_No, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.dgv_Rooms, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1098, 251);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.31948F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.68053F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(667, 514);
            this.tableLayoutPanel4.TabIndex = 92;
            // 
            // tb_Room_No
            // 
            this.tb_Room_No.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_Room_No.Enabled = false;
            this.tb_Room_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Room_No.Location = new System.Drawing.Point(3, 384);
            this.tb_Room_No.Name = "tb_Room_No";
            this.tb_Room_No.Size = new System.Drawing.Size(15, 34);
            this.tb_Room_No.TabIndex = 91;
            this.tb_Room_No.Visible = false;
            // 
            // lb_Rooms_Info
            // 
            this.lb_Rooms_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Rooms_Info.AutoSize = true;
            this.lb_Rooms_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rooms_Info.Location = new System.Drawing.Point(217, 28);
            this.lb_Rooms_Info.Name = "lb_Rooms_Info";
            this.lb_Rooms_Info.Size = new System.Drawing.Size(232, 29);
            this.lb_Rooms_Info.TabIndex = 93;
            this.lb_Rooms_Info.Text = "Rooms Information";
            // 
            // Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1788, 963);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Check_Out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_Out";
            this.Load += new System.EventHandler(this.Check_Out_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet21)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Payment_Date;
        private System.Windows.Forms.Label lb_Check_Out_Date;
        private System.Windows.Forms.Button btn_Check_Out;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_Cust_ID;
        private System.Windows.Forms.Label lb_Cust_ID;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Service;
        private System.Windows.Forms.TextBox tb_Service;
        private System.Windows.Forms.Label lb_Room_Bill;
        private System.Windows.Forms.TextBox tb_Room_Bill;
        private System.Windows.Forms.Label lb_Remaining_Room_Bill;
        private System.Windows.Forms.TextBox tb_Remaining_Room_Bill;
        private System.Windows.Forms.Label lb_Paid;
        private System.Windows.Forms.TextBox tb_Paid;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Rooms;
        private Lodging_Managment_System_DBDataSet21 lodging_Managment_System_DBDataSet21;
        private System.Windows.Forms.BindingSource rServiceBindingSource;
        private Lodging_Managment_System_DBDataSet21TableAdapters.R_ServiceTableAdapter r_ServiceTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_Charge;
        private System.Windows.Forms.Label lb_Rooms_Info;
        private System.Windows.Forms.TextBox tb_Room_No;
    }
}