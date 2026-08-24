namespace ERP_EntityFramework_UI
{
    partial class frmDashboard
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
            lblWelcome = new DevExpress.XtraEditors.LabelControl();
            lblToday = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new System.Drawing.Point(36, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(53, 16);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblToday
            // 
            lblToday.Location = new System.Drawing.Point(36, 48);
            lblToday.Name = "lblToday";
            lblToday.Size = new System.Drawing.Size(30, 16);
            lblToday.TabIndex = 0;
            lblToday.Text = "Tarih";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 476);
            Controls.Add(lblToday);
            Controls.Add(lblWelcome);
            Name = "frmDashboard";
            Text = "frmDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.LabelControl lblToday;
    }
}