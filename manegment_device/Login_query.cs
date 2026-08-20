using MySql.Data.MySqlClient;
using System.Data;

namespace manegment_device;

public class Login_query:ILogin_query
{
    string constring = "Server=localhost;Database=device;Uid=root;Pwd=hoangduc2006B@";


    public bool checking_user(string user_name, string password)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "SELECT COUNT(1) FROM user WHERE user_name = @user AND password = @pass";
            
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@user", user_name);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
    }
    public string GetUserRole(string user_name)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "SELECT Role FROM user WHERE user_name = @user";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@user", user_name);
                object result = cmd.ExecuteScalar();
                return result == null ? "member" : result.ToString();
            }
        }
    }
  
    public bool Delete_user(string username)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "DELETE FROM user WHERE user_name = @user";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@user", username);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    public DataTable GetAllUsers()
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "SELECT user_name, Role FROM user";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
    public bool UpdateUserRole(string username, string newRole)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "UPDATE user SET Role = @Role WHERE user_name = @Username";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Role", newRole);
                cmd.Parameters.AddWithValue("@Username", username);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    // đẻ conect và insert các thông số có trong thiết bị vào database
    /* public bool insert_info_to_ThongSo(int ID,string Ma_may, float Nong_do_pH, float Tds, float Nhiet_do, TimeSpan ThoiGian)
     {
         using (MySqlConnection connection = new MySqlConnection(constring))
         {
             connection.Open();
             string query =
                 "INSERT INTO thong_so (id,ma_may,nong_do_pH,Tds,nhiet_do,thoi_gian_do) VALUES (@ID,@Ma_may,@Nong_do_pH,@Tds,@Nhiet_do,@ThoiGian)";
             using (MySqlCommand cmd = new MySqlCommand(query, connection))
             {
                 cmd.Parameters.AddWithValue("@ID", ID);
                 cmd.Parameters.AddWithValue("@Ma_may", Ma_may);
                 cmd.Parameters.AddWithValue("@Nong_do_pH", Nong_do_pH);
                 cmd.Parameters.AddWithValue("@Tds", Tds);
                 cmd.Parameters.AddWithValue("@Nhiet_do", Nhiet_do);
                 cmd.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                 int rowsAffected = cmd.ExecuteNonQuery();
                 return rowsAffected > 0;

             }
         }
     }*/
    // dữ liệu sẻ được lấy trực tiếp từ thiết bị nên chỉ query từ database rồi xuất ra màn hinh quẻy này phục vụ search history 

   
    
}