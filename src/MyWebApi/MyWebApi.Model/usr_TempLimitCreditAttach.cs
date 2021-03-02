using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_TempLimitCreditAttach
    /// </summary>
    [Serializable]
    public class usr_TempLimitCreditAttach
    {
                    
        ///<summary>
        ///临时额度授信附件表序号
        ///</summary>
        public int TempLimitCreditAttachId { get; set; }
                    
        ///<summary>
        ///临时额度授信序号
        ///</summary>
        public int TempLimitCreditId { get; set; }
                    
        ///<summary>
        ///附件序号
        ///</summary>
        public int AttachId { get; set; }
                    
        ///<summary>
        ///附件名称，不包含扩展名
        ///</summary>
        public string AttachName { get; set; }
                    
        ///<summary>
        ///服务端文件名
        ///</summary>
        public string ServerAttachName { get; set; }
                    
        ///<summary>
        ///附件扩展名
        ///</summary>
        public string AttachExt { get; set; }
                    
        ///<summary>
        ///附件类型
        ///</summary>
        public int AttachType { get; set; }
                    
        ///<summary>
        ///附件描述
        ///</summary>
        public string AttachInfo { get; set; }
                    
        ///<summary>
        ///附件大小
        ///</summary>
        public int AttachLength { get; set; }
                    
        ///<summary>
        ///附件路径
        ///</summary>
        public string AttachPath { get; set; }
                    
        ///<summary>
        ///附件状态
        ///</summary>
        public int AttachStatus { get; set; }
            }
}

