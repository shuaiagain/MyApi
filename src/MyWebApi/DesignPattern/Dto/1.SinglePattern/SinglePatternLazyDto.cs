using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dto
{
    /// <summary>
    /// 单例（懒汉模式）
    /// </summary>
    public class SinglePatternLazyDto
    {
        //用于保持实例
         private static volatile SinglePatternLazyDto uniqueInstance;
        //用于加锁
        private static readonly object locker;

        #region 单线程情况下是OK的，但是多线程情况下就不是线程安全的了
        public static SinglePatternLazyDto GetInstanceWithThreadNotSafe()
        {
            if (uniqueInstance == null)
                uniqueInstance = new SinglePatternLazyDto();

            return uniqueInstance;
        }
        #endregion

        #region 线程安全的
        public static SinglePatternLazyDto GetInstanceWithThreadSafe()
        {

            lock (locker)
            {
                if (uniqueInstance == null)
                    uniqueInstance = new SinglePatternLazyDto();
            }

            return uniqueInstance;
        }
        #endregion

        #region 线程安全的,双重锁
        public static SinglePatternLazyDto GetInstanceWithThreadSafe2()
        {

            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new SinglePatternLazyDto();
                }

            }
            return uniqueInstance;
        }
        #endregion
    }
}
