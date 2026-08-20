using System.ComponentModel;

namespace manegment_device
{
    partial class Sign_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_form));
            glassPanel = new System.Windows.Forms.Panel();
            Sign = new System.Windows.Forms.Label();
            shadowPanel = new System.Windows.Forms.Panel();
            lblUser = new System.Windows.Forms.Label();
            CR_user = new ReaLTaiizor.Controls.HopeTextBox();
            annouce1 = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            CR_pass = new ReaLTaiizor.Controls.HopeTextBox();
            eye1 = new System.Windows.Forms.CheckBox();
            announce2 = new System.Windows.Forms.Label();
            lblCheckPass = new System.Windows.Forms.Label();
            Check_CR_pass = new ReaLTaiizor.Controls.HopeTextBox();
            eye2 = new System.Windows.Forms.CheckBox();
            announce4 = new System.Windows.Forms.Label();
            Check_account = new ReaLTaiizor.Controls.HopeButton();
            announce3 = new System.Windows.Forms.Label();
            Back = new ReaLTaiizor.Controls.HopeButton();
            glassPanel.SuspendLayout();
            SuspendLayout();
            // 
            // glassPanel
            // 
            glassPanel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)190)), ((int)((byte)255)), ((int)((byte)250)), ((int)((byte)235)));
            glassPanel.Controls.Add(Sign);
            glassPanel.Controls.Add(lblUser);
            glassPanel.Controls.Add(CR_user);
            glassPanel.Controls.Add(annouce1);
            glassPanel.Controls.Add(lblPass);
            glassPanel.Controls.Add(CR_pass);
            glassPanel.Controls.Add(eye1);
            glassPanel.Controls.Add(announce2);
            glassPanel.Controls.Add(lblCheckPass);
            glassPanel.Controls.Add(Check_CR_pass);
            glassPanel.Controls.Add(eye2);
            glassPanel.Controls.Add(announce4);
            glassPanel.Controls.Add(Check_account);
            glassPanel.Controls.Add(announce3);
            glassPanel.Controls.Add(Back);
            glassPanel.Location = new System.Drawing.Point(52, 34);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new System.Drawing.Size(450, 507);
            glassPanel.TabIndex = 1;
            glassPanel.Paint += glassPanel_Paint;
            // 
            // Sign
            // 
            Sign.AutoSize = true;
            Sign.BackColor = System.Drawing.Color.Transparent;
            Sign.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Sign.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            Sign.Location = new System.Drawing.Point(140, 20);
            Sign.Name = "Sign";
            Sign.Size = new System.Drawing.Size(146, 45);
            Sign.TabIndex = 0;
            Sign.Text = "Đăng Ký";
            Sign.Click += Sign_Click;
            // 
            // shadowPanel
            // 
            shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            shadowPanel.Location = new System.Drawing.Point(67, 48);
            shadowPanel.Name = "shadowPanel";
            shadowPanel.Size = new System.Drawing.Size(450, 507);
            shadowPanel.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = System.Drawing.Color.Transparent;
            lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)120)), ((int)((byte)120)));
            lblUser.Location = new System.Drawing.Point(45, 82);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(99, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tên đăng nhập";
            // 
            // CR_user
            // 
            CR_user.BackColor = System.Drawing.Color.White;
            CR_user.BaseColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            CR_user.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            CR_user.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            CR_user.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            CR_user.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            CR_user.Hint = "";
            CR_user.Location = new System.Drawing.Point(45, 106);
            CR_user.MaxLength = 32767;
            CR_user.Multiline = false;
            CR_user.Name = "CR_user";
            CR_user.PasswordChar = '\0';
            CR_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            CR_user.SelectedText = "";
            CR_user.SelectionLength = 0;
            CR_user.SelectionStart = 0;
            CR_user.Size = new System.Drawing.Size(350, 34);
            CR_user.TabIndex = 1;
            CR_user.TabStop = false;
            CR_user.UseSystemPasswordChar = false;
            CR_user.TextChanged += CR_user_TextChanged;
            // 
            // annouce1
            // 
            annouce1.AutoSize = true;
            annouce1.BackColor = System.Drawing.Color.Transparent;
            annouce1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            annouce1.ForeColor = System.Drawing.Color.Crimson;
            annouce1.Location = new System.Drawing.Point(45, 146);
            annouce1.Name = "annouce1";
            annouce1.Size = new System.Drawing.Size(110, 15);
            annouce1.TabIndex = 2;
            annouce1.Text = "Cảnh báo tài khoản";
            annouce1.Visible = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = System.Drawing.Color.Transparent;
            lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)120)), ((int)((byte)120)));
            lblPass.Location = new System.Drawing.Point(45, 168);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(66, 17);
            lblPass.TabIndex = 3;
            lblPass.Text = "Mật khẩu";
            // 
            // CR_pass
            // 
            CR_pass.BackColor = System.Drawing.Color.White;
            CR_pass.BaseColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            CR_pass.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            CR_pass.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            CR_pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            CR_pass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            CR_pass.Hint = "";
            CR_pass.Location = new System.Drawing.Point(45, 192);
            CR_pass.MaxLength = 32767;
            CR_pass.Multiline = false;
            CR_pass.Name = "CR_pass";
            CR_pass.PasswordChar = '\0';
            CR_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            CR_pass.SelectedText = "";
            CR_pass.SelectionLength = 0;
            CR_pass.SelectionStart = 0;
            CR_pass.Size = new System.Drawing.Size(275, 34);
            CR_pass.TabIndex = 3;
            CR_pass.TabStop = false;
            CR_pass.UseSystemPasswordChar = true;
            CR_pass.TextChanged += CR_pass_TextChanged;
            // 
            // eye1
            // 
            eye1.AutoSize = true;
            eye1.BackColor = System.Drawing.Color.Transparent;
            eye1.Cursor = System.Windows.Forms.Cursors.Hand;
            eye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eye1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            eye1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            eye1.Location = new System.Drawing.Point(328, 200);
            eye1.Name = "eye1";
            eye1.Size = new System.Drawing.Size(51, 19);
            eye1.TabIndex = 4;
            eye1.Text = " Hiện";
            eye1.UseVisualStyleBackColor = false;
            eye1.CheckedChanged += eye1_CheckedChanged;
            // 
            // announce2
            // 
            announce2.AutoSize = true;
            announce2.BackColor = System.Drawing.Color.Transparent;
            announce2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            announce2.ForeColor = System.Drawing.Color.Crimson;
            announce2.Location = new System.Drawing.Point(45, 232);
            announce2.Name = "announce2";
            announce2.Size = new System.Drawing.Size(111, 15);
            announce2.TabIndex = 5;
            announce2.Text = "Cảnh báo mật khẩu";
            announce2.Visible = false;
            // 
            // lblCheckPass
            // 
            lblCheckPass.AutoSize = true;
            lblCheckPass.BackColor = System.Drawing.Color.Transparent;
            lblCheckPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblCheckPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)120)), ((int)((byte)120)), ((int)((byte)120)));
            lblCheckPass.Location = new System.Drawing.Point(45, 254);
            lblCheckPass.Name = "lblCheckPass";
            lblCheckPass.Size = new System.Drawing.Size(126, 17);
            lblCheckPass.TabIndex = 6;
            lblCheckPass.Text = "Xác nhận mật khẩu";
            // 
            // Check_CR_pass
            // 
            Check_CR_pass.BackColor = System.Drawing.Color.White;
            Check_CR_pass.BaseColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            Check_CR_pass.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            Check_CR_pass.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            Check_CR_pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Check_CR_pass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            Check_CR_pass.Hint = "";
            Check_CR_pass.Location = new System.Drawing.Point(45, 278);
            Check_CR_pass.MaxLength = 32767;
            Check_CR_pass.Multiline = false;
            Check_CR_pass.Name = "Check_CR_pass";
            Check_CR_pass.PasswordChar = '\0';
            Check_CR_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            Check_CR_pass.SelectedText = "";
            Check_CR_pass.SelectionLength = 0;
            Check_CR_pass.SelectionStart = 0;
            Check_CR_pass.Size = new System.Drawing.Size(275, 34);
            Check_CR_pass.TabIndex = 6;
            Check_CR_pass.TabStop = false;
            Check_CR_pass.UseSystemPasswordChar = true;
            Check_CR_pass.TextChanged += Check_CR_pass_TextChanged;
            // 
            // eye2
            // 
            eye2.AutoSize = true;
            eye2.BackColor = System.Drawing.Color.Transparent;
            eye2.Cursor = System.Windows.Forms.Cursors.Hand;
            eye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            eye2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            eye2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            eye2.Location = new System.Drawing.Point(328, 286);
            eye2.Name = "eye2";
            eye2.Size = new System.Drawing.Size(51, 19);
            eye2.TabIndex = 7;
            eye2.Text = " Hiện";
            eye2.UseVisualStyleBackColor = false;
            eye2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // announce4
            // 
            announce4.AutoSize = true;
            announce4.BackColor = System.Drawing.Color.Transparent;
            announce4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            announce4.ForeColor = System.Drawing.Color.Crimson;
            announce4.Location = new System.Drawing.Point(45, 318);
            announce4.Name = "announce4";
            announce4.Size = new System.Drawing.Size(124, 15);
            announce4.TabIndex = 8;
            announce4.Text = "Mật khẩu không khớp";
            announce4.Visible = false;
            // 
            // Check_account
            // 
            Check_account.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            Check_account.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Check_account.Cursor = System.Windows.Forms.Cursors.Hand;
            Check_account.DangerColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)108)), ((int)((byte)108)));
            Check_account.DefaultColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            Check_account.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Check_account.HoverTextColor = System.Drawing.Color.White;
            Check_account.InfoColor = System.Drawing.Color.FromArgb(((int)((byte)144)), ((int)((byte)147)), ((int)((byte)153)));
            Check_account.Location = new System.Drawing.Point(45, 348);
            Check_account.Name = "Check_account";
            Check_account.PrimaryColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)180)), ((int)((byte)40)));
            Check_account.Size = new System.Drawing.Size(350, 42);
            Check_account.SuccessColor = System.Drawing.Color.FromArgb(((int)((byte)103)), ((int)((byte)194)), ((int)((byte)58)));
            Check_account.TabIndex = 9;
            Check_account.Text = "TẠO TÀI KHOẢN";
            Check_account.TextColor = System.Drawing.Color.White;
            Check_account.WarningColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)162)), ((int)((byte)60)));
            Check_account.Click += Check_account_Click;
            // 
            // announce3
            // 
            announce3.AutoSize = true;
            announce3.BackColor = System.Drawing.Color.Transparent;
            announce3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            announce3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            announce3.Location = new System.Drawing.Point(142, 395);
            announce3.Name = "announce3";
            announce3.Size = new System.Drawing.Size(143, 17);
            announce3.TabIndex = 10;
            announce3.Text = "Đăng Ký Thành Công!";
            announce3.Visible = false;
            // 
            // Back
            // 
            Back.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            Back.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Back.Cursor = System.Windows.Forms.Cursors.Hand;
            Back.DangerColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)108)), ((int)((byte)108)));
            Back.DefaultColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            Back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Back.HoverTextColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            Back.InfoColor = System.Drawing.Color.FromArgb(((int)((byte)144)), ((int)((byte)147)), ((int)((byte)153)));
            Back.Location = new System.Drawing.Point(45, 428);
            Back.Name = "Back";
            Back.PrimaryColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)235)));
            Back.Size = new System.Drawing.Size(350, 38);
            Back.SuccessColor = System.Drawing.Color.FromArgb(((int)((byte)103)), ((int)((byte)194)), ((int)((byte)58)));
            Back.TabIndex = 11;
            Back.Text = "Trở về đăng nhập";
            Back.TextColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)100)), ((int)((byte)100)));
            Back.WarningColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)162)), ((int)((byte)60)));
            Back.Click += Back_Click;
            // 
            // Sign_form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)252)), ((int)((byte)255)));
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(560, 587);
            Controls.Add(glassPanel);
            Controls.Add(shadowPanel);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
            Load += Sign_form_Load;
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel glassPanel;
        private System.Windows.Forms.Panel shadowPanel;
        
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblCheckPass;
        private System.Windows.Forms.CheckBox eye1;
        private System.Windows.Forms.CheckBox eye2;
        private ReaLTaiizor.Controls.HopeButton Back;
        private System.Windows.Forms.Label announce4;
        private System.Windows.Forms.Label announce3;
        private System.Windows.Forms.Label announce2;
        private System.Windows.Forms.Label annouce1;
        private ReaLTaiizor.Controls.HopeTextBox CR_user;
        private ReaLTaiizor.Controls.HopeTextBox CR_pass;
        private ReaLTaiizor.Controls.HopeTextBox Check_CR_pass;
        private ReaLTaiizor.Controls.HopeButton Check_account;
        private System.Windows.Forms.Label Sign;

        #endregion
    }
}