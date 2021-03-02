using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Corporation
    /// </summary>
    [Serializable]
    public class usr_Corporation
    {
                    
        ///<summary>
        ///公司序号
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///所属集团
        ///</summary>
        public int ClientId { get; set; }
                    
        ///<summary>
        ///公司代码
        ///</summary>
        public string CorpCode { get; set; }
                    
        ///<summary>
        ///公司名称
        ///</summary>
        public string CorpName { get; set; }
                    
        ///<summary>
        ///公司英文名称
        ///</summary>
        public string CorpEName { get; set; }
                    
        ///<summary>
        ///纳税人识别号
        ///</summary>
        public string TaxPayerId { get; set; }
                    
        ///<summary>
        ///公司全称
        ///</summary>
        public string CorpFullName { get; set; }
                    
        ///<summary>
        ///公司英文全称
        ///</summary>
        public string CorpFullEName { get; set; }
                    
        ///<summary>
        ///公司地址
        ///</summary>
        public string CorpAddress { get; set; }
                    
        ///<summary>
        ///公司地址(英文)
        ///</summary>
        public string CorpEAddress { get; set; }
                    
        ///<summary>
        ///公司电话
        ///</summary>
        public string CorpTel { get; set; }
                    
        ///<summary>
        ///公司传真
        ///</summary>
        public string CorpFax { get; set; }
                    
        ///<summary>
        ///公司邮编
        ///</summary>
        public string CorpZip { get; set; }
                    
        ///<summary>
        ///公司类型
        ///</summary>
        public int CorpType { get; set; }
                    
        ///<summary>
        ///营业执照注册号
        ///</summary>
        public string BusinessLicense { get; set; }
                    
        ///<summary>
        ///营业执照附件
        ///</summary>
        public int LicenseAttachId { get; set; }
                    
        ///<summary>
        ///注册资本
        ///</summary>
        public decimal RegisteredCapital { get; set; }
                    
        ///<summary>
        ///注册时间
        ///</summary>
        public DateTime RegisteredDate { get; set; }
                    
        ///<summary>
        ///经营范围
        ///</summary>
        public string BusinessScope { get; set; }
                    
        ///<summary>
        ///税务注册号
        ///</summary>
        public string TaxRegisteredCode { get; set; }
                    
        ///<summary>
        ///税务登记附件
        ///</summary>
        public int TaxAttachId { get; set; }
                    
        ///<summary>
        ///组织机构注册号
        ///</summary>
        public string OrganizationCode { get; set; }
                    
        ///<summary>
        ///组织机构附件
        ///</summary>
        public int OrganizationAttachId { get; set; }
                    
        ///<summary>
        ///是否己方公司
        ///</summary>
        public bool IsSelf { get; set; }
                    
        ///<summary>
        ///资本类型
        ///</summary>
        public int CapitalType { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string ControllingShareholder { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string LegalPerson { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string CorpContact { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public bool IsPaid { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public decimal PaidCapital { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CorpOrginId { get; set; }
                    
        ///<summary>
        ///公司状态
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
        ///最后修改人序号
        ///</summary>
        public int LastModifyId { get; set; }
                    
        ///<summary>
        ///最后修改时间
        ///</summary>
        public DateTime LastModifyTime { get; set; }
                    
        ///<summary>
        ///公司组序号
        ///</summary>
        public int CorpGroupId { get; set; }
                    
        ///<summary>
        ///公司简称
        ///</summary>
        public string CorpShortName { get; set; }
                    
        ///<summary>
        ///职位
        ///</summary>
        public string CorpPosition { get; set; }
                    
        ///<summary>
        ///是否购买保险
        ///</summary>
        public bool IsInsurance { get; set; }
                    
        ///<summary>
        ///规范程度
        ///</summary>
        public string NormLevel { get; set; }
                    
        ///<summary>
        ///是否自有车队
        ///</summary>
        public bool IsFleet { get; set; }
                    
        ///<summary>
        ///是否交割库
        ///</summary>
        public bool IsDeliveryStock { get; set; }
                    
        ///<summary>
        ///是否授信
        ///</summary>
        public bool IsCredit { get; set; }
                    
        ///<summary>
        ///双方是否合作
        ///</summary>
        public bool IsCoop { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string Recommender { get; set; }
                    
        ///<summary>
        ///地区
        ///</summary>
        public int AreaId { get; set; }
                    
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
        ///城市
        ///</summary>
        public int CityId { get; set; }
                    
        ///<summary>
        ///交易模式说明
        ///</summary>
        public string TradeTypeExplain { get; set; }
                    
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
        ///电话
        ///</summary>
        public string CorpTelNo { get; set; }
            }
}

