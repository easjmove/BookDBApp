using System.Data.SqlClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SqlConnection sqlConn =
    new SqlConnection("server=(localdb)\\MSSQLLocalDB;" +
    "database=BookDB;" +
    "integrated security=True;TrustServerCertificate=True");

sqlConn.Open();

SqlCommand sqlCommInsert = 
    new SqlCommand("INSERT INTO Authors " +
    "(AuthorId, AuthorName)" +
    "VALUES (104, 'whatevernavn')", sqlConn);
Console.WriteLine("Inserted: " + 
    sqlCommInsert.ExecuteNonQuery());

SqlCommand sqlComm =
    new SqlCommand("SELECT AuthorId, AuthorName " +
    "FROM Authors", sqlConn);
SqlDataReader reader = sqlComm.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine("ID: " + reader["AuthorID"]);
    Console.WriteLine("Name: " + reader["AuthorName"]);
}
reader.Close();

sqlConn.Close();