using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dto
{
    public class FactoryDto
    {
        public static void Print()
        {
            Example();
        }

        public static void Example()
        {
            FoodDtoB food = new TomatoFacotory().Create();
            food.Print();
        }
    }


    #region 抽象
    /// <summary>
    /// 抽象食物
    /// </summary>
    public abstract class FoodDtoB
    {
        public abstract void Print();
    }

    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class FoodFacotory
    {
        public abstract FoodDtoB Create();
    }
    #endregion

    #region 实现具体的食物和工厂
    public class TomatoA : FoodDtoB
    {
        public override void Print()
        {
            Console.WriteLine("这是西红柿");
        }
    }

    public class TomatoFacotory : FoodFacotory
    {
        public override FoodDtoB Create()
        {
            return new TomatoA();
        }
    }
    #endregion

}
