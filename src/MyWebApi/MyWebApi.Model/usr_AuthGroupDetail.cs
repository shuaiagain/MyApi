using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_AuthGroupDetail
    /// </summary>
    [Serializable]
    public class usr_AuthGroupDetail
    {
                    
        ///<summary>
        ///明细序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///权限组序号
        ///</summary>
        public int AuthGroupId { get; set; }
                    
        ///<summary>
        ///员工序号
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///明细状态
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
        ///最后修改人序号
        ///</summary>
        public int LastModifyId { get; set; }
                    
        ///<summary>
        ///最后修改时间
        ///</summary>
        public DateTime LastModifyTime { get; set; }
            }
}

