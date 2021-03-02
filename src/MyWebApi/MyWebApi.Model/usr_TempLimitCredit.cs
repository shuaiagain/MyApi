using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_TempLimitCredit
    /// </summary>
    [Serializable]
    public class usr_TempLimitCredit
    {
                    
        ///<summary>
        ///临时额度授信序号
        ///</summary>
        public int TempLimitCreditId { get; set; }
                    
        ///<summary>
        ///申请日期
        ///</summary>
        public DateTime ApplyDate { get; set; }
                    
        ///<summary>
        ///合同号
        ///</summary>
        public string ContractNo { get; set; }
                    
        ///<summary>
        ///合同序号
        ///</summary>
        public int ContractId { get; set; }
                    
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
        ///授信截止日
        ///</summary>
        public DateTime CreditCloseDate { get; set; }
                    
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
        ///提供债权保障
        ///</summary>
        public bool IsEnsure { get; set; }
                    
        ///<summary>
        ///授信申请原因
        ///</summary>
        public string CreditCause { get; set; }
                    
        ///<summary>
        ///状态
        ///</summary>
        public int TempLimitCreditStatus { get; set; }
                    
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

