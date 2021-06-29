using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DtoLib.Config
{
    public static class MapperExt
    {
        #region MapTo
        /// <summary>
        /// MapTo
        /// </summary>
        /// <typeparam name="TSource">源类型</typeparam>
        /// <typeparam name="TDestination">目标类型</typeparam>
        /// <param name="source">源实例</param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(TSource source) where TSource : class
            where TDestination : class
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<TSource, TDestination>(source);
        }
        #endregion

        public static List<TDestination> MapToList<TSource, TDestination>(TSource[] source) where TSource : class where TDestination : class
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<TSource[], List<TDestination>>(source);
        }
    }
}
