namespace Lodging_Managment_System
{
    partial class View_Remove_Employee
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
            this.dgv_Employee_Delete = new System.Windows.Forms.DataGridView();
            this.tb_Emp_Id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Emp_Id = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_View_Remove_Employee = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lodging_Managment_System_DBDataSet18 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet18();
            this.deletedEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleted_EmpTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet18TableAdapters.Deleted_EmpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Delete)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedEmpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee_Delete
            // 
            this.dgv_Employee_Delete.AllowUserToAddRows = false;
            this.dgv_Employee_Delete.AllowUserToDeleteRows = false;
            this.dgv_Employee_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Employee_Delete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_Delete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_Delete.Location = new System.Drawing.Point(34, 234);
            this.dgv_Employee_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Employee_Delete.Name = "dgv_Employee_Delete";
            this.dgv_Employee_Delete.ReadOnly = true;
            this.dgv_Employee_Delete.Size = new System.Drawing.Size(1165, 499);
            this.dgv_Employee_Delete.TabIndex = 14;
            // 
            // tb_Emp_Id
            // 
            this.tb_Emp_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Emp_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Id.Location = new System.Drawing.Point(295, 4);
            this.tb_Emp_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Emp_Id.Name = "tb_Emp_Id";
            this.tb_Emp_Id.Size = new System.Drawing.Size(283, 30);
            this.tb_Emp_Id.TabIndex = 1;
            this.tb_Emp_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(667, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 44);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Emp_Id
            // 
            this.lbl_Emp_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Emp_Id.AutoSize = true;
            this.lbl_Emp_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Id.Location = new System.Drawing.Point(121, 0);
            this.lbl_Emp_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Emp_Id.Name = "lbl_Emp_Id";
            this.lbl_Emp_Id.Size = new System.Drawing.Size(166, 29);
            this.lbl_Emp_Id.TabIndex = 10;
            this.lbl_Emp_Id.Text = "Employee Id   ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Emp_Id, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Emp_Id, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 69);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(958, 4);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(121, 44);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.Location = new System.Drawing.Point(0, -4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 59);
            this.btn_Back.TabIndex = 79;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 55);
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
            this.button1.Location = new System.Drawing.Point(1171, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_View_Remove_Employee
            // 
            this.lbl_View_Remove_Employee.AutoSize = true;
            this.lbl_View_Remove_Employee.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Remove_Employee.Location = new System.Drawing.Point(404, 81);
            this.lbl_View_Remove_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_View_Remove_Employee.Name = "lbl_View_Remove_Employee";
            this.lbl_View_Remove_Employee.Size = new System.Drawing.Size(344, 35);
            this.lbl_View_Remove_Employee.TabIndex = 89;
            this.lbl_View_Remove_Employee.Text = "View Remove Employee";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 765);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 23);
            this.panel2.TabIndex = 90;
            // 
            // lodging_Managment_System_DBDataSet18
            // 
            this.lodging_Managment_System_DBDataSet18.DataSetName = "Lodging_Managment_System_DBDataSet18";
            this.lodging_Managment_System_DBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletedEmpBindingSource
            // 
            this.deletedEmpBindingSource.DataMember = "Deleted_Emp";
            this.deletedEmpBindingSource.DataSource = this.lodging_Managment_System_DBDataSet18;
            // 
            // deleted_EmpTableAdapter
            // 
            this.deleted_EmpTableAdapter.ClearBeforeFill = true;
            // 
            // View_Remove_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 788);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_View_Remove_Employee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv_Employee_Delete);
            this.Name = "View_Remove_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Remove_Employee";
            this.Load += new System.EventHandler(this.Remove_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Delete)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedEmpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee_Delete;
        private System.Windows.Forms.TextBox tb_Emp_Id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Emp_Id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_View_Remove_Employee;
        private System.Windows.Forms.Panel panel2;
        private Lodging_Managment_System_DBDataSet18 lodging_Managment_System_DBDataSet18;
        private System.Windows.Forms.BindingSource deletedEmpBindingSource;
        private Lodging_Managment_System_DBDataSet18TableAdapters.Deleted_EmpTableAdapter deleted_EmpTableAdapter;
        private System.Windows.Forms.Button btn_Refresh;
    }
}