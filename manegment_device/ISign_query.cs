namespace manegment_device;

public interface ISign_query
{
    public bool checking_user_sign(string value);
    public  bool Insert_user(string user_name, string password, string Role);
}