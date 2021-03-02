using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_ClientCorpApplyCredit
    /// </summary>
    [Serializable]
    public class usr_ClientCorpApplyCredit
    {
                    
        ///<summary>
        ///准入申请授信序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户准入申请序号
        ///</summary>
        public int ClientCorpApplyId { get; set; }
                    
        ///<summary>
        ///授信额度
        ///</summary>
        public decimal CreditBala { get; set; }
                    
        ///<summary>
        ///币种
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///信用期限天数
        ///</summary>
        public int CreditLimitDay { get; set; }
                    
        ///<summary>
        ///授信类型
        ///</summary>
        public int CreditType { get; set; }
                    
        ///<summary>
        ///授信形式
        ///</summary>
        public int CreditStyle { get; set; }
                    
        ///<summary>
        ///收付比例
        ///</summary>
        public decimal RPRatio { get; set; }
                    
        ///<summary>
        ///最近拜访时间
        ///</summary>
        public DateTime RecentVisitDate { get; set; }
                    
        ///<summary>
        ///提供债权保障
        ///</summary>
        public bool IsEnsure { get; set; }
                    
        ///<summary>
        ///授信申请原因
        ///</summary>
        public string CreditCause { get; set; }
                    
        ///<summary>
        ///授信截止日
        ///</summary>
        public DateTime CreditCloseDate { get; set; }
                    
        ///<summary>
        ///状态
        ///</summary>
        public int DetailStatus { get; set; }
                    
        ///<summary>
        ///创建人序号
        ///</summary>
        public int CreatorId { get; set; }
                    
        ///<summary>
        ///创建时间
        ///</summary>
        public DateTime CreateTime { get; set; }
                    
        ///<summary>
        ///最后修改时间
        ///</summary>
        public DateTime LastModifyTime { get; set; }
                    
        ///<summary>
        ///最后修改人序号
        ///</summary>
        public int LastModifyId { get; set; }
            }
}

