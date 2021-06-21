using System;

using AutoMapper;
using DtoLib.Config;
using DtoLib.Dto;
using DtoLib.Entity;


namespace DtoLib.Example
{
    public class AutoMapperExt
    {
        public static void Print()
        {
            ExampleA();
        }

        private static void ExampleA()
        {
            ThreeDto a = new ThreeDto() { Id = 1, Age = 1, Name = "1" };
            ThreeDto b = new ThreeDto() { Id = 2, Age = 2, Name = "2" };
            a = null;
            ThreeEntity aa = MapperExt.MapTo<ThreeDto, ThreeEntity>(a);

            Console.WriteLine("Id = {0}", aa.Id);
        }
    }

}
