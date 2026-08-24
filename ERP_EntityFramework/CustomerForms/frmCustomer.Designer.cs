namespace ERP_EntityFramework_UI
{
    partial class frmCustomer
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
            grdCustomer = new DevExpress.XtraGrid.GridControl();
            grdvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)grdCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdvCustomer).BeginInit();
            SuspendLayout();
            // 
            // grdCustomer
            // 
            grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            grdCustomer.Location = new System.Drawing.Point(0, 0);
            grdCustomer.MainView = grdvCustomer;
            grdCustomer.Name = "grdCustomer";
            grdCustomer.Size = new System.Drawing.Size(1074, 647);
            grdCustomer.TabIndex = 1;
            grdCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdvCustomer });
            // 
            // grdvCustomer
            // 
            grdvCustomer.GridControl = grdCustomer;
            grdvCustomer.Name = "grdvCustomer";
            grdvCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1074, 647);
            Controls.Add(grdCustomer);
            Name = "frmCustomer";
            Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)grdCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvCustomer;
    }
}