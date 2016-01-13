using System;
using System.Collections.Generic;

namespace WondersGroup.BioBank.Model.Models
{
    /// <summary>
    /// ��Ŀ������Ϣ
    /// </summary>
    public partial class YBK_PROJECT_INFORMATION
    {
        /// <summary>
        /// ��Ŀ���
        /// </summary>
        public long XMID { get; set; }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string XMMC { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string KTBH { get; set; }
        /// <summary>
        /// �ʽ���Դ
        /// </summary>
        public string ZJLY { get; set; }
        /// <summary>
        /// �ʽ���Դ����
        /// </summary>
        public string ZJLYMC { get; set; }
        /// <summary>
        /// ʵʩ���
        /// </summary>
        public Nullable<decimal> SSJE { get; set; }
        /// <summary>
        /// ��Ŀ������ID
        /// </summary>
        public Nullable<int> XMFZRID { get; set; }
        /// <summary>
        /// ��Ŀ�����˹���
        /// </summary>
        public string XMFZRGH { get; set; }
        /// <summary>
        /// ��Ŀ����������
        /// </summary>
        public string XMFZRXM { get; set; }
        /// <summary>
        /// ��Ŀ���Ա
        /// </summary>
        public string XMZCY { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string BLZD { get; set; }
        /// <summary>
        /// ������ʼʱ��
        /// </summary>
        public Nullable<System.DateTime> KTQSSJ { get; set; }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string LXDH { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public Nullable<int> SSKS { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        public string SSKSMC { get; set; }
        /// <summary>
        /// �о������������_ʵ�����о�
        /// </summary>
        public string YJFASJLX_SYXYJ { get; set; }
        /// <summary>
        /// �о������������_�۲����о�
        /// </summary>
        public string YJFASJLX_GCXYJ { get; set; }
        /// <summary>
        /// �о������������_�ع��Է���
        /// </summary>
        public string YJFASJLX_HGXFX { get; set; }
        /// <summary>
        /// �о������������_ǰհ�Է���
        /// </summary>
        public string YJFASJLX_QZXFX { get; set; }
        /// <summary>
        /// ��������_��֯
        /// </summary>
        public string YBLX_ZZ { get; set; }
        /// <summary>
        /// ��������_ѪҺ
        /// </summary>
        public string YBLX_XY { get; set; }
        /// <summary>
        /// ��������_��Һ
        /// </summary>
        public string YBLX_NY { get; set; }
        /// <summary>
        /// ��������_����
        /// </summary>
        public string YBLX_QT { get; set; }
        /// <summary>
        /// ��������_��������
        /// </summary>
        public string YBLX_QTMC { get; set; }
        /// <summary>
        /// ��֯�����ɼ���ʽ_����
        /// </summary>
        public string ZZYBCJFS_SS { get; set; }
        /// <summary>
        /// ��֯�����ɼ���ʽ_���
        /// </summary>
        public string ZZYBCJFS_HJ { get; set; }
        /// <summary>
        /// ������֯��������
        /// </summary>
        public string XXZZDCYB { get; set; }
        /// <summary>
        /// �̶���֯_ʯ������
        /// </summary>
        public string GDZZSLYB { get; set; }
        /// <summary>
        /// ����Ѫ�ǿ���
        /// </summary>
        public Nullable<decimal> WZXFKN { get; set; }
        /// <summary>
        /// ����Ѫ����
        /// </summary>
        public Nullable<decimal> WZXKN { get; set; }
        /// <summary>
        /// ����Ѫ��������EDTA
        /// </summary>
        public string WZXKNLXEDTA { get; set; }
        /// <summary>
        /// ����Ѫ�������͸���
        /// </summary>
        public string WZXKNLXGS { get; set; }
        /// <summary>
        /// ����Ѫ������������
        /// </summary>
        public string WZXKNLXQT { get; set; }
        /// <summary>
        /// ��Һ
        /// </summary>
        public Nullable<decimal> NY { get; set; }
        /// <summary>
        /// ������������˵��
        /// </summary>
        public string QTLXYBSM { get; set; }
        /// <summary>
        /// ��������Э���Ƿ�ǩ��
        /// </summary>
        public string EJGLXYSFXS { get; set; }
        /// <summary>
        /// ����ʹ�ú�������
        /// </summary>
        public string YBSYHJGFK { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string BZ { get; set; }
        /// <summary>
        /// ��Ŀ״̬
        /// </summary>
        public string XMZT { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        public Nullable<int> SPRID { get; set; }
        /// <summary>
        /// �����˹���
        /// </summary>
        public string SPRGH { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string SPRXM { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public Nullable<System.DateTime> SPSJ { get; set; }
        public string SPWTGYY { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        public Nullable<int> CJYID { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string CJYXM { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public Nullable<System.DateTime> CJSJ { get; set; }
        /// <summary>
        /// �������ԱID
        /// </summary>
        public Nullable<int> ZJCZYID { get; set; }
        /// <summary>
        /// �������Ա����
        /// </summary>
        public string ZJCZYXM { get; set; }
        /// <summary>
        /// �������ʱ��
        /// </summary>
        public Nullable<System.DateTime> ZJCZSJ { get; set; }
        /// <summary>
        /// ����״̬ 1����Ч 2:��Ч
        /// </summary>
        public string SJZT { get; set; }
        /// <summary>
        /// ����������ID
        /// </summary>
        public Nullable<int> KTLLRID { get; set; }
        /// <summary>
        /// ���������˹���
        /// </summary>
        public string KTLLRGH { get; set; }
        /// <summary>
        /// ��������������
        /// </summary>
        public string KTLLRXM { get; set; }
        /// <summary>
        /// ����Ѫ����������������
        /// </summary>
        public string WZXKNLXGYSN { get; set; }
        /// <summary>
        /// ����Ѫ����������������
        /// </summary>
        public string WZXKNLXQTMC { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string HZRXM { get; set; }
        /// <summary>
        /// ������λ
        /// </summary>
        public string HZDW { get; set; }
    }
}
