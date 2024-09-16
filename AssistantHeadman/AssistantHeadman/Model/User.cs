using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssistantHeadman.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; }

        public string Name { get; set; }

        public string Group { get; set; }

        
    }
}
