namespace Lodging_Managment_System
{
    partial class View_All_Rooms
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
            this.dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet11 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet11();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet6 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet6();
            this.roomsTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet6TableAdapters.RoomsTableAdapter();
            this.btn_Back = new System.Windows.Forms.Button();
            this.roomsTableAdapter1 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet11TableAdapters.RoomsTableAdapter();
            this.lbl_View_All_Rooms = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lodging_Managment_System_DBDataSet19 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet19();
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter2 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet19TableAdapters.RoomsTableAdapter();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perHrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Rooms
            // 
            this.dgv_Rooms.AllowUserToAddRows = false;
            this.dgv_Rooms.AllowUserToDeleteRows = false;
            this.dgv_Rooms.AutoGenerateColumns = false;
            this.dgv_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNoDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedTypeDataGridViewTextBoxColumn,
            this.amountDayDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.perHrsDataGridViewTextBoxColumn});
            this.dgv_Rooms.DataSource = this.roomsBindingSource2;
            this.dgv_Rooms.Location = new System.Drawing.Point(12, 208);
            this.dgv_Rooms.Name = "dgv_Rooms";
            this.dgv_Rooms.ReadOnly = true;
            this.dgv_Rooms.RowTemplate.Height = 24;
            this.dgv_Rooms.Size = new System.Drawing.Size(1077, 497);
            this.dgv_Rooms.TabIndex = 1;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.lodging_Managment_System_DBDataSet11;
            // 
            // lodging_Managment_System_DBDataSet11
            // 
            this.lodging_Managment_System_DBDataSet11.DataSetName = "Lodging_Managment_System_DBDataSet11";
            this.lodging_Managment_System_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.lodging_Managment_System_DBDataSet6;
            // 
            // lodging_Managment_System_DBDataSet6
            // 
            this.lodging_Managment_System_DBDataSet6.DataSetName = "Lodging_Managment_System_DBDataSet6";
            this.lodging_Managment_System_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 49);
            this.btn_Back.TabIndex = 78;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Add_Room_Click);
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_View_All_Rooms
            // 
            this.lbl_View_All_Rooms.AutoSize = true;
            this.lbl_View_All_Rooms.Font = new System.Drawing.Font("Modern No. 20", 20.25F);
            this.lbl_View_All_Rooms.Location = new System.Drawing.Point(419, 103);
            this.lbl_View_All_Rooms.Name = "lbl_View_All_Rooms";
            this.lbl_View_All_Rooms.Size = new System.Drawing.Size(237, 35);
            this.lbl_View_All_Rooms.TabIndex = 4;
            this.lbl_View_All_Rooms.Text = "View All Rooms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 49);
            this.panel1.TabIndex = 87;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Location = new System.Drawing.Point(1041, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(60, 48);
            this.btn_Close.TabIndex = 84;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 735);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 23);
            this.panel2.TabIndex = 88;
            // 
            // lodging_Managment_System_DBDataSet19
            // 
            this.lodging_Managment_System_DBDataSet19.DataSetName = "Lodging_Managment_System_DBDataSet19";
            this.lodging_Managment_System_DBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "Rooms";
            this.roomsBindingSource2.DataSource = this.lodging_Managment_System_DBDataSet19;
            // 
            // roomsTableAdapter2
            // 
            this.roomsTableAdapter2.ClearBeforeFill = true;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedTypeDataGridViewTextBoxColumn
            // 
            this.bedTypeDataGridViewTextBoxColumn.DataPropertyName = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.HeaderText = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.Name = "bedTypeDataGridViewTextBoxColumn";
            this.bedTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDayDataGridViewTextBoxColumn
            // 
            this.amountDayDataGridViewTextBoxColumn.DataPropertyName = "Amount_Day";
            this.amountDayDataGridViewTextBoxColumn.HeaderText = "Per_Day";
            this.amountDayDataGridViewTextBoxColumn.Name = "amountDayDataGridViewTextBoxColumn";
            this.amountDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perHrsDataGridViewTextBoxColumn
            // 
            this.perHrsDataGridViewTextBoxColumn.DataPropertyName = "Per_Hrs";
            this.perHrsDataGridViewTextBoxColumn.HeaderText = "Per_Hrs";
            this.perHrsDataGridViewTextBoxColumn.Name = "perHrsDataGridViewTextBoxColumn";
            this.perHrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View_All_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 758);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_View_All_Rooms);
            this.Controls.Add(this.dgv_Rooms);
            this.Name = "View_All_Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_All_Rooms";
            this.Load += new System.EventHandler(this.View_All_Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Rooms;
        private Lodging_Managment_System_DBDataSet6 lodging_Managment_System_DBDataSet6;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Lodging_Managment_System_DBDataSet6TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Button btn_Back;
        private Lodging_Managment_System_DBDataSet11 lodging_Managment_System_DBDataSet11;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private Lodging_Managment_System_DBDataSet11TableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.Label lbl_View_All_Rooms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel2;
        private Lodging_Managment_System_DBDataSet19 lodging_Managment_System_DBDataSet19;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private Lodging_Managment_System_DBDataSet19TableAdapters.RoomsTableAdapter roomsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perHrsDataGridViewTextBoxColumn;
    }
}