using BookDBApp;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Data.SqlClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Test DB!");

DbReader myReader = new DbReader();

myReader.Delete(108);

myReader.Add(new Author()
{ AuthorId = 108, AuthorName = "The best Author" });

myReader.Update(108, new Author() { AuthorName = "Move der" });

Console.WriteLine(myReader.Get(102).AuthorName);

foreach (Author author in myReader.GetAll())
{
    Console.WriteLine(author.AuthorName);
}

foreach (Book book in myReader._context.Books.ToList())
{
    Console.WriteLine(book.BookTitle + " - " + book.ISBN);
}

//SqlConnection sqlConn =
//    new SqlConnection("server=(localdb)\\MSSQLLocalDB;" +
//    "database=BookDB;" +
//    "integrated security=True;TrustServerCertificate=True");

//sqlConn.Open();

//SqlTransaction transaction = sqlConn.BeginTransaction();

//try
//{

//    SqlCommand sqlCommInsert =
//        new SqlCommand("INSERT INTO Authors " +
//        "(AuthorId, AuthorName)" +
//        "VALUES (106, 'nummer 106')", sqlConn, transaction);
//    Console.WriteLine("Inserted: " +
//        sqlCommInsert.ExecuteNonQuery());

//    SqlCommand sqlComm =
//        new SqlCommand("SELECT AuthorId, AuthorName " +
//        "FROM Authors", sqlConn, transaction);
//    SqlDataReader reader = sqlComm.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine("ID: " + reader["AuthorID"]);
//        Console.WriteLine("Name: " + reader["AuthorName"]);
//    }
//    reader.Close();

//    transaction.Commit();
//} catch (SqlException ex)
//{
//    transaction.Rollback();
//    Console.WriteLine("Exception occured: " + ex.Message);
//}

//sqlConn.Close();