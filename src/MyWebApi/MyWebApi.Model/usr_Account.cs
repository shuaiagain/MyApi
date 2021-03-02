using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Account
    /// </summary>
    [Serializable]
    public class usr_Account
    {
                    
        ///<summary>
        ///账户序号
        ///</summary>
        public int AccId { get; set; }
                    
        ///<summary>
        ///账户名称
        ///</summary>
        public string AccountName { get; set; }
                    
        ///<summary>
        ///账户密码
        ///</summary>
        public string PassWord { get; set; }
                    
        ///<summary>
        ///账户状态
        ///</summary>
        public int AccStatus { get; set; }
                    
        ///<summary>
        ///关联员工序号
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///是否有效
        ///</summary>
        public bool IsValid { get; set; }
                    
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

