namespace manegment_device;

public partial class login_form : Form
{   
    private readonly ILogin_query _loginQuery;
    public login_form(ILogin_query Login_query)
    {
   
        InitializeComponent();
        _loginQuery = Login_query; 
        anounce.Visible = false;
        ini_user.Text = "";
        ini_user.Hint = "username";
        Password_form.Text = "";
        Password_form.Hint = "password";
        Password_form.UseSystemPasswordChar = true;

    }
    


    private void Designer_Click(object sender, EventArgs e)
    {
       
    }

    private void button_check_loggin_Click(object sender, EventArgs e)
    {
        try
        {
            string userName = ini_user.Text;
            string password = Password_form.Text;
            string hashedPassword = Hash.HashPassword(password);

            bool isSuccess = _loginQuery.checking_user(userName, hashedPassword);
            if (isSuccess)
            {
                
                anounce.Visible = false;
                Menuu menu = new();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
               anounce .Visible = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi thực thi: " + ex.Message);
        }
        
    }


    private void Password_form_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void ini_user_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void anounce_Click_1(object sender, EventArgs e)
    {
        
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            Password_form.UseSystemPasswordChar = false;
        }
        else
        {
            Password_form.UseSystemPasswordChar = true;
        }
    }

    private void login_form_Load(object sender, EventArgs e)
    {
       
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        
    }

    private void txtUser_Click(object sender, EventArgs e)
    {
       
    }

    private void glassPanel_Paint(object sender, PaintEventArgs e)
    {
        
    }
}