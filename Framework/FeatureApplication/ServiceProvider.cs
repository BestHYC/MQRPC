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
namespace Framework.FeatureApplication
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
        public T GetRequiredService<T>()
        {
            throw new NotImplementedException();
        }
    }

}
