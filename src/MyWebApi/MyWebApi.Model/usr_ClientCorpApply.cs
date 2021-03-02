using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_ClientCorpApply
    /// </summary>
    [Serializable]
    public class usr_ClientCorpApply
    {
                    
        ///<summary>
        ///数据类型（客户准入、客户变更）
        ///</summary>
        public int ClientCorpApplyId { get; set; }
                    
        ///<summary>
        ///客户序号
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///申请日期
        ///</summary>
        public DateTime ApplyDate { get; set; }
                    
        ///<summary>
        ///申请部门
        ///</summary>
        public int DeptId { get; set; }
                    
        ///<summary>
        ///部门品种
        ///</summary>
        public int AssetId { get; set; }
                    
        ///<summary>
        ///申请人
        ///</summary>
        public int ApplierId { get; set; }
                    
        ///<summary>
        ///归属集团
        ///</summary>
        public int ClientId { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///主体名称
        ///</summary>
        public string CorpName { get; set; }
                    
        ///<summary>
        ///主体英文名称
        ///</summary>
        public string CorpEName { get; set; }
                    
        ///<summary>
        ///主体地址
        ///</summary>
        public string CorpAddress { get; set; }
                    
        ///<summary>
        ///主体英文地址
        ///</summary>
        public string CorpEAddress { get; set; }
                    
        ///<summary>
        ///法人代表
        ///</summary>
        public string LegalPerson { get; set; }
                    
        ///<summary>
        ///营业执照编号
        ///</summary>
        public string BusinessLicense { get; set; }
                    
        ///<summary>
        ///注册资本
        ///</summary>
        public decimal RegisteredCapital { get; set; }
                    
        ///<summary>
        ///实缴资本
        ///</summary>
        public decimal PaidCapital { get; set; }
                    
        ///<summary>
        ///注册时间
        ///</summary>
        public DateTime RegisteredDate { get; set; }
                    
        ///<summary>
        ///币种
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///联系人
        ///</summary>
        public string CorpContact { get; set; }
                    
        ///<summary>
        ///公司电话
        ///</summary>
        public string CorpTel { get; set; }
                    
        ///<summary>
        ///职位
        ///</summary>
        public string CorpPosition { get; set; }
                    
        ///<summary>
        ///地区
        ///</summary>
        public int AreaId { get; set; }
                    
        ///<summary>
        ///推荐方
        ///</summary>
        public string Recommender { get; set; }
                    
        ///<summary>
        ///规范程度
        ///</summary>
        public string NormLevel { get; set; }
                    
        ///<summary>
        ///是否购买保险
        ///</summary>
        public bool IsInsurance { get; set; }
                    
        ///<summary>
        ///是否自有车队
        ///</summary>
        public bool IsFleet { get; set; }
                    
        ///<summary>
        ///是否交割库
        ///</summary>
        public bool IsDeliveryStock { get; set; }
                    
        ///<summary>
        ///是否双方合作
        ///</summary>
        public bool IsCoop { get; set; }
                    
        ///<summary>
        ///是否授信
        ///</summary>
        public bool IsCredit { get; set; }
                    
        ///<summary>
        ///合作每次数量
        ///</summary>
        public decimal CoopTimeWeight { get; set; }
                    
        ///<summary>
        ///合作每月数量
        ///</summary>
        public decimal CoopMonthWeight { get; set; }
                    
        ///<summary>
        ///重量单位
        ///</summary>
        public int UnitId { get; set; }
                    
        ///<summary>
        ///物流公司
        ///</summary>
        public int LogProvider { get; set; }
                    
        ///<summary>
        ///运输天数
        ///</summary>
        public int TransportDay { get; set; }
                    
        ///<summary>
        ///运输路线
        ///</summary>
        public string TransportRoute { get; set; }
                    
        ///<summary>
        ///状态
        ///</summary>
        public int CorpStatus { get; set; }
                    
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
        ///城市
        ///</summary>
        public int CityId { get; set; }
                    
        ///<summary>
        ///传真号
        ///</summary>
        public string CorpFax { get; set; }
                    
        ///<summary>
        ///交易模式说明
        ///</summary>
        public string TradeTypeExplain { get; set; }
                    
        ///<summary>
        ///客户税号
        ///</summary>
        public string TaxRegisteredCode { get; set; }
                    
        ///<summary>
        ///开票地址电话
        ///</summary>
        public string InvoiceAddressTel { get; set; }
                    
        ///<summary>
        ///开票银行及账号
        ///</summary>
        public string InvoiceBankAccount { get; set; }
                    
        ///<summary>
        ///合同提供方
        ///</summary>
        public int ConProvider { get; set; }
                    
        ///<summary>
        ///数据类型(客户准入、客户变更)
        ///</summary>
        public int CorpApplyDataType { get; set; }
                    
        ///<summary>
        ///电话
        ///</summary>
        public string CorpTelNo { get; set; }
            }
}

