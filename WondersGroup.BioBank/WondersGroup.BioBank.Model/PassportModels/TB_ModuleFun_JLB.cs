using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class TB_ModuleFun_JLB
    {
        public int ID { get; set; }
        public Nullable<int> ModuleID { get; set; }
        public string FunMC { get; set; }
        public string FunDM { get; set; }
        public Nullable<int> PX { get; set; }
        public Nullable<System.DateTime> CZRQ { get; set; }
        public Nullable<System.DateTime> XGRQ { get; set; }
        public virtual TB_Module_JLB TB_Module_JLB { get; set; }
    }
}
