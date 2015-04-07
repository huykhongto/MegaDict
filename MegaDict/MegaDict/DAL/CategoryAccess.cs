using MegaDict.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MegaDict.DAL
{
    public static class CategoryAccess
    {
        public static DataTable Read()
        {
            string sql = "select * from Category";
            return App.DB.Select(sql);
        }

        internal static DataTable Read_AddEmptyRow()
        {
            DataTable dt = Read();
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "-All-";
                dt.Rows.InsertAt(dr, 0);
            }

            return dt;
        }

        internal static int Save(Entity.Category ent)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["NAME"] = ent.NAME;

            Dictionary<string, object> cond = new Dictionary<string, object>();
            cond["ID"] = ent.ID;
            if (App.DB.Update("Category", dic, cond) == 0)
            {
                App.DB.Insert("Category", dic);
            }

            if (ent.ID == 0)
                return GetLastID("Category");
            else
                return ent.ID;
        }

        private static int GetLastID(string p)
        {
            string sql = string.Format("select max(id) from {0}", p);
            DataTable dt = App.DB.Select(sql);
            if(dt!=null && dt.Rows.Count == 1)
                return int.Parse(dt.Rows[0][0].ToString());
            return 1;
        }

        internal static void Delete(string id)
        {
            Dictionary<string, object> cond = new Dictionary<string, object>();
            cond["ID"] = id;
            App.DB.Delete("Category", cond);
        }
    }
}
