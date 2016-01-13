using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class TB_Module_JLB
    {
        public TB_Module_JLB()
        {
            this.TB_ModuleFun_JLB = new List<TB_ModuleFun_JLB>();
        }

        public int ID { get; set; }
        public string MC { get; set; }
        public Nullable<int> PX { get; set; }
        public Nullable<System.DateTime> CZRQ { get; set; }
        public Nullable<System.DateTime> XGRQ { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string LJ { get; set; }
        public Nullable<int> CC { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public virtual ICollection<TB_ModuleFun_JLB> TB_ModuleFun_JLB { get; set; }
    }
}
