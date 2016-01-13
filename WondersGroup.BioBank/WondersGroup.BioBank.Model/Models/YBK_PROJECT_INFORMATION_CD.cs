using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    /// <summary>
    /// 项目信息样本临床诊断
    /// </summary>
    public partial class YBK_PROJECT_INFORMATION_CD
    {
        public long ID { get; set; }
        /// <summary>
        /// 样本申请ID
        /// </summary>
        public long XMID { get; set; }
        /// <summary>
        /// 样本临床诊断
        /// </summary>
        public string YBLCZD { get; set; }
        /// <summary>
        /// 样本临床诊断名称
        /// </summary>
        public string YBLCZDMC { get; set; }
        /// <summary>
        /// 创建员ID
        /// </summary>
        public int CJYID { get; set; }
        /// <summary>
        /// 创建员姓名
        /// </summary>
        public string CJYXM { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CJSJ { get; set; }
        /// <summary>
        /// 最近操作员ID
        /// </summary>
        public int ZJCZYID { get; set; }
        /// <summary>
        /// 最近操作员姓名
        /// </summary>
        public string ZJCZYXM { get; set; }
        /// <summary>
        /// 最近操作时间
        /// </summary>
        public System.DateTime ZJCZSJ { get; set; }
        /// <summary>
        /// 数据状态 1:有效 2:无效
        /// </summary>
        public string SJZT { get; set; }
    }
}
