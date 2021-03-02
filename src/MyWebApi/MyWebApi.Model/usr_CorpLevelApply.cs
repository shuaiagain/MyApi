using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpLevelApply
    /// </summary>
    [Serializable]
    public class usr_CorpLevelApply
    {
                    
        ///<summary>
        ///申请序号
        ///</summary>
        public int ApplyId { get; set; }
                    
        ///<summary>
        ///申请人
        ///</summary>
        public int Applier { get; set; }
                    
        ///<summary>
        ///申请时间
        ///</summary>
        public DateTime ApplyDate { get; set; }
                    
        ///<summary>
        ///申请部门
        ///</summary>
        public int ApplyDeptId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///公司名称
        ///</summary>
        public string CorpName { get; set; }
                    
        ///<summary>
        ///公司英文名称
        ///</summary>
        public string CorpEName { get; set; }
                    
        ///<summary>
        ///公司地址
        ///</summary>
        public string CorpAddress { get; set; }
                    
        ///<summary>
        ///公司地址(英文)
        ///</summary>
        public string CorpEAddress { get; set; }
                    
        ///<summary>
        ///法人代表
        ///</summary>
        public string LegalPerson { get; set; }
                    
        ///<summary>
        ///证照编号
        ///</summary>
        public string BusinessLicense { get; set; }
                    
        ///<summary>
        ///注册日期
        ///</summary>
        public DateTime RegisteredDate { get; set; }
                    
        ///<summary>
        ///注册资本
        ///</summary>
        public decimal RegisteredCapital { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public decimal PaidCapital { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string CorpContact { get; set; }
                    
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
        ///部门额度
        ///</summary>
        public decimal DeptBala { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///申请类型
        ///</summary>
        public int ApplyType { get; set; }
                    
        ///<summary>
        ///申请状态
        ///</summary>
        public int ApplyStatus { get; set; }
                    
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
        ///
        ///</summary>
        public int ClientId { get; set; }
            }
}

