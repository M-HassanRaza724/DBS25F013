using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SoftwareFirmManagement
{
    public sealed class DatabaseHelper : IDisposable
    {
        // Singleton implementation
        private static DatabaseHelper _instance;
        private static readonly object _lock = new object();

        // Database configuration (should be moved to config file)
        private const string ServerName = "127.0.0.1";
        private const string Port = "3306";
        private const string DatabaseName = "finalprojectdb3" +
            "";
        private const string DatabaseUser = "root";
        private const string DatabasePassword = "`1234567890-=";
        private readonly string _connectionString;

        // Private constructor
        private DatabaseHelper()
        {
            _connectionString = $"server={ServerName};port={Port};user={DatabaseUser};" +
                              $"database={DatabaseName};password={DatabasePassword};" +
                              "SslMode=Required;Pooling=true;" +
                              "MinPoolSize=5;MaxPoolSize=100;ConnectionTimeout=30;";
        }

        // Singleton instance accessor
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseHelper();
                        }
                    }
                }
                return _instance;
            }
        }

        // Gets an open database connection
        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        // Executes a query and returns a DataReader
        public MySqlDataReader GetData(string query)
        {
            var connection = GetConnection();
            var command = new MySqlCommand(query, connection);
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Executes a query and returns a DataTable
        public DataTable GetDataTable(string query)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Executes a non-query command (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                return command.ExecuteNonQuery();
            }
        }

        // Executes a scalar query
        public object ExecuteScalar(string query)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                return command.ExecuteScalar();
            }
        }

        // IDisposable implementation
        public void Dispose()
        {
            // Add cleanup logic if needed
        }


        public int Update(string query)
        {
            using (var connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, GetConnection()))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

    }
}