using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class YBK_DEVICE_INFORMATION_PICTURE
    {
        public long ID { get; set; }
        public long SBID { get; set; }
        public string TPDZ { get; set; }
        public int CJYID { get; set; }
        public string CJYXM { get; set; }
        public System.DateTime CJSJ { get; set; }
        public int ZJCZYID { get; set; }
        public string ZJCZYXM { get; set; }
        public System.DateTime ZJCZSJ { get; set; }
        public string SJZT { get; set; }
    }
}
