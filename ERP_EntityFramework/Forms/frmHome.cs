using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using ERP_EntityFramework_UI.UserForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;

namespace ERP_EntityFramework_UI
{
    public partial class frmHome : XtraForm
    {
        private RibbonPage _dashboardPage;
        private RibbonPage _userPage;
        private RibbonPage _customerPage;

        private readonly IServiceProvider _serviceProvider;
        private readonly ISessionService _sessionService;

        public frmHome(ISessionService sessionService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _sessionService = sessionService;
            _serviceProvider = serviceProvider;

            GetDashboardButtons();
            GetUserButtons();
            GetCustomerButtons();

            InitEvents();
            InitRibbon();
            MdiLoad();
        }

        private void InitEvents()
        {
            acCustomer.Click += AcCustomer_Click;
            acTedarikci.Click += AcTedarikci_Click;
            acHome.Click += AcHome_Click;
        }

        private void InitRibbon()
        {
            _dashboardPage.Visible = true;
            _userPage.Visible = false;
            _customerPage.Visible = false;

            ribbonControl1.SelectedPage = _dashboardPage;
        }

        void MdiLoad()
        {
            frmDashboard dashboard = _serviceProvider.GetRequiredService<frmDashboard>();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void OpenMdiForm<T>(RibbonPage ribbonPage) where T : XtraForm
        {
            foreach (XtraForm form in MdiChildren)
            {
                if (form is T)
                {
                    form.Activate();

                    ribbonControl1.SelectedPage = ribbonPage;

                    return;
                }
            }

            T newForm = _serviceProvider.GetRequiredService<T>();

            newForm.MdiParent = this;

            ribbonPage.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage;

            newForm.FormClosed += (s, e) =>
            {
                ribbonPage.Visible = false;

                if (ribbonControl1.SelectedPage == ribbonPage)
                {
                    ribbonControl1.SelectedPage = _dashboardPage;
                }
            };

            newForm.Show();
        }

        void GetDashboardButtons()
        {
            _dashboardPage = new RibbonPage("Ana Sayfa");

            RibbonPageGroup dashboardGroup = new RibbonPageGroup("Genel");

            var btnDashboardRefresh = new BarButtonItem
            {
                Caption = "Yenile",
                ImageOptions = { Image = imgIcons.Images[0] }
            };

            dashboardGroup.ItemLinks.Add(btnDashboardRefresh);

            _dashboardPage.Groups.Add(dashboardGroup);

            ribbonControl1.Pages.Add(_dashboardPage);
        }

        void GetUserButtons()
        {
            _userPage = new RibbonPage("Users");
            RibbonPageGroup userGroup = new RibbonPageGroup("İşlemler");

            var btnUserRefresh = new BarButtonItem
            {
                Caption = "Yenile",
                ImageOptions = { Image = imgIcons.Images[0] }
            };

            btnUserRefresh.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();

                if (userForm == null) return;

                userForm.GetUsers();
            };

            var btnUserNew = new BarButtonItem
            {
                Caption = "Yeni",
                ImageOptions = { Image = imgIcons.Images[1] }
            };

            btnUserNew.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();

                if (userForm == null) return;

                var userService = _serviceProvider.GetRequiredService<IUserService>();

                var form = new frmUserAdd(userService);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    userForm.GetUsers();
                }
            };

            var btnUserEdit = new BarButtonItem
            {
                Caption = "Düzenle",
                ImageOptions = { Image = imgIcons.Images[2] }
            };

            btnUserEdit.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();

                if (userForm == null) return;

                var user = userForm.GetSelectedUser();

                if (user == null) return;

                var userService = _serviceProvider.GetRequiredService<IUserService>();

