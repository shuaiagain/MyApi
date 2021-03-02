using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_DeptBalaApply
    /// </summary>
    [Serializable]
    public class usr_DeptBalaApply
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
        ///客户序号
        ///</summary>
        public int OutCorpId { get; set; }
                    
        ///<summary>
        ///部门额度
        ///</summary>
        public decimal DeptBala { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CurrencyId { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
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
            }
}

