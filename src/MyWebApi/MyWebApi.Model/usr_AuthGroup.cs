using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_AuthGroup
    /// </summary>
    [Serializable]
    public class usr_AuthGroup
    {
                    
        ///<summary>
        ///权限组序号
        ///</summary>
        public int AuthGroupId { get; set; }
                    
        ///<summary>
        ///权限组名称
        ///</summary>
        public string AuthGroupName { get; set; }
                    
        ///<summary>
        ///品种
        ///</summary>
        public int AssetId { get; set; }
                    
        ///<summary>
        ///贸易方向（进口，出口）
        ///</summary>
        public int TradeDirection { get; set; }
                    
        ///<summary>
        ///贸易方向（外贸，内贸）
        ///</summary>
        public int TradeBorder { get; set; }
                    
        ///<summary>
        ///内外部合同
        ///</summary>
        public int ContractInOut { get; set; }
                    
        ///<summary>
        ///合同长零单
        ///</summary>
        public int ContractLimit { get; set; }
                    
        ///<summary>
        ///公司序号
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///权限组状态
        ///</summary>
        public int AuthGroupStatus { get; set; }
                    
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
            }
}

