using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDM1._1.Models
{
    public class StyleItems
    {
        public int id { get; set; }
        public string path { get; set; }
        public int parentId { get; set; }
        public int view { get; set; }
    }
}