namespace ERP_EntityFramework_UI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            acHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acMainCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acTedarikci = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acMainStock = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUnit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acStock = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acProductionMain = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acProduction = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acProductionOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acHumanResources = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acEmployee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDepartmens = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acJobs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acRoles = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acAuthority = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acOthers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acCalendar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acCalculator = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            imgIcons = new DevExpress.Utils.ImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgIcons).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acHome, acMainCustomer, acMainStock, acProductionMain, acHumanResources, acManagement, acOthers });
            accordionControl1.Location = new System.Drawing.Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.AutoCollapse;
            accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControl1.Size = new System.Drawing.Size(312, 553);
            accordionControl1.TabIndex = 0;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acHome
            // 
            acHome.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("acHome.ImageOptions.Image");
            acHome.Name = "acHome";
            acHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acHome.Text = "Home";
            // 
            // acMainCustomer
            // 
            acMainCustomer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acCustomer, acTedarikci });
            acMainCustomer.Name = "acMainCustomer";
            acMainCustomer.Text = "Cari";
            // 
            // acCustomer
            // 
            acCustomer.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acCustomer.ImageOptions.SvgImage");
            acCustomer.Name = "acCustomer";
            acCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acCustomer.Text = "Müşteriler";
            // 
            // acTedarikci
            // 
            acTedarikci.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acTedarikci.ImageOptions.SvgImage");
            acTedarikci.Name = "acTedarikci";
            acTedarikci.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acTedarikci.Text = "Tedarikçiler";
            // 
            // acMainStock
            // 
            acMainStock.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acProduct, acCategory, acUnit, acStock });
            acMainStock.Name = "acMainStock";
            acMainStock.Text = "Stok";
            // 
            // acProduct
            // 
            acProduct.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acProduct.ImageOptions.SvgImage");
            acProduct.Name = "acProduct";
            acProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acProduct.Text = "Ürünler";
            // 
            // acCategory
            // 
            acCategory.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acCategory.ImageOptions.SvgImage");
            acCategory.Name = "acCategory";
            acCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acCategory.Text = "Kategoriler";
            // 
            // acUnit
            // 
            acUnit.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acUnit.ImageOptions.SvgImage");
            acUnit.Name = "acUnit";
            acUnit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUnit.Text = "Birimler";
            // 
            // acStock
            // 
            acStock.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acStock.ImageOptions.SvgImage");
            acStock.Name = "acStock";
            acStock.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acStock.Text = "Stok";
            // 
            // acProductionMain
            // 
            acProductionMain.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acProduction, acProductionOrder });
            acProductionMain.Name = "acProductionMain";
            acProductionMain.Text = "Üretim";
            // 
            // acProduction
            // 
            acProduction.Name = "acProduction";
            acProduction.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acProduction.Text = "Üretim";
            // 
            // acProductionOrder
            // 
            acProductionOrder.Name = "acProductionOrder";
            acProductionOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acProductionOrder.Text = "İş Emirleri";
            // 
            // acHumanResources
            // 
            acHumanResources.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acEmployee, acDepartmens, acJobs });
            acHumanResources.Name = "acHumanResources";
            acHumanResources.Text = "İnsan Kaynakları";
            // 
            // acEmployee
            // 
            acEmployee.Name = "acEmployee";
            acEmployee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acEmployee.Text = "Personeller";
            // 
            // acDepartmens
            // 
            acDepartmens.Name = "acDepartmens";
            acDepartmens.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDepartmens.Text = "Departmanlar";
            // 
            // acJobs
            // 
            acJobs.Name = "acJobs";
            acJobs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acJobs.Text = "Görevler";
            // 
            // acManagement
            // 
            acManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acUsers, acRoles, acAuthority });
            acManagement.Name = "acManagement";
            acManagement.Text = "Yönetim";
            // 
            // acUsers
            // 
            acUsers.Name = "acUsers";
            acUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUsers.Text = "Kullanıcılar";
            // 
            // acRoles
            // 
            acRoles.Name = "acRoles";
            acRoles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acRoles.Text = "Roller";
            // 
            // acAuthority
            // 
            acAuthority.Name = "acAuthority";
            acAuthority.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acAuthority.Text = "Yetkiler";
            // 
            // acOthers
            // 
            acOthers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acCalendar, acCalculator });
            acOthers.Expanded = true;
            acOthers.Name = "acOthers";
            acOthers.Text = "Diğer";
            // 
            // acCalendar
            // 
            acCalendar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acCalendar.ImageOptions.SvgImage");
            acCalendar.Name = "acCalendar";
            acCalendar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acCalendar.Text = "Takvim";
            // 
            // acCalculator
            // 
            acCalculator.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("acCalculator.ImageOptions.SvgImage");
            acCalculator.Name = "acCalculator";
            acCalculator.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acCalculator.Text = "Hesap Makinesi";
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem });
            ribbonControl1.Location = new System.Drawing.Point(312, 0);
            ribbonControl1.MaxItemId = 1;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Size = new System.Drawing.Size(622, 61);
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // imgIcons
            // 
            imgIcons.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imgIcons.ImageStream");
            imgIcons.Images.SetKeyName(0, "refresh_16x16.png");
            imgIcons.Images.SetKeyName(1, "add_16x16.png");
            imgIcons.Images.SetKeyName(2, "pencolor_16x16.png");
            imgIcons.Images.SetKeyName(3, "removepivotfield_16x16.png");
            imgIcons.Images.SetKeyName(4, "exporttoxls_16x16.png");
            imgIcons.Images.SetKeyName(5, "exporttopdf_16x16.png");
            imgIcons.Images.SetKeyName(6, "exporttohtml_16x16.png");
            imgIcons.Images.SetKeyName(7, "printer_16x16.png");
            // 
            // frmHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 553);
            Controls.Add(ribbonControl1);
            Controls.Add(accordionControl1);
            IsMdiContainer = true;
            Name = "frmHome";
            Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgIcons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acMainCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acTedarikci;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acMainStock;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUnit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStock;
        private DevExpress.Utils.ImageCollection imgIcons;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acProductionMain;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acProduction;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acProductionOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acHumanResources;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acEmployee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDepartmens;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acJobs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acRoles;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acAuthority;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acOthers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCalendar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCalculator;
    }
}