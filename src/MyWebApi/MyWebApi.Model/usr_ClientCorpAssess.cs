using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_ClientCorpAssess
    /// </summary>
    [Serializable]
    public class usr_ClientCorpAssess
    {
                    
        ///<summary>
        ///客户评估报序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户准入申请序号
        ///</summary>
        public int ClientCorpApplyId { get; set; }
                    
        ///<summary>
        ///评估日期
        ///</summary>
        public DateTime AssessDate { get; set; }
                    
        ///<summary>
        ///授信额度
        ///</summary>
        public decimal CreditBala { get; set; }
                    
        ///<summary>
        ///信用期限天数
        ///</summary>
        public int CreditLimitDay { get; set; }
                    
        ///<summary>
        ///授信类型
        ///</summary>
        public int CreditType { get; set; }
                    
        ///<summary>
        ///信用评级
        ///</summary>
        public int CreditLevel { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///授信截止日
        ///</summary>
        public DateTime CreditCloseDate { get; set; }
                    
        ///<summary>
        ///是否重大风险
        ///</summary>
        public bool IsRisk { get; set; }
                    
        ///<summary>
        ///是否合作
        ///</summary>
        public bool IsCoop { get; set; }
                    
        ///<summary>
        ///币种
        ///</summary>
        public int CurrencyId { get; set; }
                    
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
                    
        ///<summary>
        ///业务员id
        ///</summary>
        public int TraderId { get; set; }
            }
}

