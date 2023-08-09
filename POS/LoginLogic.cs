using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public class LoginLogic
{
    private string connectionString;

    public LoginLogic(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public bool VerifyLogin(string username, string password)
    {
        bool isValidLogin = false;

        string hashedPassword = HashPassword(password);

        // Set up the query
        string query = "SELECT COUNT(*) FROM UserDetail WHERE Username = @Username AND Password = @Password";

        // Create a connection and command
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                // Open the connection
                connection.Open();

                // Execute the query
                int result = (int)command.ExecuteScalar();

                // Check if the query returned a match
                isValidLogin = (result > 0);
            }
        }

        return isValidLogin;
    }

    private string HashPassword(string password)
    {
        // Create a SHA-256 hash object
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
