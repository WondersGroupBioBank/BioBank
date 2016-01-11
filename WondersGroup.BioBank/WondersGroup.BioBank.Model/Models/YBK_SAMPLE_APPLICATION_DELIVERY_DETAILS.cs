using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_SAMPLE_APPLICATION_DELIVERY_DETAILS
    {
        public long YBID { get; set; }
        public long CKSQMXID { get; set; }
        public long CKSQID { get; set; }
        public string SFHK { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
