using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_PostionAuthOperate
    /// </summary>
    [Serializable]
    public class usr_PostionAuthOperate
    {
                    
        ///<summary>
        ///操作权限序号
        ///</summary>
        public int PostionAuthOperateId { get; set; }
                    
        ///<summary>
        ///操作权限编号
        ///</summary>
        public string OperateCode { get; set; }
                    
        ///<summary>
        ///操作权限名称
        ///</summary>
        public string OperateName { get; set; }
                    
        ///<summary>
        ///操作类型
        ///</summary>
        public int OperateType { get; set; }
                    
        ///<summary>
        ///菜单序号
        ///</summary>
        public int MenuId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int PostionId { get; set; }
                    
        ///<summary>
        ///状态
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

