﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement
{
    public class DatabaseHelper
    {
        private String serverName = "127.0.0.1";
        private String port = "3306";
        private String databaseName = "db_final_project";
        private String databaseUser = "root";
        private String databasePassword = "1234567890-=1234567890-=";

        private DatabaseHelper() { }

        private static DatabaseHelper _instance;

        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }


        public MySqlConnection GetConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database ={databaseName}; password ={databasePassword}; SslMode = Required; ";
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }


        public MySqlDataReader GetData(string query)
        {
            using (var connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, GetConnection()))
                {
                    return command.ExecuteReader();
                }
            }
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


