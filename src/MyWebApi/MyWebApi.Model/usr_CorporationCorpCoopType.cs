using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorporationCorpCoopType
    /// </summary>
    [Serializable]
    public class usr_CorporationCorpCoopType
    {
                    
        ///<summary>
        ///序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户序号
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///主体合作类型序号
        ///</summary>
        public int CorpCoopTypeId { get; set; }
                    
        ///<summary>
        ///主体合作类型名称
        ///</summary>
        public string CorpCoopTypeName { get; set; }
                    
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

