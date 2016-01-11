using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_SAMPLE_INFORMATION
    {
        public long YBID { get; set; }
        public string YBLXDM { get; set; }
        public string YBLXMC { get; set; }
        public long YBSQMXID { get; set; }
        public long YBSQID { get; set; }
        public Nullable<System.DateTime> CAIJSJ { get; set; }
        public Nullable<long> FGID { get; set; }
        public string TMID { get; set; }
        public Nullable<long> DQWZID { get; set; }
        public Nullable<long> FYBID { get; set; }
        public string YBZT { get; set; }
        public string YBZTMC { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
        public int LLZT { get; set; }
        public Nullable<decimal> YBTJ { get; set; }
        public Nullable<int> DRCS { get; set; }
        public string BZ { get; set; }
        public string SYZT { get; set; }
    }
}
