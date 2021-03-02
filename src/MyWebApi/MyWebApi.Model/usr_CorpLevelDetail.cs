using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_CorpLevelDetail
    /// </summary>
    [Serializable]
    public class usr_CorpLevelDetail
    {
                    
        ///<summary>
        ///客户评级明细序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户评级序号
        ///</summary>
        public int LevelId { get; set; }
                    
        ///<summary>
        ///部门序号号
        ///</summary>
        public int DeptId { get; set; }
                    
        ///<summary>
        ///授信额度
        ///</summary>
        public decimal LevelBala { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
        ///<summary>
        ///明细状态
        ///</summary>
        public int DetailStatus { get; set; }
            }
}

