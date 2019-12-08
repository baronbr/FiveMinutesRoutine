using System;
using SQLite;

namespace FiveMinutesRoutines.Models
{
    public class Test
    {
       

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string LName { get; set; }
    }
}
