using MySql.Data.MySqlClient;

void ConnectDb(string name) {
  string connectionString = "Server=localhost;Uid=root;Password=password;Database=test";
  MySqlConnection cnn = new MySqlConnection(connectionString);
  MySqlCommand cmd = new MySqlCommand();
  string query = "INSERT INTO users (name) VALUES(@p)";
  try
  {
    cnn.Open();
    Console.WriteLine("Db open");
    cmd.Connection = cnn;
    cmd.CommandText = query;
    cmd.Parameters.AddWithValue("p", name);
    cmd.ExecuteNonQuery();
    cnn.Close();
  }
  catch (System.Exception e)
  {
    Console.WriteLine(e.Message);
    throw;
  }
}

ConnectDb("pam");