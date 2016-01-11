using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_QUESTIONNAIRE_ATTRIBUTE
    {
        public long SXID { get; set; }
        public string SXMC { get; set; }
        public string SXLX { get; set; }
        public string SXLXMC { get; set; }
        public string SXMS { get; set; }
        public string ZLX { get; set; }
        public string ZLXMC { get; set; }
        public Nullable<int> ZCD { get; set; }
        public Nullable<int> ZJD { get; set; }
        public Nullable<decimal> ZDZ { get; set; }
        public Nullable<decimal> ZXZ { get; set; }
        public string SXLY { get; set; }
        public string SXLYMC { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
