using DevExpress.XtraEditors.Controls;
using ERP_EntityFramework.Core.Helpers;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI.Forms
{
    public partial class frmRegister : Form
    {
        public int score = 0;

        private readonly IUserService _userService;

        private EditorButton btnEye;
        private EditorButton btnEyeAgain;

        public frmRegister(IUserService userService)
        {
            InitializeComponent();

            _userService = userService;

            btnEye = edPassword.Properties.Buttons[0];
            btnEyeAgain = edPasswordAgain.Properties.Buttons[0];

            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.ShowTitle = false;

            progressBarControl1.Paint += ProgressBarControl1_Paint;

            InitEvents();
        }

        private void InitEvents()
        {
            edPassword.EditValueChanged += Password_EditValueChanged;
            edPasswordAgain.EditValueChanged += Password_EditValueChanged;

            btnEye.Click += BtnEye_Click;
            btnEyeAgain.Click += BtnEyeAgain_Click;

            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = edUsername.EditValue?.ToString()?.Trim();
            string password = edPassword.EditValue?.ToString();
            string passwordAgain = edPasswordAgain.EditValue?.ToString();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Username alanını doldurunuz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                edUsername.Focus();
                return;
            }

            bool userExists = _userService.UserExists(username);

            if (userExists)
            {
                MessageBox.Show(
                    "Bu kullanıcı adı zaten kullanılıyor.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                edUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Parola alanını doldurunuz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                edPassword.Focus();
                return;
            }

            if (password != passwordAgain)
            {
                MessageBox.Show(
                    "Parolalar eşleşmiyor.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                edPasswordAgain.Focus();
                return;
            }

            if (score < 50)
            {
                MessageBox.Show(
                    "Parola çok zayıf. Lütfen daha güçlü bir parola seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                edPassword.Focus();
                return;
            }

            User user = new User
            {
                Username = username,
                PasswordHash = password,
                CreateDate = DateTime.Now,
                CreatedBy = "SYSTEM",
                IsActive = true
            };

            _userService.UserAdd(user);

            MessageBox.Show(
                "Kullanıcı başarıyla oluşturuldu.",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private void BtnEye_Click(object sender, EventArgs e)
        {
            bool showPassword = edPassword.Properties.UseSystemPasswordChar;

            edPassword.Properties.UseSystemPasswordChar = !showPassword;
            edPasswordAgain.Properties.UseSystemPasswordChar = !showPassword;

            if (!showPassword)
            {
                btnEye.ImageOptions.Image = imgEye.Images[1];
                btnEyeAgain.ImageOptions.Image = imgEye.Images[1];
            }
            else
            {
                btnEye.ImageOptions.Image = imgEye.Images[0];
                btnEyeAgain.ImageOptions.Image = imgEye.Images[0];
            }
        }

        private void BtnEyeAgain_Click(object sender, EventArgs e)
        {
            BtnEye_Click(sender, e);
        }

        private void Password_EditValueChanged(object sender, EventArgs e)
        {
            string password = edPassword.EditValue?.ToString() ?? "";
            string passwordAgain = edPasswordAgain.EditValue?.ToString() ?? "";

            score = CalculatePasswordStrength(password);

            progressBarControl1.EditValue = score;
            progressBarControl1.Invalidate();

            btnRegister.Enabled = !string.IsNullOrEmpty(password) &&
                                  !string.IsNullOrEmpty(passwordAgain) &&
                                  password == passwordAgain;
        }

        private int CalculatePasswordStrength(string password)
        {
            int score = 0;

            if (string.IsNullOrEmpty(password))
                return 0;

            if (password.Length >= 8)
                score += 25;

            if (password.Length >= 12)
                score += 25;

            if (password.Any(char.IsUpper))
                score += 15;

            if (password.Any(char.IsLower))
                score += 10;

            if (password.Any(char.IsDigit))
                score += 15;

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
                score += 10;

            return Math.Min(score, 100);
        }

        private void ProgressBarControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Rectangle rect = progressBarControl1.ClientRectangle;
            rect.Inflate(-1, -3);

            int radius = rect.Height / 2;

            using (GraphicsPath backgroundPath = CreateRoundedRectangle(rect, radius))
            {
                using (SolidBrush backgroundBrush = new SolidBrush(Color.FromArgb(225, 228, 232)))
                {
                    g.FillPath(backgroundBrush, backgroundPath);
                }

                using (Pen borderPen = new Pen(Color.FromArgb(200, 205, 210), 1))
                {
                    g.DrawPath(borderPen, backgroundPath);
                }
            }

            if (score <= 0)
                return;

            int fillWidth = (int)(rect.Width * (score / 100.0));

            Rectangle fillRect = new Rectangle(
                rect.X,
                rect.Y,
                Math.Max(fillWidth, radius * 2),
                rect.Height);

            if (fillRect.Right > rect.Right)
                fillRect.Width = rect.Width;

            int fillRadius = rect.Height / 2;

            using (GraphicsPath fillPath = CreateRoundedRectangle(fillRect, fillRadius))
            {
                Color baseColor = GetStrengthColor(score);
                Color lightColor = ControlPaint.Light(baseColor, 0.25f);
                Color darkColor = ControlPaint.Dark(baseColor, 0.15f);

                using (LinearGradientBrush gradient = new LinearGradientBrush(
                    fillRect,
                    lightColor,
                    darkColor,
                    LinearGradientMode.Vertical))
                {
                    g.FillPath(gradient, fillPath);
                }

                Rectangle shineRect = new Rectangle(
                    fillRect.X + 2,
                    fillRect.Y + 2,
                    Math.Max(fillRect.Width - 4, 1),
                    Math.Max(fillRect.Height / 3, 1));

                using (GraphicsPath shinePath = CreateRoundedRectangle(shineRect, Math.Max(shineRect.Height / 2, 1)))
                {
                    using (SolidBrush shineBrush = new SolidBrush(Color.FromArgb(45, Color.White)))
                    {
                        g.FillPath(shineBrush, shinePath);
                    }
                }
            }
        }

        private Color GetStrengthColor(int value)
        {
            if (value < 25)
            {
                return Color.FromArgb(231, 76, 60);
            }

            if (value < 50)
            {
                return Color.FromArgb(230, 126, 34);
            }

            if (value < 75)
            {
                return Color.FromArgb(241, 196, 15);
            }

            return Color.FromArgb(46, 204, 113);
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            if (diameter > rect.Width)
                diameter = rect.Width;

            if (diameter > rect.Height)
                diameter = rect.Height;

            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            path.AddArc(arc, 180, 90);

            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = rect.X;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}