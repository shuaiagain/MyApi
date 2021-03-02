using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_ClientCorpConfirm
    /// </summary>
    [Serializable]
    public class usr_ClientCorpConfirm
    {
                    
        ///<summary>
        ///客户授信确认序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户评估报序号
        ///</summary>
        public int ClientCorpAssessId { get; set; }
                    
        ///<summary>
        ///客户准入申请序号
        ///</summary>
        public int ClientCorpApplyId { get; set; }
                    
        ///<summary>
        ///授信额度
        ///</summary>
        public decimal CreditBala { get; set; }
                    
        ///<summary>
        ///申请或评估
        ///</summary>
        public int IsApplyOrAssess { get; set; }
                    
        ///<summary>
        ///确认日期
        ///</summary>
        public DateTime ConfirmDate { get; set; }
                    
        ///<summary>
        ///备注
        ///</summary>
        public string Memo { get; set; }
                    
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
        ///最后修改时间
        ///</summary>
        public DateTime LastModifyTime { get; set; }
                    
        ///<summary>
        ///最后修改人序号
        ///</summary>
        public int LastModifyId { get; set; }
            }
}

