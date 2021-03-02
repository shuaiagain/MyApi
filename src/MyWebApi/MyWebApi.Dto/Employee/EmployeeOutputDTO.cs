using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Dto.Employee
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeOutputDTO
    {
        /// <summary>
        /// 人员id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }
}
