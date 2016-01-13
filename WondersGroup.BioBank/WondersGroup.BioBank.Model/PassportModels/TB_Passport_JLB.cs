using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class TB_Passport_JLB
    {
        public int ID { get; set; }
        public string ZH { get; set; }
        public string MM { get; set; }
        public Nullable<int> ZT { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> GQRQ { get; set; }
        public string CZRY { get; set; }
        public Nullable<System.DateTime> CJRQ { get; set; }
        public Nullable<System.DateTime> XGRQ { get; set; }
        public Nullable<int> LX { get; set; }
    }
}
