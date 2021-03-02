using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_EmpCustom
    /// </summary>
    [Serializable]
    public class usr_EmpCustom
    {
                    
        ///<summary>
        ///
        ///</summary>
        public int EmpCustomId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CustomColumnId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CustomIndex { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int EmpCustomStatus { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int CreatorId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public DateTime CreateTime { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int LastModifyId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public DateTime LastModifyTime { get; set; }
            }
}

