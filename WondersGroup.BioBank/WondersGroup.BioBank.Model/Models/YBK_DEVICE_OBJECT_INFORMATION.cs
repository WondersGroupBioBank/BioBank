using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_DEVICE_OBJECT_INFORMATION
    {
        public long KJDXID { get; set; }
        public int KJLXID { get; set; }
        public string KJLX { get; set; }
        public string KJLXMC { get; set; }
        public string DXBH { get; set; }
        public Nullable<long> SZKJXXID { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
