namespace manegment_device;

public static class Hash
{
    public static string HashPassword(string? password)
    {
        using (var sha = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }

    public static bool VerifyPassword(string password, string hash) => HashPassword(password) == hash;
}