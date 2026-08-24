using DevExpress.XtraEditors.Controls;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using ERP_EntityFramework_UI;
using System;
using System.Windows.Forms;

namespace ERP_EntityFramework
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUserService _userService;
        private readonly ISessionService _sessionService;
        private EditorButton btnEye, btnUser, btnLock;

        public frmLogin(IUserService userService , ISessionService sessionService)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            btnEye = edPassword.Properties.Buttons[0];
            btnUser = edUsername.Properties.Buttons[0];
            btnLock = edPassword.Properties.Buttons[1];

            _userService = userService;
            _sessionService = sessionService;

            InitEvents();

        }

        void InitEvents()
        {
            btnEye.Click += BtnEye_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        void Login()
        {
            string username = edUsername.Text.Trim();
            string password = edPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Şifre boş bırakılamaz.");
                return;
            }

            User user = _userService.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                return;
            }

            Statics.User = user;

            Session newSession = _sessionService.CreateSession(user);
            Statics.Session = newSession;

            DialogResult = DialogResult.OK;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        void BtnEye_Click(object sender, EventArgs e)
        {
            if (edPassword.Properties.UseSystemPasswordChar)
            {
                edPassword.Properties.UseSystemPasswordChar = false;
                btnEye.ImageOptions.Image = imgEye.Images[1];
            }
            else
            {
                edPassword.Properties.UseSystemPasswordChar = true;
                btnEye.ImageOptions.Image = imgEye.Images[0];
            }
        }
    }
}