                var form = new frmUserAdd(userService, user);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    userForm.GetUsers();
                }
            };

            var btnUserDelete = new BarButtonItem
            {
                Caption = "Sil",
                ImageOptions = { Image = imgIcons.Images[3] }
            };

            btnUserDelete.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();

                if (userForm == null) return;

                userForm.DeleteUser();
            };

            userGroup.ItemLinks.Add(btnUserRefresh);
            userGroup.ItemLinks.Add(btnUserNew);
            userGroup.ItemLinks.Add(btnUserEdit);
            userGroup.ItemLinks.Add(btnUserDelete);

            RibbonPageGroup userGroup2 = new RibbonPageGroup("Dosya İşlemleri");

            var btnUserExportExcel = new BarButtonItem
            {
                Caption = "Excel'e Aktar",
                ImageOptions = { Image = imgIcons.Images[4] }
            };
            
            btnUserExportExcel.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();
                if (userForm == null) return;
                userForm.ExportToExcel();
            };

            var btnUserExportPdf = new BarButtonItem
            {
                Caption = "PDF'ye Aktar",
                ImageOptions = { Image = imgIcons.Images[5] }
            };

            btnUserExportPdf.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();
                if (userForm == null) return;
                userForm.ExportToPdf();
            };

            var btnUserExportHTML = new BarButtonItem
            {
                Caption = "HTML'ye Aktar",
                ImageOptions = { Image = imgIcons.Images[6] }
            };

            btnUserExportHTML.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();
                if (userForm == null) return;
                userForm.ExportToHTML();
            };

            var btnUserPrint = new BarButtonItem
            {
                Caption = "Yazdır",
                ImageOptions = { Image = imgIcons.Images[7] }
            };

            btnUserPrint.ItemClick += (s, e) =>
            {
                var userForm = MdiChildren.OfType<frmUser>().FirstOrDefault();
                if (userForm == null) return;
                userForm.Print();
            };

            userGroup2.ItemLinks.Add(btnUserExportExcel);
            userGroup2.ItemLinks.Add(btnUserExportPdf);
            userGroup2.ItemLinks.Add(btnUserExportHTML);
            userGroup2.ItemLinks.Add(btnUserPrint);

            _userPage.Groups.Add(userGroup);
            _userPage.Groups.Add(userGroup2);

            ribbonControl1.Pages.Add(_userPage);
        }

        void GetCustomerButtons()
        {
            _customerPage = new RibbonPage("Customers");
            RibbonPageGroup customerGroup = new RibbonPageGroup("İşlemler");

            var btnCustomerRefresh = new BarButtonItem
            {
                Caption = "Yenile",
                ImageOptions = { Image = imgIcons.Images[0] }
            };
            var btnCustomerNew = new BarButtonItem
            {
                Caption = "Yeni",
                ImageOptions = { Image = imgIcons.Images[1] }
            };
            var btnCustomerEdit = new BarButtonItem
            {
                Caption = "Düzenle",
                ImageOptions = { Image = imgIcons.Images[2] }
            };

            var btnCustomerDelete = new BarButtonItem
            {
                Caption = "Sil",
                ImageOptions = { Image = imgIcons.Images[3] }
            };

            customerGroup.ItemLinks.Add(btnCustomerRefresh);
            customerGroup.ItemLinks.Add(btnCustomerNew);
            customerGroup.ItemLinks.Add(btnCustomerEdit);
            customerGroup.ItemLinks.Add(btnCustomerDelete);

            RibbonPageGroup customerGroup2 = new RibbonPageGroup("Dosya İşlemleri");

            var btnCustomerExportExcel = new BarButtonItem
            {
                Caption = "Excel'e Aktar",
                ImageOptions = { Image = imgIcons.Images[4] }
            };
            var btnCustomerExportPdf = new BarButtonItem
            {
                Caption = "PDF'ye Aktar",
                ImageOptions = { Image = imgIcons.Images[5] }
            };
            var btnCustomerExportHTML = new BarButtonItem
            {
                Caption = "HTML'ye Aktar",
                ImageOptions = { Image = imgIcons.Images[6] }
            };

            var btnCustomerPrint = new BarButtonItem
            {
                Caption = "Yazdır",
                ImageOptions = { Image = imgIcons.Images[7] }
            };

            customerGroup2.ItemLinks.Add(btnCustomerExportExcel);
            customerGroup2.ItemLinks.Add(btnCustomerExportPdf);
            customerGroup2.ItemLinks.Add(btnCustomerExportHTML);
            customerGroup2.ItemLinks.Add(btnCustomerPrint);

            _customerPage.Groups.Add(customerGroup);
            _customerPage.Groups.Add(customerGroup2);

            ribbonControl1.Pages.Add(_customerPage);
        }

        private void AcHome_Click(object sender, EventArgs e)
        {
            OpenMdiForm<frmDashboard>(_dashboardPage);
        }

        private void AcCustomer_Click(object sender, EventArgs e)
        {
            OpenMdiForm<frmUser>(_userPage);
        }

        private void AcTedarikci_Click(object sender, EventArgs e)
        {
            OpenMdiForm<frmCustomer>(_customerPage);
        }
    }
}