// See https://aka.ms/new-console-template for more information
using Blog;
using Blog.Screens;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=GStephano@1998*;TrustServerCertificate=true";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

Menu.Show();

Console.ReadKey();
Database.Connection.Close();
