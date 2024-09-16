using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AssistantHeadman.Model
{
    public class DBContext
    {
       
        private readonly SQLiteConnection _connection;

        public DBContext(string path)
        {
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<User>();
        }

        public List<User> GetUsers() 
        {
            return _connection.Table<User>().ToList();
        }

        public int SaveUser(User user)
        {
            return _connection.Insert(user);
        }
        

    }
}
