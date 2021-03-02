using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Client
    /// </summary>
    [Serializable]
    public class usr_Client
    {
                    
        ///<summary>
        ///集团序号
        ///</summary>
        public int ClientId { get; set; }
                    
        ///<summary>
        ///集团名称
        ///</summary>
        public string ClientName { get; set; }
                    
        ///<summary>
        ///集团全称
        ///</summary>
        public string ClientFullName { get; set; }
                    
        ///<summary>
        ///集团英文名称
        ///</summary>
        public string ClientEname { get; set; }
                    
        ///<summary>
        ///是否己方集团
        ///</summary>
        public bool IsSelf { get; set; }
                    
        ///<summary>
        ///集团评级
        ///</summary>
        public int ClientLevel { get; set; }
                    
        ///<summary>
        ///集团状态
        ///</summary>
        public int ClientStatus { get; set; }
                    
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
        ///集团简称
        ///</summary>
        public string ClientShortName { get; set; }
                    
        ///<summary>
        ///集团授信额度
        ///</summary>
        public decimal ClientCreditBala { get; set; }
                    
        ///<summary>
        ///授信截止日期
        ///</summary>
        public DateTime CreditCloseDate { get; set; }
            }
}

