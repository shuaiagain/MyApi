using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpGroup
    /// </summary>
    [Serializable]
    public class usr_CorpGroup
    {
                    
        ///<summary>
        ///公司组序号
        ///</summary>
        public int CorpGroupId { get; set; }
                    
        ///<summary>
        ///第一公司序号
        ///</summary>
        public int FirstCorpId { get; set; }
                    
        ///<summary>
        ///最后公司序号
        ///</summary>
        public int LastCorpId { get; set; }
                    
        ///<summary>
        ///公司组名称
        ///</summary>
        public string CorpGroupName { get; set; }
                    
        ///<summary>
        ///公司组状态
        ///</summary>
        public int CorpGroupStatus { get; set; }
                    
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

