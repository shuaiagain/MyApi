using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpLevel
    /// </summary>
    [Serializable]
    public class usr_CorpLevel
    {
                    
        ///<summary>
        ///客户等级序号
        ///</summary>
        public int LevelId { get; set; }
                    
        ///<summary>
        ///客户序号
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///采购评级
        ///</summary>
        public int PurchaseLevel { get; set; }
                    
        ///<summary>
        ///销售评级
        ///</summary>
        public int SaleLevel { get; set; }
                    
        ///<summary>
        ///评级额度
        ///</summary>
        public decimal LevelBala { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///客户等级状态
        ///</summary>
        public int LevelStatus { get; set; }
                    
        ///<summary>
        ///创建人序号
        ///</summary>
        public int CreatorId { get; set; }
                    
        ///<summary>
        ///创建时间
        ///</summary>
        public DateTime CreateTime { get; set; }
                    
        ///<summary>
        ///最后修改人序号
        ///</summary>
        public int LastModifyId { get; set; }
                    
        ///<summary>
        ///最后修改时间
        ///</summary>
        public DateTime LastModifyTime { get; set; }
                    
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
        ///授信截止日
        ///</summary>
        public DateTime CreditCloseDate { get; set; }
                    
        ///<summary>
        ///信用评级
        ///</summary>
        public int CreditLevel { get; set; }
                    
        ///<summary>
        ///是否重大风险
        ///</summary>
        public bool IsRisk { get; set; }
                    
        ///<summary>
        ///是否合作
        ///</summary>
        public bool IsCoop { get; set; }
            }
}

