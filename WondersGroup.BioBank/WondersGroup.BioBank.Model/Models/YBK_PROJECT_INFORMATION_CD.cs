using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    /// <summary>
    /// ��Ŀ��Ϣ�����ٴ����
    /// </summary>
    public partial class YBK_PROJECT_INFORMATION_CD
    {
        public long ID { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        public long XMID { get; set; }
        /// <summary>
        /// �����ٴ����
        /// </summary>
        public string YBLCZD { get; set; }
        /// <summary>
        /// �����ٴ��������
        /// </summary>
        public string YBLCZDMC { get; set; }
        /// <summary>
        /// ����ԱID
        /// </summary>
        public int CJYID { get; set; }
        /// <summary>
        /// ����Ա����
        /// </summary>
        public string CJYXM { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public System.DateTime CJSJ { get; set; }
        /// <summary>
        /// �������ԱID
        /// </summary>
        public int ZJCZYID { get; set; }
        /// <summary>
        /// �������Ա����
        /// </summary>
        public string ZJCZYXM { get; set; }
        /// <summary>
        /// �������ʱ��
        /// </summary>
        public System.DateTime ZJCZSJ { get; set; }
        /// <summary>
        /// ����״̬ 1:��Ч 2:��Ч
        /// </summary>
        public string SJZT { get; set; }
    }
}
