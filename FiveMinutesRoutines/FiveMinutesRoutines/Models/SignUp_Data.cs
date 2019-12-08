using System;
using System.IO;
//using CloudKit;
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
        public string Age { get; set; }
        public string Gender { get; set; }
        
        
            }










}

