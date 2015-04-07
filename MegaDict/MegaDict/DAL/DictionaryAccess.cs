using MegaDict.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MegaDict.DAL
{
    public static class DictionaryAccess
    {
        internal static bool Insert(Entity.Dictionary dict)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["CATEGORY_ID"] = dict.CATEGORY_ID;
            dic["KEY"] = dict.KEY;
            dic["KEY_ALT"] = dict.KEY_ALT;
            dic["CONTENT"] = dict.CONTENT;
            dic["CONTENT_ALT"] = dict.CONTENT_ALT;
            return App.DB.Insert("Dictionary", dic)> 0;
        }

        internal static object Search(string key="", string categoryid="0")
        {
            string sql = string.Format("select * from dictionary where (key_alt like '%{0}%' or content_alt like '%{0}%') and (category_id = {1} or {1} = 0)", key, categoryid);
            return App.DB.Select(sql);
        }

        internal static bool Update(Entity.Dictionary dict)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            Dictionary<string, object> cond = new Dictionary<string, object>();
            dic["KEY"] = dict.KEY;
            dic["KEY_ALT"] = dict.KEY_ALT;
            dic["CONTENT"] = dict.CONTENT;
            dic["CONTENT_ALT"] = dict.CONTENT_ALT;

            cond["ID"] = dict.ID;
            return App.DB.Update("Dictionary", dic,cond) > 0;
        }

        internal static void UpdateView(int CURRENT_VIEW_ID)
        {
            string sql = string.Format("update Dictionary set views = views + 1, last_view_date = datetime('now') where id = {0}", CURRENT_VIEW_ID);
            App.DB.Select(sql);
        }

        internal static DataTable GetLastedViews()
        {
            string sql = string.Format("select * from Dictionary order by last_view_date desc limit 5");
            return App.DB.Select(sql);
        }

        internal static DataTable GetMostViews()
        {
            string sql = string.Format("select * from Dictionary order by views desc limit 5");
           return App.DB.Select(sql);
        }
    }
}
