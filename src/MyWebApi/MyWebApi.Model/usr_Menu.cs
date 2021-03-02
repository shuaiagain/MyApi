using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_Menu
    /// </summary>
    [Serializable]
    public class usr_Menu
    {
                    
        ///<summary>
        ///
        ///</summary>
        public int MenuId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string MenuName { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string MenuDesc { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int ParentId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int FirstId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public string Url { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int SortId { get; set; }
                    
        ///<summary>
        ///
        ///</summary>
        public int MenuStatus { get; set; }
                    
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

