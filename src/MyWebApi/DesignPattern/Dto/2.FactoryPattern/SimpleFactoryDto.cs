using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dto
{
    #region 简单工厂模式
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    public class SimpleFactoryDto
    {
        public static FoodDto CreateFood(string type)
        {
            FoodDto food = null;
            if (type.Equals("FoodA"))
                food = new FoodADto();
            else if (type.Equals("FoodB"))
                food = new FoodBDto();

            return food;
        }
    } 
    #endregion

    #region FoodDto
    public abstract class FoodDto
    {
        public abstract void Print();
    }
    #endregion

    #region FoodADto
    public class FoodADto : FoodDto
    {
        public override void Print()
        {
            Console.WriteLine("FoodADto");
        }
    }
    #endregion

    #region FoodBDto
    public class FoodBDto : FoodDto
    {
        public override void Print()
        {
            Console.WriteLine("FoodBDto");
        }
    }
    #endregion
}
