using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_QUESTIONNAIRE
    {
        public long WJID { get; set; }
        public string WJMC { get; set; }
        public long SSXM { get; set; }
        public string SSXMMC { get; set; }
        public int ZDRID { get; set; }
        public string ZDRGH { get; set; }
        public string ZDRXM { get; set; }
        public System.DateTime ZDSJ { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
