namespace manegment_device;

public interface ILogin_query
{
    public bool checking_user(string user_name, string password);
    public string GetUserRole(string user_name);
}