using System.ComponentModel;

namespace manegment_device;

partial class Home
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        Home_Form = new System.Windows.Forms.Label();
        label_welcome = new System.Windows.Forms.Label();
        Loggin_button = new System.Windows.Forms.Button();
        Sign_button = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Home_Form
        // 
        Home_Form.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Home_Form.Location = new System.Drawing.Point(36, 78);
        Home_Form.Name = "Home_Form";
        Home_Form.Size = new System.Drawing.Size(284, 21);
        Home_Form.TabIndex = 0;
        Home_Form.Text = "Home_Lab";
        // 
        // label_welcome
        // 
        label_welcome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label_welcome.Location = new System.Drawing.Point(36, 111);
        label_welcome.Name = "label_welcome";
        label_welcome.Size = new System.Drawing.Size(280, 28);
        label_welcome.TabIndex = 1;
        label_welcome.Text = "Chào Mừng đến với Home Lab";
        // 
        // Loggin_button
        // 
        Loggin_button.Location = new System.Drawing.Point(313, 251);
        Loggin_button.Name = "Loggin_button";
        Loggin_button.Size = new System.Drawing.Size(200, 43);
        Loggin_button.TabIndex = 2;
        Loggin_button.Text = "Đăng Nhập";
        Loggin_button.UseVisualStyleBackColor = true;
        Loggin_button.Click += Loggin_button_Click;
        // 
        // Sign_button
        // 
        Sign_button.Location = new System.Drawing.Point(313, 334);
        Sign_button.Name = "Sign_button";
        Sign_button.Size = new System.Drawing.Size(200, 47);
        Sign_button.TabIndex = 3;
        Sign_button.Text = "Đăng Ký ";
        Sign_button.UseVisualStyleBackColor = true;
        Sign_button.Click += Sign_button_Click_1;
        // 
        // Home
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(562, 450);
        Controls.Add(Sign_button);
        Controls.Add(Loggin_button);
        Controls.Add(label_welcome);
        Controls.Add(Home_Form);
        Text = "Home";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Loggin_button;
    private System.Windows.Forms.Button Sign_button;

    private System.Windows.Forms.Label label_welcome;

    private System.Windows.Forms.Label Home_Form;

    #endregion
}