using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dto
{
    /// <summary>
    /// 单例（饿汉模式）
    /// </summary>
    public class SinglePatternHungryDto
    {
        public static readonly SinglePatternHungryDto singleInstance = new SinglePatternHungryDto();

        private SinglePatternHungryDto()
        {
        }

        static SinglePatternHungryDto()
        {
            //或者声明的时候不初始化，在静态构造函数中初始化，效果是一样的
            //singleInstance = new SinglePatternHungryDto();
        }
    }
}
