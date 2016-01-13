using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    public partial class TB_PassportRole_GXB
    {
        public int ID { get; set; }
        public Nullable<int> PassportID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<System.DateTime> CZRQ { get; set; }
    }
}
