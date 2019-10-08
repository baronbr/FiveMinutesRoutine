using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace FiveMinutesRoutines.Models
{
    public class SignUp_DataAcces
    {
        readonly SQLiteAsyncConnection _database;

        public SignUp_DataAcces(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SignUp_Data>().Wait();
        }

        public Task<List<SignUp_Data>> GetNotesAsync()
        {
            return _database.Table<SignUp_Data>().ToListAsync();
        }

        public Task<SignUp_Data> GetNoteAsync(int id)
        {
            return _database.Table<SignUp_Data>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        /*
        public Task<int> SaveNoteAsync(SignUp_Data note)
        {
            if (SignUp_Data.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }*/

        public Task<int> DeleteNoteAsync(SignUp_Data note)
        {
            return _database.DeleteAsync(note);
        }


    }
}
