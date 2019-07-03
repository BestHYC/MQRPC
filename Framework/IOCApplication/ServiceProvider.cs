using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ServiceProvider  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 15:42:16
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.IOCApplication
{
    public interface IServiceProvider
    {
        T GetRequiredService<T>();
    }
    /// <summary>
    /// 
    /// </summary>
    public class ServiceProvider : IServiceProvider
    {
        private IDictionary<Type, IServiceCache> _cache;
        public ServiceProvider(IDictionary<Type, IServiceCache> valuePairs)
        {
            _cache = valuePairs;
        }
        public T GetRequiredService<T>()
        {
            Type t = typeof(T);
            IServiceCache service = null;
            if (!_cache.TryGetValue(t, out service))
            {
                throw new Exception("获取参数对象没有注入");
            }
            return (T)service.GetCache(_cache);
        }
    }

}
