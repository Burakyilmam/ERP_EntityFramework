using DevExpress.XtraGrid.Views.Base;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using ERP_EntityFramework_UI.UserForms;
using System;
using System.Linq;
using System.Windows.Controls;

namespace ERP_EntityFramework_UI
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        public User selectedUser;

        public frmUser(IUserService userService)
        {
            InitializeComponent();
            InitEvents();

            _userService = userService;

            GetUsers();
        }

        private void InitEvents()
        {
            grdUser.DoubleClick += GrdUser_DoubleClick;
        }

        private void GrdUser_DoubleClick(object sender, EventArgs e)
        {
            GetSelectedUser();
        }

        public User GetSelectedUser()
        {
            selectedUser = grdvUser.GetFocusedRow() as User;
            return selectedUser;
        }

        public void GetUsers()
        {
            var users = _userService.ListAll();
            grdUser.DataSource = users;
        }

        public void DeleteUser()
        {
            int[] selectedUsers = grdvUser.GetSelectedRows();

            if (selectedUsers.Length == 0) return;

            grdvUser.BeginUpdate();

            foreach (int selectedUser in selectedUsers.OrderByDescending(x => x))
            {
                User deletedUser = grdvUser.GetRow(selectedUser) as User;

                if (deletedUser == null) continue;

                _userService.Delete(deletedUser);
            }

            grdvUser.EndUpdate();

            GetUsers();
        }

        public void ExportToExcel()
        {
            grdvUser.ExportToXlsx("Users.xlsx");
        }

        public void ExportToPdf()
        {
            grdvUser.ExportToPdf("Users.pdf");
        }

        public void ExportToHTML()
        {
            grdvUser.ExportToHtml("Users.html");
        }

        public void Print()
        {
            grdvUser.Print();
        }
    }
}