using System;
using System.Collections.Generic;
using System.Data.SQLite;

public static class DatabaseHelper
{
    private const string ConnectionString = "Data Source=ExpenseTracker.db;Version=3;";

    public static void InitializeDatabase()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Open();
        string tableCommand = @"CREATE TABLE IF NOT EXISTS Expenses (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Description TEXT NOT NULL,
                                Amount REAL NOT NULL,
                                Date TEXT NOT NULL)";
        using var cmd = new SQLiteCommand(tableCommand, connection);
        cmd.ExecuteNonQuery();
    }

    public static void AddExpense(Expense expense)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Open();
        string insertQuery = "INSERT INTO Expenses (Description, Amount, Date) VALUES (@desc, @amount, @date)";
        using var cmd = new SQLiteCommand(insertQuery, connection);
        cmd.Parameters.AddWithValue("@desc", expense.Description);
        cmd.Parameters.AddWithValue("@amount", expense.Amount);
        cmd.Parameters.AddWithValue("@date", expense.Date.ToString("yyyy-MM-dd"));
        cmd.ExecuteNonQuery();
    }

    public static List<Expense> GetAllExpenses()
    {
        var list = new List<Expense>();
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Open();
        string selectQuery = "SELECT * FROM Expenses";
        using var cmd = new SQLiteCommand(selectQuery, connection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Expense
            {
                Id = Convert.ToInt32(reader["Id"]),
                Description = reader["Description"].ToString(),
                Amount = Convert.ToDouble(reader["Amount"]),
                Date = DateTime.Parse(reader["Date"].ToString())
            });
        }

        return list;
    }
}
