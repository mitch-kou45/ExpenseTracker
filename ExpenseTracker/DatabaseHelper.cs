using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DatabaseHelper
{
    private const string ConnectionString = "Data Source=ExpenseTracker.db;Version=3;";

    public static void InitializeDatabase()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Open();
        String tableCommand = @"CREATE TABLE IF NOT EXISTS Expenses (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Description TEXT NOT NULL,
                                Amount REAL NOT NULL,
                                Date TEXT NOT NULL)";
        using var CMD = new SQLiteCommand(tableCommand, connection);
        CMD.ExecuteNonQuery();
    }

    public static void AddExpense(Expense expense)
    {
    
    }


}