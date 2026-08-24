namespace ERP_EntityFramework_UI
{
    partial class frmUser
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
            grdUser = new DevExpress.XtraGrid.GridControl();
            grdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)grdUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdvUser).BeginInit();
            SuspendLayout();
            // 
            // grdUser
            // 
            grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            grdUser.Location = new System.Drawing.Point(0, 0);
            grdUser.MainView = grdvUser;
            grdUser.Name = "grdUser";
            grdUser.Size = new System.Drawing.Size(995, 653);
            grdUser.TabIndex = 0;
            grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdvUser });
            // 
            // grdvUser
            // 
            grdvUser.GridControl = grdUser;
            grdvUser.Name = "grdvUser";
            grdvUser.OptionsView.ShowGroupPanel = false;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(995, 653);
            Controls.Add(grdUser);
            Name = "frmUser";
            Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)grdUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvUser;
    }
}