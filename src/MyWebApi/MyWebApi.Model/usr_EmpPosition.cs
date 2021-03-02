using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_EmpPosition
    /// </summary>
    [Serializable]
    public class usr_EmpPosition
    {
                    
        ///<summary>
        ///关联序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///员工序号
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///岗位序号
        ///</summary>
        public int PositionId { get; set; }
                    
        ///<summary>
        ///部门
        ///</summary>
        public int DeptId { get; set; }
                    
        ///<summary>
        ///关联状态
        ///</summary>
        public int RefStatus { get; set; }
                    
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

