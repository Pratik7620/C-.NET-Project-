namespace Lodging_Managment_System
{
    partial class WelCome_Msg
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
            this.timer_maharaja = new System.Windows.Forms.Timer(this.components);
            this.btn_Press_Any_Key = new System.Windows.Forms.Button();
            this.lbl_maharaja = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Press_Any_Key
            // 
            this.btn_Press_Any_Key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Press_Any_Key.FlatAppearance.BorderSize = 0;
            this.btn_Press_Any_Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Press_Any_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Press_Any_Key.Location = new System.Drawing.Point(259, 356);
            this.btn_Press_Any_Key.Name = "btn_Press_Any_Key";
            this.btn_Press_Any_Key.Size = new System.Drawing.Size(282, 37);
            this.btn_Press_Any_Key.TabIndex = 5;
            this.btn_Press_Any_Key.Text = "Press Any Key";
            this.btn_Press_Any_Key.UseVisualStyleBackColor = true;
            // 
            // lbl_maharaja
            // 
            this.lbl_maharaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_maharaja.AutoSize = true;
            this.lbl_maharaja.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maharaja.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_maharaja.Location = new System.Drawing.Point(397, 128);
            this.lbl_maharaja.Name = "lbl_maharaja";
            this.lbl_maharaja.Size = new System.Drawing.Size(195, 61);
            this.lbl_maharaja.TabIndex = 4;
            this.lbl_maharaja.Text = "MAHARAJA";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(170, 128);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(247, 61);
            this.lbl_Welcome.TabIndex = 3;
            this.lbl_Welcome.Text = "WELCOME TO ";
            // 
            // WelCome_Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Press_Any_Key);
            this.Controls.Add(this.lbl_maharaja);
            this.Controls.Add(this.lbl_Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelCome_Msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelCome_Msg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_maharaja;
        private System.Windows.Forms.Button btn_Press_Any_Key;
        private System.Windows.Forms.Label lbl_maharaja;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}