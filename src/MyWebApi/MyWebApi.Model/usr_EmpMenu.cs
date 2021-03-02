using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_EmpMenu
    /// </summary>
    [Serializable]
    public class usr_EmpMenu
    {
                    
        ///<summary>
        ///
        ///</summary>
        public int RefId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int EmpId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int MenuId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int RefStatus { get; set; }
                    
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

