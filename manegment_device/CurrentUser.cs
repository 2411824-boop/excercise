namespace manegment_device;

public class CurrentUser
{
    public static string Username { get; set; }
    public static string Role { get; set; } // Giá trị sẽ là "root" hoặc "member"

    public static void Logout()
    {
        Username = null;
        Role = null;
    }
}