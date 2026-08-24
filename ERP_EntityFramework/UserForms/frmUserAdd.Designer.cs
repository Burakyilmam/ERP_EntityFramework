namespace ERP_EntityFramework_UI.UserForms
{
    partial class frmUserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAdd));
            lblUsername = new DevExpress.XtraEditors.LabelControl();
            edUsername = new DevExpress.XtraEditors.TextEdit();
            lblPassword = new DevExpress.XtraEditors.LabelControl();
            edPassword = new DevExpress.XtraEditors.TextEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)edUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new System.Drawing.Point(19, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(58, 16);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // edUsername
            // 
            edUsername.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", userBindingSource, "Username", true));
            edUsername.Location = new System.Drawing.Point(97, 9);
            edUsername.Name = "edUsername";
            edUsername.Size = new System.Drawing.Size(188, 22);
            edUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Location = new System.Drawing.Point(19, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(55, 16);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // edPassword
            // 
            edPassword.Location = new System.Drawing.Point(97, 37);
            edPassword.Name = "edPassword";
            edPassword.Size = new System.Drawing.Size(188, 22);
            edPassword.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            btnAdd.Location = new System.Drawing.Point(153, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(65, 36);
            btnAdd.TabIndex = 2;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(ERP_EntityFramework_Entities.User);
            // 
            // frmUserAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(304, 126);
            Controls.Add(btnAdd);
            Controls.Add(edPassword);
            Controls.Add(lblPassword);
            Controls.Add(edUsername);
            Controls.Add(lblUsername);
            Name = "frmUserAdd";
            Text = "frmUserAdd";
            ((System.ComponentModel.ISupportInitialize)edUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.TextEdit edUsername;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit edPassword;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}