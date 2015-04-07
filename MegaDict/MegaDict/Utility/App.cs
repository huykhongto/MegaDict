using EXMG.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDict.Utility
{
    public static class App
    {
        private static SQLiteHelper db = null;

        public static SQLiteHelper DB
        {
            get
            {
                if (db == null)
                    db = new SQLiteHelper();
                return db;
            }
        }
    }
}
