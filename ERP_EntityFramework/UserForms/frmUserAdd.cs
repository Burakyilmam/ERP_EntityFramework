using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using System;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI.UserForms
{
    public partial class frmUserAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private User _user;

        public frmUserAdd(IUserService userService, User user = null)
        {
            InitializeComponent();
            InitEvents();

            _userService = userService;
            _user = user;

            if (_user != null)
            {
                userBindingSource.DataSource = _user;
            }
        }

        private void InitEvents()
        {
            btnAdd.Click += BtnAdd_Click;
        }

        void Save()
        {
            if (string.IsNullOrWhiteSpace(edUsername.Text) || string.IsNullOrWhiteSpace(edPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            if (_user == null)
            {
                User newUser = new User
                {
                    Username = edUsername.Text,
                    PasswordHash = edPassword.Text,
                    CreateDate = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    IsActive = true,
                };

                _userService.Add(newUser);

                UserRole newUserRole = new UserRole
                {
                    RoleId = 2,
                    User = newUser
                };

                MessageBox.Show("Yeni kullanıcı oluşturuldu.");
            }
            else
            {
                _user.Username = edUsername.Text;
                //_user.PasswordHash = edPassword.Text;
                _user.UpdateDate = DateTime.Now;
                _user.UpdatedBy = Statics.User.Username;

                _userService.Update(_user);

                MessageBox.Show("Kullanıcı bilgileri güncellendi.");
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}