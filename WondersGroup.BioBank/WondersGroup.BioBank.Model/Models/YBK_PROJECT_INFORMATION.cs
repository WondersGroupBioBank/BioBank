using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    /// <summary>
    /// 项目基本信息
    /// </summary>
    public partial class YBK_PROJECT_INFORMATION
    {
        /// <summary>
        /// 项目编号
        /// </summary>
        public long XMID { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string XMMC { get; set; }
        /// <summary>
        /// 课题编号
        /// </summary>
        public string KTBH { get; set; }
        /// <summary>
        /// 资金来源
        /// </summary>
        public string ZJLY { get; set; }
        /// <summary>
        /// 资金来源名称
        /// </summary>
        public string ZJLYMC { get; set; }
        /// <summary>
        /// 实施金额
        /// </summary>
        public Nullable<decimal> SSJE { get; set; }
        /// <summary>
        /// 项目责任人ID
        /// </summary>
        public Nullable<int> XMFZRID { get; set; }
        /// <summary>
        /// 项目责任人工号
        /// </summary>
        public string XMFZRGH { get; set; }
        /// <summary>
        /// 醒目责任人姓名
        /// </summary>
        public string XMFZRXM { get; set; }
        /// <summary>
        /// 项目组成员
        /// </summary>
        public string XMZCY { get; set; }
        /// <summary>
        /// 病理诊断
        /// </summary>
        public string BLZD { get; set; }
        /// <summary>
        /// 课题起始时间
        /// </summary>
        public Nullable<System.DateTime> KTQSSJ { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LXDH { get; set; }
        /// <summary>
        /// 所属科室
        /// </summary>
        public Nullable<int> SSKS { get; set; }
        /// <summary>
        /// 所属科室名称
        /// </summary>
        public string SSKSMC { get; set; }
        /// <summary>
        /// 研究方案设计类型_实验性研究
        /// </summary>
        public string YJFASJLX_SYXYJ { get; set; }
        /// <summary>
        /// 研究方案设计类型_观察性研究
        /// </summary>
        public string YJFASJLX_GCXYJ { get; set; }
        /// <summary>
        /// 研究方案设计类型_回顾性分析
        /// </summary>
        public string YJFASJLX_HGXFX { get; set; }
        /// <summary>
        /// 研究方案设计类型_前瞻性分析
        /// </summary>
        public string YJFASJLX_QZXFX { get; set; }
        /// <summary>
        /// 样本类型_组织
        /// </summary>
        public string YBLX_ZZ { get; set; }
        /// <summary>
        /// 样本类型_血液
        /// </summary>
        public string YBLX_XY { get; set; }
        /// <summary>
        /// 样本类型_尿液
        /// </summary>
        public string YBLX_NY { get; set; }
        /// <summary>
        /// 样本类型_其他
        /// </summary>
        public string YBLX_QT { get; set; }
        /// <summary>
        /// 样本类型_其他名称
        /// </summary>
        public string YBLX_QTMC { get; set; }
        /// <summary>
        /// 组织样本采集方式_手术
        /// </summary>
        public string ZZYBCJFS_SS { get; set; }
        /// <summary>
        /// 组织样本采集方式_活检
        /// </summary>
        public string ZZYBCJFS_HJ { get; set; }
        /// <summary>
        /// 新鲜组织冻存样本
        /// </summary>
        public string XXZZDCYB { get; set; }
        /// <summary>
        /// 固定组织_石蜡样本
        /// </summary>
        public string GDZZSLYB { get; set; }
        /// <summary>
        /// 外周血非抗凝
        /// </summary>
        public Nullable<decimal> WZXFKN { get; set; }
        /// <summary>
        /// 外周血抗凝
        /// </summary>
        public Nullable<decimal> WZXKN { get; set; }
        /// <summary>
        /// 外周血抗凝类型EDTA
        /// </summary>
        public string WZXKNLXEDTA { get; set; }
        /// <summary>
        /// 外周血抗凝类型肝素
        /// </summary>
        public string WZXKNLXGS { get; set; }
        /// <summary>
        /// 外周血抗凝类型其它
        /// </summary>
        public string WZXKNLXQT { get; set; }
        /// <summary>
        /// 尿液
        /// </summary>
        public Nullable<decimal> NY { get; set; }
        /// <summary>
        /// 其它类型样本说明
        /// </summary>
        public string QTLXYBSM { get; set; }
        /// <summary>
        /// 二级管理协议是否签署
        /// </summary>
        public string EJGLXYSFXS { get; set; }
        /// <summary>
        /// 样本使用后结果反馈
        /// </summary>
        public string YBSYHJGFK { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string BZ { get; set; }
        /// <summary>
        /// 项目状态
        /// </summary>
        public string XMZT { get; set; }
        /// <summary>
        /// 审批人ID
        /// </summary>
        public Nullable<int> SPRID { get; set; }
        /// <summary>
        /// 审批人工号
        /// </summary>
        public string SPRGH { get; set; }
        /// <summary>
        /// 审批人姓名
        /// </summary>
        public string SPRXM { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public Nullable<System.DateTime> SPSJ { get; set; }
        public string SPWTGYY { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public Nullable<int> CJYID { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CJYXM { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<System.DateTime> CJSJ { get; set; }
        /// <summary>
        /// 最近操作员ID
        /// </summary>
        public Nullable<int> ZJCZYID { get; set; }
        /// <summary>
        /// 最近操作员姓名
        /// </summary>
        public string ZJCZYXM { get; set; }
        /// <summary>
        /// 最近操作时间
        /// </summary>
        public Nullable<System.DateTime> ZJCZSJ { get; set; }
        /// <summary>
        /// 数据状态 1：有效 2:无效
        /// </summary>
        public string SJZT { get; set; }
        /// <summary>
        /// 课题联络人ID
        /// </summary>
        public Nullable<int> KTLLRID { get; set; }
        /// <summary>
        /// 课题联络人工号
        /// </summary>
        public string KTLLRGH { get; set; }
        /// <summary>
        /// 课题联络人姓名
        /// </summary>
        public string KTLLRXM { get; set; }
        /// <summary>
        /// 外周血抗凝类型枸橼酸钠
        /// </summary>
        public string WZXKNLXGYSN { get; set; }
        /// <summary>
        /// 外周血抗凝类型其他名称
        /// </summary>
        public string WZXKNLXQTMC { get; set; }
        /// <summary>
        /// 合作人姓名
        /// </summary>
        public string HZRXM { get; set; }
        /// <summary>
        /// 合作单位
        /// </summary>
        public string HZDW { get; set; }
    }
}
