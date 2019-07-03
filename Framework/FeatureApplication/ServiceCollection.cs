using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ServiceCollection  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 10:14:28
 * 针对创建ioc注入的简单构造,本框架只做系统生成使用,不注重Ioc生成,线上可使用automapper
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.FeatureApplication
{
    /// <summary>
    /// 通过特写
    /// </summary>
    public class ServiceCollection : IServiceCollection
    {
        /// <summary>
        /// 单例保存
        /// </summary>
        private ConcurrentDictionary<Type, ServiceTypeCache> _typePairs;
        /// <summary>
        /// 保存的所有对象,只创建一次对象,剩余就从这里获取,
        /// </summary>
        private ConcurrentDictionary<Type, Object> _objPairs;
        public ServiceCollection()
        {
            _typePairs = new ConcurrentDictionary<Type, ServiceTypeCache>();
            _objPairs = new ConcurrentDictionary<Type, Object>();
        }
        /// <summary>
        /// 构建单例
        /// </summary>
        /// <typeparam name="T1">基类型</typeparam>
        /// <typeparam name="T2">子类实例</typeparam>
        /// <returns></returns>
        public IServiceCollection AddSingleton<T1, T2>() where T2 : T1
        {
            Type t1 = typeof(T1);
            Type t2 = typeof(T2);
            ServiceTypeCache service = new ServiceTypeCache(t2, ServiceTypeEnum.Singleton);
            if(!_typePairs.TryAdd(t1, service))
            {
                throw new Exception("在注入对象时,有相同对象存在");
            }
            return this;
        }
        /// <summary>
        /// 构建单列
        /// </summary>
        /// <typeparam name="T1">泛型类型</typeparam>
        /// <param name="t2">类型对象信息</param>
        /// <returns></returns>
        public IServiceCollection AddSingleton<T>(T t2)
        {
            Type t = typeof(T);
            ServiceTypeCache service = new ServiceTypeCache(t2, ServiceTypeEnum.Singleton);
            if (!_typePairs.TryAdd(t, service))
            {
                throw new Exception("在注入对象时,有相同对象存在");
            }
            return this;
        }
        /// <summary>
        /// 每次都注入新的对象
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public IServiceCollection AddTransient<T1, T2>() where T2 : T1
        {
            Type t1 = typeof(T1);
            Type t2 = typeof(T2);
            ServiceTypeCache service = new ServiceTypeCache(t2, ServiceTypeEnum.Transient);
            if (!_typePairs.TryAdd(t1, service))
            {
                throw new Exception("在注入对象时,有相同对象存在");
            }
            return this;
        }
        /// <summary>
        /// 每次都注入新的对象
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="t2"></param>
        /// <returns></returns>
        public IServiceCollection AddTransient<T>(T t2)
        {
            Type t = typeof(T);
            ServiceTypeCache service = new ServiceTypeCache(t2, ServiceTypeEnum.Transient);
            if (!_typePairs.TryAdd(t, service))
            {
                throw new Exception("在注入对象时,有相同对象存在");
            }
            return this;
        }
        /// <summary>
        /// 提供真实对象信息
        /// </summary>
        /// <returns></returns>
        public IServiceProvider BuildServiceProvider()
        {
            throw new NotImplementedException();
        }
    }
}
