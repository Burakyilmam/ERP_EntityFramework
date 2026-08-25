namespace ERP_EntityFramework_UI.CustomerForms
{
    partial class frmCustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAdd));
            lblName = new DevExpress.XtraEditors.LabelControl();
            edName = new DevExpress.XtraEditors.TextEdit();
            customerBindingSource = new System.Windows.Forms.BindingSource(components);
            lblSurname = new DevExpress.XtraEditors.LabelControl();
            edSurname = new DevExpress.XtraEditors.TextEdit();
            edDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            lblDateOfBirth = new DevExpress.XtraEditors.LabelControl();
            edNotes = new DevExpress.XtraEditors.MemoEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            edTaxNumber = new DevExpress.XtraEditors.TextEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lblCustomerType = new DevExpress.XtraEditors.LabelControl();
            lblNotes = new DevExpress.XtraEditors.LabelControl();
            lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            lblCompany = new DevExpress.XtraEditors.LabelControl();
            edCustomerCode = new DevExpress.XtraEditors.TextEdit();
            edCompanyName = new DevExpress.XtraEditors.TextEdit();
            edCustomerType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)edName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edSurname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edDateOfBirth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edDateOfBirth.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edTaxNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edCustomerCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edCompanyName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edCustomerType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new System.Drawing.Point(23, 39);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(18, 16);
            lblName.TabIndex = 0;
            lblName.Text = "Adı";
            // 
            // edName
            // 
            edName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "Name", true));
            edName.Location = new System.Drawing.Point(23, 61);
            edName.Name = "edName";
            edName.Size = new System.Drawing.Size(298, 22);
            edName.TabIndex = 1;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // lblSurname
            // 
            lblSurname.Location = new System.Drawing.Point(25, 89);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(38, 16);
            lblSurname.TabIndex = 0;
            lblSurname.Text = "Soyadı";
            // 
            // edSurname
            // 
            edSurname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "Surname", true));
            edSurname.Location = new System.Drawing.Point(23, 111);
            edSurname.Name = "edSurname";
            edSurname.Size = new System.Drawing.Size(298, 22);
            edSurname.TabIndex = 1;
            // 
            // edDateOfBirth
            // 
            edDateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "DateOfBirth", true));
            edDateOfBirth.EditValue = null;
            edDateOfBirth.Location = new System.Drawing.Point(25, 161);
            edDateOfBirth.Name = "edDateOfBirth";
            edDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            edDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            edDateOfBirth.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            edDateOfBirth.Properties.MaskSettings.Set("mask", "d");
            edDateOfBirth.Size = new System.Drawing.Size(298, 22);
            edDateOfBirth.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Location = new System.Drawing.Point(25, 139);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new System.Drawing.Size(77, 16);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "Doğum Tarihi";
            // 
            // edNotes
            // 
            edNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "Notes", true));
            edNotes.Location = new System.Drawing.Point(338, 163);
            edNotes.Name = "edNotes";
            edNotes.Size = new System.Drawing.Size(318, 134);
            edNotes.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(336, 89);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(88, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Vergi Numarası";
            // 
            // edTaxNumber
            // 
            edTaxNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "TaxNumber", true));
            edTaxNumber.Location = new System.Drawing.Point(336, 111);
            edTaxNumber.Name = "edTaxNumber";
            edTaxNumber.Size = new System.Drawing.Size(320, 22);
            edTaxNumber.TabIndex = 1;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(pictureEdit1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(668, 64);
            panelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl2.Location = new System.Drawing.Point(99, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            labelControl2.Size = new System.Drawing.Size(567, 60);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "Müşteri Bilgileri";
            // 
            // pictureEdit1
            // 
            pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(2, 2);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Size = new System.Drawing.Size(97, 60);
            pictureEdit1.TabIndex = 6;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(lblCustomerType);
            groupControl1.Controls.Add(lblName);
            groupControl1.Controls.Add(edNotes);
            groupControl1.Controls.Add(edName);
            groupControl1.Controls.Add(edTaxNumber);
            groupControl1.Controls.Add(lblSurname);
            groupControl1.Controls.Add(lblNotes);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(edDateOfBirth);
            groupControl1.Controls.Add(lblCustomerCode);
            groupControl1.Controls.Add(lblCompany);
            groupControl1.Controls.Add(edCustomerCode);
            groupControl1.Controls.Add(edCompanyName);
            groupControl1.Controls.Add(edSurname);
            groupControl1.Controls.Add(lblDateOfBirth);
            groupControl1.Controls.Add(edCustomerType);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 64);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(668, 317);
            groupControl1.TabIndex = 7;
            groupControl1.Text = "Genel Bilgiler";
            // 
            // lblCustomerType
            // 
            lblCustomerType.Location = new System.Drawing.Point(336, 39);
            lblCustomerType.Name = "lblCustomerType";
            lblCustomerType.Size = new System.Drawing.Size(67, 16);
            lblCustomerType.TabIndex = 0;
            lblCustomerType.Text = "Müşteri Tipi";
            // 
            // lblNotes
            // 
            lblNotes.Location = new System.Drawing.Point(336, 139);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(34, 16);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notlar";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.Location = new System.Drawing.Point(25, 251);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new System.Drawing.Size(74, 16);
            lblCustomerCode.TabIndex = 0;
            lblCustomerCode.Text = "Müşteri Kodu";
            // 
            // lblCompany
            // 
            lblCompany.Location = new System.Drawing.Point(25, 195);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(55, 16);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "Şirket Adı";
            // 
            // edCustomerCode
            // 
            edCustomerCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "CustomerCode", true));
            edCustomerCode.Location = new System.Drawing.Point(25, 274);
            edCustomerCode.Name = "edCustomerCode";
            edCustomerCode.Size = new System.Drawing.Size(298, 22);
            edCustomerCode.TabIndex = 1;
            // 
            // edCompanyName
            // 
            edCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "CompanyName", true));
            edCompanyName.Location = new System.Drawing.Point(25, 217);
            edCompanyName.Name = "edCompanyName";
            edCompanyName.Size = new System.Drawing.Size(298, 22);
            edCompanyName.TabIndex = 1;
            // 
            // edCustomerType
            // 
            edCustomerType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", customerBindingSource, "CustomerType", true));
            edCustomerType.Location = new System.Drawing.Point(336, 61);
            edCustomerType.Name = "edCustomerType";
            edCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            edCustomerType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] { new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bireysel", 0, -1), new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kurumsal", 1, -1) });
            edCustomerType.Properties.PopupSizeable = true;
            edCustomerType.Size = new System.Drawing.Size(320, 22);
            edCustomerType.TabIndex = 1;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnSave);
            panelControl2.Controls.Add(btnCancel);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 378);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(668, 38);
            panelControl2.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
            btnSave.Location = new System.Drawing.Point(430, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(118, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            // 
            // btnCancel
            // 
            btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            btnCancel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancel.ImageOptions.SvgImage");
            btnCancel.Location = new System.Drawing.Point(548, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(118, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "İptal";
            // 
            // frmCustomerAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(668, 416);
            Controls.Add(panelControl2);
            Controls.Add(groupControl1);
            Controls.Add(panelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCustomerAdd";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Müşteri Bilgileri";
            ((System.ComponentModel.ISupportInitialize)edName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)edSurname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edDateOfBirth.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edDateOfBirth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edTaxNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edCustomerCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edCompanyName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edCustomerType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit edName;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.TextEdit edSurname;
        private DevExpress.XtraEditors.DateEdit edDateOfBirth;
        private DevExpress.XtraEditors.LabelControl lblDateOfBirth;
        private DevExpress.XtraEditors.MemoEdit edNotes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit edTaxNumber;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblCustomerType;
        private DevExpress.XtraEditors.LabelControl lblNotes;
        private DevExpress.XtraEditors.ImageComboBoxEdit edCustomerType;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private DevExpress.XtraEditors.LabelControl lblCompany;
        private DevExpress.XtraEditors.TextEdit edCustomerCode;
        private DevExpress.XtraEditors.TextEdit edCompanyName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}