using System;

using AutoMapper;
using DtoLib.Config;
using DtoLib.Dto;
using DtoLib.Entity;


namespace DtoLib.Example
{

    public delegate void MyAction<in T>(T arg1);

    public class AutoMapperExt
    {
        public static void Print()
        {
            ExampleH();
            //ExampleG();
            //ExampleF();
            //ExampleE();
            //ExampleD();
            //ExampleC();
            //ExampleB();
            //ExampleA();
        }

        #region 6. 替换字符
        /// <summary>
        /// 替换字符
        /// </summary>
        private static void ExampleH()
        {
            ThreeDto a = new ThreeDto()
            {
                ID = 1,
                entityName = "name-1"
            };

            ThreeDto[] arr = new ThreeDto[] {
                new ThreeDto{
                    ID = 1,
                    entityName = "name-1"
                },
                new ThreeDto{
                    ID = 2,
                    entityName = "name-2"
                }
            };

            var config = new MapperConfiguration(cfg =>
            {
                //全局属性/字段过滤
                cfg.CreateMap<ThreeDto, ThreeEntity>();
            });


            IMapper maper = config.CreateMapper();

            //IEnumerable<Destination> ienumerableDest = mapper.Map<Source[], IEnumerable<Destination>>(sources);
            //ICollection<Destination> icollectionDest = mapper.Map<Source[], ICollection<Destination>>(sources);
            //IList<Destination> ilistDest = mapper.Map<Source[], IList<Destination>>(sources);
            //List<Destination> listDest = mapper.Map<Source[], List<Destination>>(sources);
            //Destination[] arrayDest = mapper.Map<Source[], Destination[]>(sources);

            ThreeEntity[] arrT = maper.Map<ThreeDto[], ThreeEntity[]>(arr);
            foreach (var item in arrT)
            {
                Console.WriteLine("Id = {0},Hand = {1}", item.Id, item.EntityName);
            }
        }
        #endregion

        #region 6. 替换字符
        /// <summary>
        /// 替换字符
        /// </summary>
        private static void ExampleG()
        {
            ThreeDto a = new ThreeDto()
            {
                ID = 1,
                PrefixHandPostfix = 30
            };

            var config = new MapperConfiguration(cfg =>
            {
                //全局属性/字段过滤
                cfg.ReplaceMemberName("PrefixHandPostfix", "Hand");
                cfg.CreateMap<ThreeDto, ThreeEntity>();
            });

            IMapper maper = config.CreateMapper();
            ThreeEntity aa = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Hand = {1}", aa.Id, aa.Hand);
        }
        #endregion

        #region 5. 识别前缀和后缀
        /// <summary>
        /// 识别前缀和后缀
        /// </summary>
        private static void ExampleF()
        {
            ThreeDto a = new ThreeDto()
            {
                ID = 1,
                PrefixHandPostfix = 30
            };

            var config = new MapperConfiguration(cfg =>
            {
                //识别前缀和后缀
                cfg.RecognizePrefixes("Prefix");
                cfg.RecognizePostfixes("Postfix");
                cfg.CreateMap<ThreeDto, ThreeEntity>();
            });

            IMapper maper = config.CreateMapper();
            ThreeEntity aa = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Hand = {1}", aa.Id, aa.Hand);
        }
        #endregion

        #region 4.全局属性/字段过滤
        /// <summary>
        /// 全局属性/字段过滤
        /// </summary>
        private static void ExampleE()
        {
            ThreeDto a = new ThreeDto()
            {
                ID = 1,
                Age = 11,
                entityName = "name1",
                Weight = 20
            };

            var config = new MapperConfiguration(cfg =>
            {
                //全局属性/字段过滤
                cfg.ShouldMapField = p => { return false; };
                cfg.CreateMap<ThreeDto, ThreeEntity>();
            });

            IMapper maper = config.CreateMapper();
            ThreeEntity aa = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Age = {1},Name = {2},Height = {3},Weight = {4} ", aa.Id, aa.Age, aa.EntityName, aa.Height, aa.Weight);
        }
        #endregion

        #region 4.配置可见性
        /// <summary>
        /// 配置可见性
        /// </summary>
        private static void ExampleD()
        {
            ThreeDto a = new ThreeDto() { ID = 1, Age = 11, entityName = "name1" };
            var config = new MapperConfiguration(cfg =>
            {
                //配置可见性
                cfg.ShouldMapField = p => p.IsPrivate || p.IsPublic;
                cfg.CreateMap<ThreeDto, ThreeEntity>();
            });

            IMapper maper = config.CreateMapper();
            ThreeEntity aa = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Age = {1},Name = {2},Height = {3}", aa.Id, aa.Age, aa.EntityName, aa.Height);
        }
        #endregion

        #region 3.命名约定
        /// <summary>
        /// 3.1 命名约定
        ///  默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的。
        ///  但有时，我们需要处理一些特殊的情况。
        ///  SourceMemberNamingConvention 表示源类型命名规则
        ///  DestinationMemberNamingConvention 表示目标类型命名规则
        ///  LowerUnderscoreNamingConvention 和 PascalCaseNamingConvention 是 AutoMapper 提供的两个命名规则。
        ///  前者命名是小写并包含下划线，后者就是帕斯卡命名规则（每个单词的首字母大写
        /// </summary>
        private static void ExampleC()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ThreeDto, ThreeEntity>();

                cfg.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
                cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
            });

            IMapper maper = config.CreateMapper();

            //默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的
            ThreeDto a = new ThreeDto() { ID = 1, Age = 11, entityName = "name1" };
            var b = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Age = {1},Name = {2}", b.Id, b.Age, b.EntityName);
        }
        #endregion

        #region 2.默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的
        /// <summary>
        /// 默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的
        /// </summary>
        private static void ExampleB()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ThreeDto, ThreeEntity>(); });
            IMapper maper = config.CreateMapper();

            //默认情况下，AutoMapper 基于相同的字段名映射，并且是 不区分大小写 的
            ThreeDto a = new ThreeDto() { ID = 1, Age = 11, entityName = "name1" };
            var b = maper.Map<ThreeEntity>(a);

            Console.WriteLine("Id = {0},Age = {1},Name = {2}", b.Id, b.Age, b.EntityName);
        }
        #endregion

        #region 1.静态方法
        /// <summary>
        /// 静态方法
        /// </summary>
        private static void ExampleA()
        {
            ThreeDto a = new ThreeDto() { ID = 1, Age = 11, entityName = "name1" };
            ThreeDto b = new ThreeDto() { ID = 2, Age = 22, entityName = "name2" };
            ThreeEntity aa = MapperExt.MapTo<ThreeDto, ThreeEntity>(a);

            Console.WriteLine("Id = {0},Age = {1},Name = {2}", aa.Id, aa.Age, aa.EntityName);
        }
        #endregion
    }

}
