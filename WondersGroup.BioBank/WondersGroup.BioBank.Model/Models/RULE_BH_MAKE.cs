using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class RULE_BH_MAKE
    {
        public int ID { get; set; }
        public string BHLX { get; set; }
        public string BHMC { get; set; }
        public string QZ { get; set; }
        public int QSZ { get; set; }
        public int DQZ { get; set; }
        public int KDZ { get; set; }
        public int CD { get; set; }
        public string DT_ZWF { get; set; }
        public string DT_Z { get; set; }
        public Nullable<int> DT_SFCZDQZ { get; set; }
    }
}
