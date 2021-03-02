using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpNameModify
    /// </summary>
    [Serializable]
    public class usr_CorpNameModify
    {
                    
        ///<summary>
        ///变更序号
        ///</summary>
        public int ModifyId { get; set; }
                    
        ///<summary>
        ///变更人
        ///</summary>
        public int Modifier { get; set; }
                    
        ///<summary>
        ///变更日期
        ///</summary>
        public DateTime ModifyDate { get; set; }
                    
        ///<summary>
        ///原客户序号
        ///</summary>
        public int OCorpId { get; set; }
                    
        ///<summary>
        ///原客户名称
        ///</summary>
        public string OCorpName { get; set; }
                    
        ///<summary>
        ///原客户英文名称
        ///</summary>
        public string OCorpEName { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string NCorpName { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string NCorpEName { get; set; }
                    
        ///<summary>
        ///新客户序号
        ///</summary>
        public int NCorpId { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///变更状态
        ///</summary>
        public int ModifyStatus { get; set; }
                    
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

