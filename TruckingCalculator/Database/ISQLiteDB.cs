using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TruckingCalculator.Database
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
