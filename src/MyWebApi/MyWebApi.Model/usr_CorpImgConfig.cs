using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpImgConfig
    /// </summary>
    [Serializable]
    public class usr_CorpImgConfig
    {
                    
        ///<summary>
        ///
        ///</summary>
        public int CorpImgConfigId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int ParentCorpId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string LoginImgUrl { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string LogImgUrl { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string MainImgUrl { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CorpImgConfigStatus { get; set; }
                    
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

