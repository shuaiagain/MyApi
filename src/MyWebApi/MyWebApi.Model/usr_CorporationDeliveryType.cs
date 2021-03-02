using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorporationDeliveryType
    /// </summary>
    [Serializable]
    public class usr_CorporationDeliveryType
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
        ///交付方式序号
        ///</summary>
        public int DeliveryTypeId { get; set; }
                    
        ///<summary>
        ///交付方式名称
        ///</summary>
        public string DeliveryTypeName { get; set; }
                    
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

