using System;

namespace Entity.Model
{
    /// <summary>
    /// usr_AccountDetail
    /// </summary>
    [Serializable]
    public class usr_AccountDetail
    {
                    
        ///<summary>
        ///明细序号
        ///</summary>
        public int DetailId { get; set; }
                    
        ///<summary>
        ///账户序号
        ///</summary>
        public int AccountId { get; set; }
                    
        ///<summary>
        ///客户端序号
        ///</summary>
        public string ClientId { get; set; }
                    
        ///<summary>
        ///设备序号
        ///</summary>
        public string DeviceToken { get; set; }
                    
        ///<summary>
        ///明细状态
        ///</summary>
        public int DetailStatus { get; set; }
            }
}

