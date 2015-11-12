using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaDict.Entity
{
    public class Dictionary
    {
        public int ID { get; set; }
        public string KEY { get; set; }
        public string CONTENT { get; set; }
        public string KEY_ALT { get; set; }
        public string CONTENT_ALT { get; set; }
        public int VIEWS { get; set; }
        public string LAST_VIEW_DATE { get; set; }
        public int? CATEGORY_ID { get; set; }
        public string ATTACH_FILE_PATH { get; set; }
    }
}
