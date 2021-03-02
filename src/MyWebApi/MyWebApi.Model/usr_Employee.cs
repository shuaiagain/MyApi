using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Employee
    /// </summary>
    [Serializable]
    public class usr_Employee
    {
                    
        ///<summary>
        ///员工编号
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///所属部门
        ///</summary>
        public int DeptId { get; set; }
                    
        ///<summary>
        ///员工编号
        ///</summary>
        public string EmpCode { get; set; }
                    
        ///<summary>
        ///姓名
        ///</summary>
        public string Name { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string EName { get; set; }
                    
        ///<summary>
        ///性别
        ///</summary>
        public bool Sex { get; set; }
                    
        ///<summary>
        ///生日
        ///</summary>
        public DateTime BirthDay { get; set; }
                    
        ///<summary>
        ///手机号码
        ///</summary>
        public string Telephone { get; set; }
                    
        ///<summary>
        ///座机号码
        ///</summary>
        public string Phone { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string Email { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string GroupMail { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string PersonUrl { get; set; }
                    
        ///<summary>
        ///在职状态
        ///</summary>
        public int WorkStatus { get; set; }
                    
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

