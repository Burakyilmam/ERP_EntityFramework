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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            grdUser = new DevExpress.XtraGrid.GridControl();
            grdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colDurum = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            imgDurum = new DevExpress.Utils.ImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)grdUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colDurum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDurum).BeginInit();
            SuspendLayout();
            // 
            // grdUser
            // 
            grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            grdUser.Location = new System.Drawing.Point(0, 0);
            grdUser.MainView = grdvUser;
            grdUser.Name = "grdUser";
            grdUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { colDurum });
            grdUser.Size = new System.Drawing.Size(995, 653);
            grdUser.TabIndex = 0;
            grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdvUser });
            // 
            // grdvUser
            // 
            grdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUsername, colCreateDate, colCreatedBy, colUpdateDate, colUpdatedBy, colIsActive });
            grdvUser.GridControl = grdUser;
            grdvUser.Name = "grdvUser";
            grdvUser.OptionsBehavior.ReadOnly = true;
            grdvUser.OptionsDetail.EnableMasterViewMode = false;
            grdvUser.OptionsSelection.MultiSelect = true;
            grdvUser.OptionsView.ShowGroupPanel = false;
            // 
            // colUsername
            // 
            colUsername.Caption = "Kullanıcı Adı";
            colUsername.FieldName = "Username";
            colUsername.MinWidth = 25;
            colUsername.Name = "colUsername";
            colUsername.Visible = true;
            colUsername.VisibleIndex = 0;
            colUsername.Width = 94;
            // 
            // colCreateDate
            // 
            colCreateDate.Caption = "Oluşturulma Tarihi";
            colCreateDate.FieldName = "CreateDate";
            colCreateDate.MinWidth = 25;
            colCreateDate.Name = "colCreateDate";
            colCreateDate.Visible = true;
            colCreateDate.VisibleIndex = 1;
            colCreateDate.Width = 94;
            // 
            // colCreatedBy
            // 
            colCreatedBy.Caption = "Oluşturan Kullanıcı";
            colCreatedBy.FieldName = "CreatedBy";
            colCreatedBy.MinWidth = 25;
            colCreatedBy.Name = "colCreatedBy";
            colCreatedBy.Visible = true;
            colCreatedBy.VisibleIndex = 2;
            colCreatedBy.Width = 94;
            // 
            // colUpdateDate
            // 
            colUpdateDate.Caption = "Güncellenme Tarihi";
            colUpdateDate.FieldName = "UpdateDat";
            colUpdateDate.MinWidth = 25;
            colUpdateDate.Name = "colUpdateDate";
            colUpdateDate.Visible = true;
            colUpdateDate.VisibleIndex = 3;
            colUpdateDate.Width = 94;
            // 
            // colUpdatedBy
            // 
            colUpdatedBy.Caption = "Güncelleyen Kullanıcı";
            colUpdatedBy.FieldName = "UpdatedBy";
            colUpdatedBy.MinWidth = 25;
            colUpdatedBy.Name = "colUpdatedBy";
            colUpdatedBy.Visible = true;
            colUpdatedBy.VisibleIndex = 4;
            colUpdatedBy.Width = 94;
            // 
            // colIsActive
            // 
            colIsActive.Caption = "Durumu";
            colIsActive.ColumnEdit = colDurum;
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 25;
            colIsActive.Name = "colIsActive";
            colIsActive.Visible = true;
            colIsActive.VisibleIndex = 5;
            colIsActive.Width = 94;
            // 
            // colDurum
            // 
            colDurum.AutoHeight = false;
            colDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            colDurum.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] { new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 1), new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0) });
            colDurum.Name = "colDurum";
            colDurum.SmallImages = imgDurum;
            // 
            // imgDurum
            // 
            imgDurum.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imgDurum.ImageStream");
            imgDurum.Images.SetKeyName(0, "iconsetsigns3_16x16.png");
            imgDurum.Images.SetKeyName(1, "iconsetredtoblack4_16x16.png");
            imgDurum.Images.SetKeyName(2, "iconsetquarters5_16x16.png");
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
            ((System.ComponentModel.ISupportInitialize)colDurum).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDurum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox colDurum;
        private DevExpress.Utils.ImageCollection imgDurum;
    }
}