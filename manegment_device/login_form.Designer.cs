using System.ComponentModel;

namespace manegment_device
{
    partial class login_form
    {
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            glassPanel = new System.Windows.Forms.Panel();
            anounce = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            ini_user = new ReaLTaiizor.Controls.HopeTextBox();
            lblPass = new System.Windows.Forms.Label();
            Password_form = new ReaLTaiizor.Controls.HopeTextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            btnRegister = new ReaLTaiizor.Controls.HopeButton();
            shadowPanel = new System.Windows.Forms.Panel();
            glassPanel.SuspendLayout();
            SuspendLayout();
            // 
            // glassPanel
            // 
            glassPanel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)190)), ((int)((byte)255)), ((int)((byte)250)), ((int)((byte)235)));
            glassPanel.Controls.Add(anounce);
            glassPanel.Controls.Add(lblTitle);
            glassPanel.Controls.Add(lblUser);
            glassPanel.Controls.Add(ini_user);
            glassPanel.Controls.Add(lblPass);
            glassPanel.Controls.Add(Password_form);
            glassPanel.Controls.Add(checkBox1);
            glassPanel.Controls.Add(btnLogin);
            glassPanel.Controls.Add(btnRegister);
            glassPanel.Location = new System.Drawing.Point(175, 45);
            glassPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new System.Drawing.Size(350, 338);
            glassPanel.TabIndex = 1;
            glassPanel.Paint += glassPanel_Paint;
            // 
            // anounce
            // 
            anounce.BackColor = System.Drawing.Color.Transparent;
            anounce.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            anounce.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)53)), ((int)((byte)69)));
            anounce.Location = new System.Drawing.Point(-23, 201);
            anounce.Name = "anounce";
            anounce.Size = new System.Drawing.Size(301, 19);
            anounce.TabIndex = 8;
            anounce.Text = "Sai tên đăng nhập hoặc mật khẩu!";
            anounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            anounce.Visible = false;
            anounce.Click += anounce_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            lblTitle.Location = new System.Drawing.Point(88, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(190, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng Nhập";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = System.Drawing.Color.Transparent;
            lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)120)), ((int)((byte)120)));
            lblUser.Location = new System.Drawing.Point(35, 82);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(99, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tên đăng nhập";
            // 
            // ini_user
            // 
            ini_user.BackColor = System.Drawing.Color.White;
            ini_user.BaseColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            ini_user.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            ini_user.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            ini_user.Font = new System.Drawing.Font("Segoe UI", 10F);
            ini_user.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            ini_user.Hint = "";
            ini_user.Location = new System.Drawing.Point(35, 101);
            ini_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ini_user.MaxLength = 32767;
            ini_user.Multiline = false;
            ini_user.Name = "ini_user";
            ini_user.PasswordChar = '\0';
            ini_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            ini_user.SelectedText = "";
            ini_user.SelectionLength = 0;
            ini_user.SelectionStart = 0;
            ini_user.Size = new System.Drawing.Size(280, 34);
            ini_user.TabIndex = 2;
            ini_user.TabStop = false;
            ini_user.UseSystemPasswordChar = false;
            ini_user.Click += txtUser_Click;
            ini_user.TextChanged += ini_user_TextChanged;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = System.Drawing.Color.Transparent;
            lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)120)), ((int)((byte)120)));
            lblPass.Location = new System.Drawing.Point(35, 146);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(66, 17);
            lblPass.TabIndex = 3;
            lblPass.Text = "Mật khẩu";
            // 
            // Password_form
            // 
            Password_form.BackColor = System.Drawing.Color.White;
            Password_form.BaseColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            Password_form.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            Password_form.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            Password_form.Font = new System.Drawing.Font("Segoe UI", 10F);
            Password_form.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            Password_form.Hint = "";
            Password_form.Location = new System.Drawing.Point(35, 165);
            Password_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Password_form.MaxLength = 32767;
            Password_form.Multiline = false;
            Password_form.Name = "Password_form";
            Password_form.PasswordChar = '\0';
            Password_form.ScrollBars = System.Windows.Forms.ScrollBars.None;
            Password_form.SelectedText = "";
            Password_form.SelectionLength = 0;
            Password_form.SelectionStart = 0;
            Password_form.Size = new System.Drawing.Size(219, 34);
            Password_form.TabIndex = 4;
            Password_form.TabStop = false;
            Password_form.UseSystemPasswordChar = true;
            Password_form.TextChanged += Password_form_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = System.Drawing.Color.Transparent;
            checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            checkBox1.Location = new System.Drawing.Point(262, 171);
            checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(51, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = " Hiện";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.DangerColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)108)), ((int)((byte)108)));
            btnLogin.DefaultColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            btnLogin.HoverTextColor = System.Drawing.Color.White;
            btnLogin.InfoColor = System.Drawing.Color.FromArgb(((int)((byte)144)), ((int)((byte)147)), ((int)((byte)153)));
            btnLogin.Location = new System.Drawing.Point(35, 237);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)180)), ((int)((byte)40)));
            btnLogin.Size = new System.Drawing.Size(280, 32);
            btnLogin.SuccessColor = System.Drawing.Color.FromArgb(((int)((byte)103)), ((int)((byte)194)), ((int)((byte)58)));
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.TextColor = System.Drawing.Color.White;
            btnLogin.WarningColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)162)), ((int)((byte)60)));
            btnLogin.Click += button_check_loggin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            btnRegister.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegister.DangerColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)108)), ((int)((byte)108)));
            btnRegister.DefaultColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            btnRegister.HoverTextColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            btnRegister.InfoColor = System.Drawing.Color.FromArgb(((int)((byte)144)), ((int)((byte)147)), ((int)((byte)153)));
            btnRegister.Location = new System.Drawing.Point(33, 287);
            btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.PrimaryColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)235)));
            btnRegister.Size = new System.Drawing.Size(280, 28);
            btnRegister.SuccessColor = System.Drawing.Color.FromArgb(((int)((byte)103)), ((int)((byte)194)), ((int)((byte)58)));
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            btnRegister.TextColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            btnRegister.WarningColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)162)), ((int)((byte)60)));
            btnRegister.Click += btnRegister_Click;
            // 
            // shadowPanel
            // 
            shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            shadowPanel.Location = new System.Drawing.Point(182, 51);
            shadowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            shadowPanel.Name = "shadowPanel";
            shadowPanel.Size = new System.Drawing.Size(350, 338);
            shadowPanel.TabIndex = 0;
            // 
            // login_form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)252)), ((int)((byte)255)));
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(700, 450);
            Controls.Add(glassPanel);
            Controls.Add(shadowPanel);
            Cursor = System.Windows.Forms.Cursors.Arrow;
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Hệ Thống";
            Load += login_form_Load;
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label anounce;

        private System.Windows.Forms.Panel glassPanel;
        private System.Windows.Forms.Panel shadowPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private ReaLTaiizor.Controls.HopeTextBox ini_user;
        private System.Windows.Forms.Label lblPass;
        private ReaLTaiizor.Controls.HopeTextBox Password_form;
        private System.Windows.Forms.CheckBox checkBox1;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
        private ReaLTaiizor.Controls.HopeButton btnRegister;

        #endregion
    }
}