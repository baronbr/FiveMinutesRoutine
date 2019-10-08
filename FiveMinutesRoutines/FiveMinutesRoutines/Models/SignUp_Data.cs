using System;
using System.IO;
using CloudKit;
using SQLite;

namespace FiveMinutesRoutines
{

    [Table("Items")]
    public class SignUp_Data
    {



        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        
            }










}

