using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using TruckingCalculator.Droid.Database;
using TruckingCalculator.Database;

using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(SQLiteDb))]

namespace TruckingCalculator.Droid.Database
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "TruckingCalculatorDb.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}