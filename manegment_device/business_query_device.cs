using MySql.Data.MySqlClient;

namespace manegment_device;

public abstract class business_query_device
{
    private string constring = "Server=localhost;Database=device;Uid=root;Pwd=hoangduc2006b@";
     public bool insert_lake(string ten_ho)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = "INSERT INTO ho_nuoi (ten_ho) VALUES (@ten_ho)";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ten_ho", ten_ho);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    public bool ADD_lake_device(string tenHo, string maMay, string currentIp = "0.0.0.0")
    {
        using (MySqlConnection conn = new MySqlConnection(constring))
        {
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                string insertLake = "INSERT INTO ho_nuoi (ten_ho) VALUES (@TenHo)";
                int newLakeId = 0;

                using (MySqlCommand cmdLake = new MySqlCommand(insertLake, conn, transaction))
                {
                    cmdLake.Parameters.AddWithValue("@TenHo", tenHo);
                    cmdLake.ExecuteNonQuery();

                    // Lấy ra ID của Hồ vừa được tạo bằng hàm LAST_INSERT_ID() của MySQL
                    newLakeId = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", conn, transaction)
                        .ExecuteScalar());
                }

                //Thêm Thiết bị mới vào bảng thiet_bi và gán id của hồ vừa tạo
                string insertDeviceQuery =
                    "INSERT INTO thiet_bi (ma_may, ho_nuoi_id, current_ip, trang_thai) VALUES (@MaMay, @HoNuoiId, @Ip, 1)";
                using (MySqlCommand cmdDevice = new MySqlCommand(insertDeviceQuery, conn, transaction))
                {
                    cmdDevice.Parameters.AddWithValue("@MaMay", maMay);
                    cmdDevice.Parameters.AddWithValue("@HoNuoiId", newLakeId); // Gắn ID hồ vào thiết bị
                    cmdDevice.Parameters.AddWithValue("@Ip", currentIp);
                    cmdDevice.ExecuteNonQuery();
                }

                // Nếu mọi thứ thành công (cả Hồ và Máy đều tạo được), xác nhận lưu vào Database
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tạo Hồ và Máy: " + ex.Message);
                transaction.Rollback();
                return false;
            }
        }
    }
    public bool Add_Device_To_Existing_Lake(string maMay, int hoNuoiId, string currentIp = "0.0.0.0")
    {
        using (MySqlConnection conn = new MySqlConnection(constring))
        {
            conn.Open();
            string insertDeviceQuery = "INSERT INTO thiet_bi (ma_may, ho_nuoi_id, current_ip, trang_thai) VALUES (@MaMay, @HoNuoiId, @Ip, 1)";
            
            using (MySqlCommand cmdDevice = new MySqlCommand(insertDeviceQuery, conn))
            {
                cmdDevice.Parameters.AddWithValue("@MaMay", maMay);
                cmdDevice.Parameters.AddWithValue("@HoNuoiId", hoNuoiId);
                cmdDevice.Parameters.AddWithValue("@Ip", currentIp);
                
                int rowsAffected = cmdDevice.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    public bool Delete_lake(string tenHo)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string deleteLakeQuery = "DELETE FROM ho_nuoi WHERE ten_ho = @TenHo";

            using (MySqlCommand cmdLake = new MySqlCommand(deleteLakeQuery, connection))
            {
                cmdLake.Parameters.AddWithValue("@TenHo", tenHo);
                int rowsAffected = cmdLake.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    public bool delete_device(string maMay)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string deleteDeviceQuery = "DELETE FROM thiet_bi WHERE ma_may = @MaMay";
        
            using (MySqlCommand cmdDevice = new MySqlCommand(deleteDeviceQuery, connection))
            {
                cmdDevice.Parameters.AddWithValue("@MaMay", maMay);
                int rowsAffected = cmdDevice.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    public bool update_device(string maMay, int hoNuoiId, string currentIp, bool trangThai)
    {
        using (MySqlConnection connection = new MySqlConnection(constring))
        {
            connection.Open();
            string query = @"UPDATE thiet_bi 
                         SET ho_nuoi_id = @HoNuoiId,
                             current_ip = @CurrentIP, 
                             trang_thai = @TrangThai
                         WHERE ma_may = @MaMay";
                         
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MaMay", maMay);
                cmd.Parameters.AddWithValue("@HoNuoiId", hoNuoiId); // Chuyển thiết bị sang hồ khác nếu cần
                cmd.Parameters.AddWithValue("@CurrentIP", currentIp);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
            
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
   
}