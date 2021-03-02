using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Position
    /// </summary>
    [Serializable]
    public class usr_Position
    {
                    
        ///<summary>
        ///岗位序号
        ///</summary>
        public int PositionId { get; set; }
                    
        ///<summary>
        ///岗位名称
        ///</summary>
        public string PositionName { get; set; }
                    
        ///<summary>
        ///岗位状态
        ///</summary>
        public int PositionStatus { get; set; }
                    
        ///<summary>
        ///岗位级别
        ///</summary>
        public int PositionLevel { get; set; }
                    
        ///<summary>
        ///上级岗位
        ///</summary>
        public int ParentPositiont { get; set; }
                    
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

