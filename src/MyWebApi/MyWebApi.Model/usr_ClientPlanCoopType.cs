using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_ClientPlanCoopType
    /// </summary>
    [Serializable]
    public class usr_ClientPlanCoopType
    {
                    
        ///<summary>
        ///序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///客户准入申请序号
        ///</summary>
        public int ClientCorpApplyId { get; set; }
                    
        ///<summary>
        ///计划合作形式序号
        ///</summary>
        public int PlanCoopTypeId { get; set; }
                    
        ///<summary>
        ///计划合作形式名称
        ///</summary>
        public string PlanCoopTypeName { get; set; }
                    
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

