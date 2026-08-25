using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using ERP_EntityFramework_UI.Functions;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;

        public frmUser(IUserService userService)
        {
            InitializeComponent();
            InitEvents();

            _userService = userService;

            GetUsers();
        }

        private void InitEvents()
        {
            grdvUser.KeyDown += GrdvUser_KeyDown;
        }

        private void GrdvUser_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                grdvUser.GetFirstRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.End)
            {
                grdvUser.GetLastRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.M)
            {
                grdvUser.GetMiddleRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                grdvUser.GetPreviousRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                grdvUser.GetNextRow();
                e.Handled = true;
            }
        }

        public User GetSelectedUser()
        {
            return Generic.GetSelected<User>(grdvUser);
        }

        public void GetUsers()
        {
            var users = _userService.ListAll();

            grdUser.DataSource = users;
        }

        public void DeleteUser()
        {
            Generic.DeleteSelected<User>(grdvUser, user => _userService.Delete(user));

            GetUsers();
        }

        public void ExportToExcel()
        {
            Generic.ExportToFile(grdvUser, "Excel Dosyaları|*.xlsx");
        }

        public void ExportToPdf()
        {
            Generic.ExportToFile(grdvUser, "PDF Dosyaları|*.pdf");
        }

        public void ExportToHTML()
        {
            Generic.ExportToFile(grdvUser, "HTML Dosyaları|*.html");
        }

        public void Print()
        {
            Generic.Print(grdvUser);
        }
    }
}