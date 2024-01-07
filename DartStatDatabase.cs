using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Hejner_Balint_DartStat
{
    public class DartStatDatabase
    {
        SQLiteAsyncConnection Database;
    
        public DartStatDatabase()
        {

        }

        async Task Init()
        {
            if (Database is not null) return;
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<Round>();
        }

        public async Task<List<Round>> getItemsAsync()
        {
            Init();
            return Database.Table<Round>().ToListAsync().Result;
        }

        public async Task<int> SaveItemAsync(Round round)
        {
            await Init();
            return await Database.InsertAsync(round);
        }

        public async Task<int> DeleteItemAsync(Round round)
        {
            await Init();
            return await Database.DeleteAsync(round);
        }
    }
}
