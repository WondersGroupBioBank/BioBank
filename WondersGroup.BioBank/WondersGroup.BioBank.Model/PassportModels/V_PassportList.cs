using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class V_PassportList
    {
        public int ID { get; set; }
        public string ZH { get; set; }
        public Nullable<int> ZT { get; set; }
        public string XM { get; set; }
        public int XB { get; set; }
        public string ZC { get; set; }
        public string SYKS { get; set; }
        public string SYKSMC { get; set; }
        public string LXDH { get; set; }
        public string YX { get; set; }
        public Nullable<System.DateTime> CJRQ { get; set; }
        public string JSMC { get; set; }
        public int JSID { get; set; }
        public string GH { get; set; }
        public string SFZH { get; set; }
    }
}
