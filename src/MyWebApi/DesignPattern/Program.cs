using DesignPattern.Dto;
using DtoLib.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //VolatileYield.Print();
            //VolatileYield.Print1();

            //InterLockedParallel.Print();
            //InterLockedParallel.Print1();

            #region 简单工厂模式
            FoodDto food = SimpleFactoryDto.CreateFood("FoodA");
            food.Print();

            FoodDto foodb = SimpleFactoryDto.CreateFood("FoodB");
            foodb.Print();
            #endregion
        }
    }
}
