using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_SAMPLE_PIPE_INFO
    {
        public long FGID { get; set; }
        public long YBSQMXID { get; set; }
        public long YBSQID { get; set; }
        public string YBLXDM { get; set; }
        public string YBLXMC { get; set; }
        public int GS { get; set; }
        public string BZ { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
