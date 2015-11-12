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

        public static string ConvertToAscii(string unicodeString)
        {
            List<string[]> listCharactors = new List<string[]>();
            string[] strA = { "a", "á", "à", "ả", "ã", "ạ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ" };
            string[] strE = { "e", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ" };
            string[] strI = { "i", "í", "ì", "ỉ", "ĩ", "ị" };
            string[] strO = { "o", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ" };
            string[] strU = { "u", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự" };

            string[] strY = { "y", "ý", "ỳ", "ỷ", "ỹ", "ỵ" };
            string[] strD = { "d", "đ" };

            listCharactors.Add(strA);
            listCharactors.Add(strE);
            listCharactors.Add(strI);
            listCharactors.Add(strO);
            listCharactors.Add(strU);
            listCharactors.Add(strY);
            listCharactors.Add(strD);

            foreach (string[] arr in listCharactors)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    unicodeString = unicodeString.Replace(arr[i], arr[0]);
                }
            }

            return unicodeString.ToLower();
        }
    }
}
