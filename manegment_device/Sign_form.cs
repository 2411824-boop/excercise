using Timer = System.Windows.Forms.Timer;

namespace manegment_device;

public partial class Sign_form : Form
{
     user_backend user =  new user_backend();
     private readonly ILogin_query _loginQuery;
     private Timer fadeTimer;
    public Sign_form()
    {
        InitializeComponent();
        this.Opacity = 0; // Mặc định tàng hình
        fadeTimer = new Timer();
        fadeTimer.Interval = 15; // Tốc độ cập nhật 15ms
        fadeTimer.Tick += FadeTimer_Tick;
        CR_user.Text = "";
        CR_user.AccessibleDefaultActionDescription = "username";
        CR_pass.Text = "";
        CR_pass.AccessibleDefaultActionDescription = "password";
        CR_pass.UseSystemPasswordChar = true;
        Check_CR_pass.Text = "";
        Check_CR_pass.AccessibleDefaultActionDescription = "Check pass";
        Check_CR_pass.UseSystemPasswordChar = true;
        Back.Visible = false;
        annouce1.Visible = false;
        announce2.Visible = false;
        announce3.Visible = false;
        announce4.Visible = false;
    }
    private void FadeTimer_Tick(object sender, EventArgs e)
    {
        if (this.Opacity < 1.0)
        {
            this.Opacity += 0.05; // Tăng dần độ sáng
        }
        else
        {
            fadeTimer.Stop(); // Sáng hẳn 100% thì dừng Timer
        }
    }
 


    private void Sign_form_Load(object sender, EventArgs e)
    {
        fadeTimer.Start();
       
    }
    // Hanh dong click vao label se xoa moi thong tin trong label
    // cai nay se su dung mọt message lam chuan neu cho phép gan lay giá tri
    public void delete_space(object sender, EventArgs e)
    {
        
    }
    
    private void CR_user_TextChanged(object sender, EventArgs e)
    {
        try
        {
            user.Create_User = CR_user.Text;
            annouce1.Visible = false;
        }
        catch (Exception ex)
        {
            
               annouce1.Text = ex.Message == "Ten Da Ton Tai"
                    ? "Tên này đã tồn tại !"
                    : "tên này không được để trống !";
                annouce1.Visible = true;
            
        } 
    }
    // cái này sẻ đọc xử lý các tác vụ thông qua label cái này không cần phải set điều kiện giống như label tạo tên user 
    // vì nó đã được xử lý thông qua setter của user_backend;
    private void CR_pass_TextChanged(object sender, EventArgs e)
    {
        try
        {
            user.Create_Password = CR_pass.Text;
            announce2.Visible = false;
        }
        catch(Exception ex)
        {
            announce2.Text = ex.Message;
            announce2.Visible = true;
        }
    }

    private void Check_account_Click(object sender, EventArgs e)
    {
        
        //cái này sẻ check coi mấy cái thông báo còn không không cần check cả hàm để đưa ra chỉ thị tạo account 
        // điều kiện là một khi chỉ cần 1 trong 4 cái thông báo này còn tồn tại thì lệnh sẻ không được thực thi
        if (annouce1.Visible || announce2.Visible || announce4.Visible || user.Create_Password == null || user.Create_User == null)
        {
            return;
        }
        
        bool isInserted = Sign_query.Insert_user(user.Create_User,user.Create_Password,user.Role);
        
        if (isInserted) 
        {
            announce3.Visible  = true;
            Back.Visible = true;
        }  
        
        
    }

    private void announce3_Click(object sender, EventArgs e)
    {
        
    }

    private void annouce1_Click(object sender, EventArgs e)
    {
       
    }
    // cần hỏi chỗ new login query
    private void Back_TextChanged(object sender, EventArgs e)
    {
        login_form logform = new(new Login_query());
        logform.Show();
    }

    private void Check_CR_pass_TextChanged(object sender, EventArgs e)
    {
        if (Check_CR_pass.Text == CR_pass.Text)
        {
            announce4.Visible = false;
        }
        else
        {
            announce4.Text = "mật khẩu không khớp với mật khẩu đã nhập";
            announce4.Visible = true;
        }
    }
    // eyy không đụngvòa MT tui nha đg lm bài tập

    private void Back_Click(object sender, EventArgs e)
    {
        Back.Visible = true;
        login_form log = new login_form(this._loginQuery);
        this.Hide();
        log.ShowDialog();
        
    }

    private void eye1_CheckedChanged(object sender, EventArgs e)
    {
        if (eye1.Checked)
        {
            CR_pass.UseSystemPasswordChar = false;
        }
        else
        {
            
            CR_pass.UseSystemPasswordChar = true;
        }
    }


    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(eye2.Checked)

        {
            Check_CR_pass.UseSystemPasswordChar = false;
        }
        else
        {
            Check_CR_pass.UseSystemPasswordChar = true;
        }
    }

    private void announce2_Click(object sender, EventArgs e)
    {
        
    }

    private void announce4_Click(object sender, EventArgs e)
    {
        
    }

    private void Sign_Click(object sender, EventArgs e)
    {
        // "Sign_up" title label - not meant to do anything when clicked.
    }

    private void glassPanel_Paint(object sender, PaintEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}