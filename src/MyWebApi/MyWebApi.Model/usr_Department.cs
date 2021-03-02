using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Department
    /// </summary>
    [Serializable]
    public class usr_Department
    {
                    
        ///<summary>
        ///部门序号
        ///</summary>
        public int DeptId { get; set; }
                    
        ///<summary>
        ///所属公司
        ///</summary>
        public int CorpId { get; set; }
                    
        ///<summary>
        ///部门编号
        ///</summary>
        public string DeptCode { get; set; }
                    
        ///<summary>
        ///部门名称
        ///</summary>
        public string DeptName { get; set; }
                    
        ///<summary>
        ///部门全称
        ///</summary>
        public string DeptFullName { get; set; }
                    
        ///<summary>
        ///部门缩写
        ///</summary>
        public string DeptShort { get; set; }
                    
        ///<summary>
        ///上级部门
        ///</summary>
        public int ParentDept { get; set; }
                    
        ///<summary>
        ///部门类型
        ///</summary>
        public int DeptType { get; set; }
                    
        ///<summary>
        ///部门状态
        ///</summary>
        public int DeptStatus { get; set; }
                    
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

