namespace Lodging_Managment_System
{
    partial class Search_Customer
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
            this.dgv_Search_Customer = new System.Windows.Forms.DataGridView();
            this.lb_Search = new System.Windows.Forms.Label();
            this.btn_ID = new System.Windows.Forms.Button();
            this.btn_Name = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tlp_ID = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Customer_ID = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.btn_Search_ID = new System.Windows.Forms.Button();
            this.tlp_Name = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Search_Name = new System.Windows.Forms.TextBox();
            this.btn_Search_Name = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Search_Customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Customer)).BeginInit();
            this.tlp_ID.SuspendLayout();
            this.tlp_Name.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Search_Customer
            // 
            this.dgv_Search_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search_Customer.Location = new System.Drawing.Point(28, 485);
            this.dgv_Search_Customer.Name = "dgv_Search_Customer";
            this.dgv_Search_Customer.RowTemplate.Height = 24;
            this.dgv_Search_Customer.Size = new System.Drawing.Size(1206, 307);
            this.dgv_Search_Customer.TabIndex = 0;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(55, 205);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(134, 29);
            this.lb_Search.TabIndex = 6;
            this.lb_Search.Text = "Search By :";
            // 
            // btn_ID
            // 
            this.btn_ID.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ID.Location = new System.Drawing.Point(298, 205);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(162, 39);
            this.btn_ID.TabIndex = 7;
            this.btn_ID.Text = "ID";
            this.btn_ID.UseVisualStyleBackColor = false;
            this.btn_ID.Click += new System.EventHandler(this.btn_ID_Click);
            // 
            // btn_Name
            // 
            this.btn_Name.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Name.Location = new System.Drawing.Point(298, 267);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Size = new System.Drawing.Size(162, 39);
            this.btn_Name.TabIndex = 8;
            this.btn_Name.Text = "Name";
            this.btn_Name.UseVisualStyleBackColor = false;
            this.btn_Name.Click += new System.EventHandler(this.btn_Name_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(173, 55);
            this.btn_Back.TabIndex = 78;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_View_All_Customer_Click);
            // 
            // tlp_ID
            // 
            this.tlp_ID.ColumnCount = 3;
            this.tlp_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54155F));
            this.tlp_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35761F));
            this.tlp_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.19421F));
            this.tlp_ID.Controls.Add(this.lb_Customer_ID, 0, 0);
            this.tlp_ID.Controls.Add(this.tb_Customer_ID, 1, 0);
            this.tlp_ID.Controls.Add(this.btn_Search_ID, 2, 0);
            this.tlp_ID.Location = new System.Drawing.Point(28, 394);
            this.tlp_ID.Name = "tlp_ID";
            this.tlp_ID.RowCount = 1;
            this.tlp_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ID.Size = new System.Drawing.Size(1206, 62);
            this.tlp_ID.TabIndex = 10;
            this.tlp_ID.Visible = false;
            // 
            // lb_Customer_ID
            // 
            this.lb_Customer_ID.AutoSize = true;
            this.lb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Customer_ID.Location = new System.Drawing.Point(3, 0);
            this.lb_Customer_ID.Name = "lb_Customer_ID";
            this.lb_Customer_ID.Size = new System.Drawing.Size(158, 29);
            this.lb_Customer_ID.TabIndex = 2;
            this.lb_Customer_ID.Text = "Customer ID :";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(250, 3);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(323, 34);
            this.tb_Customer_ID.TabIndex = 3;
            // 
            // btn_Search_ID
            // 
            this.btn_Search_ID.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search_ID.Location = new System.Drawing.Point(579, 3);
            this.btn_Search_ID.Name = "btn_Search_ID";
            this.btn_Search_ID.Size = new System.Drawing.Size(273, 56);
            this.btn_Search_ID.TabIndex = 80;
            this.btn_Search_ID.Text = "Search ";
            this.btn_Search_ID.UseVisualStyleBackColor = false;
            this.btn_Search_ID.Click += new System.EventHandler(this.btn_Search_ID_Click);
            // 
            // tlp_Name
            // 
            this.tlp_Name.ColumnCount = 3;
            this.tlp_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35481F));
            this.tlp_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35761F));
            this.tlp_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.28758F));
            this.tlp_Name.Controls.Add(this.lb_Customer_Name, 0, 0);
            this.tlp_Name.Controls.Add(this.tb_Search_Name, 1, 0);
            this.tlp_Name.Controls.Add(this.btn_Search_Name, 2, 0);
            this.tlp_Name.Location = new System.Drawing.Point(28, 391);
            this.tlp_Name.Name = "tlp_Name";
            this.tlp_Name.RowCount = 1;
            this.tlp_Name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Name.Size = new System.Drawing.Size(1206, 62);
            this.tlp_Name.TabIndex = 11;
            this.tlp_Name.Visible = false;
            // 
            // lb_Customer_Name
            // 
            this.lb_Customer_Name.AutoSize = true;
            this.lb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Customer_Name.Location = new System.Drawing.Point(3, 0);
            this.lb_Customer_Name.Name = "lb_Customer_Name";
            this.lb_Customer_Name.Size = new System.Drawing.Size(194, 29);
            this.lb_Customer_Name.TabIndex = 2;
            this.lb_Customer_Name.Text = "Customer Name:";
            // 
            // tb_Search_Name
            // 
            this.tb_Search_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search_Name.Location = new System.Drawing.Point(248, 3);
            this.tb_Search_Name.Name = "tb_Search_Name";
            this.tb_Search_Name.Size = new System.Drawing.Size(323, 34);
            this.tb_Search_Name.TabIndex = 3;
            // 
            // btn_Search_Name
            // 
            this.btn_Search_Name.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search_Name.Location = new System.Drawing.Point(577, 3);
            this.btn_Search_Name.Name = "btn_Search_Name";
            this.btn_Search_Name.Size = new System.Drawing.Size(274, 49);
            this.btn_Search_Name.TabIndex = 9;
            this.btn_Search_Name.Text = "Search";
            this.btn_Search_Name.UseVisualStyleBackColor = false;
            this.btn_Search_Name.Click += new System.EventHandler(this.btn_Search_Name_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 812);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 23);
            this.panel2.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 55);
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
            this.button1.Location = new System.Drawing.Point(1199, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Search_Customer
            // 
            this.lbl_Search_Customer.AutoSize = true;
            this.lbl_Search_Customer.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.lbl_Search_Customer.Location = new System.Drawing.Point(494, 99);
            this.lbl_Search_Customer.Name = "lbl_Search_Customer";
            this.lbl_Search_Customer.Size = new System.Drawing.Size(244, 35);
            this.lbl_Search_Customer.TabIndex = 90;
            this.lbl_Search_Customer.Text = "Search Customer";
            // 
            // Search_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 835);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Search_Customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tlp_Name);
            this.Controls.Add(this.tlp_ID);
            this.Controls.Add(this.btn_Name);
            this.Controls.Add(this.btn_ID);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.dgv_Search_Customer);
            this.Name = "Search_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Customer";
            this.Load += new System.EventHandler(this.Search_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Customer)).EndInit();
            this.tlp_ID.ResumeLayout(false);
            this.tlp_ID.PerformLayout();
            this.tlp_Name.ResumeLayout(false);
            this.tlp_Name.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Search_Customer;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button btn_ID;
        private System.Windows.Forms.Button btn_Name;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TableLayoutPanel tlp_ID;
        private System.Windows.Forms.Label lb_Customer_ID;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Button btn_Search_ID;
        private System.Windows.Forms.TableLayoutPanel tlp_Name;
        private System.Windows.Forms.Label lb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Search_Name;
        private System.Windows.Forms.Button btn_Search_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Search_Customer;
    }
}