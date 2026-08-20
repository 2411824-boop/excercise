namespace manegment_device;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
        
    }
    
    private void Loggin_button_Click(object sender, EventArgs e)
    {
        login_form log =  new(new Login_query());
        this.Hide();
        log.ShowDialog();
    }
    private void Sign_button_Click_1(object sender, EventArgs e)
    {
        Sign_form sign_form =new();
        this.Hide();
        sign_form.ShowDialog();
    }
}