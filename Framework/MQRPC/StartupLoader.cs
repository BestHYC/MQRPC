using Framework.IOCApplication;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using IServiceProvider = Framework.IOCApplication.IServiceProvider;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：StartupLoader  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/8 18:43:38
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class StartupLoader : IStartupLoader
    {
        private IServiceProvider _provider;
        public StartupLoader(IServiceProvider provider)
        {
            _provider = provider;
        }
        /// <summary>
        /// 调用注入的方法
        /// </summary>
        /// <param name="startupType"></param>
        /// <returns></returns>
        public Action GetConfigureDelegate(Type startupType)
        {
            MethodInfo info = startupType.GetMethod("Configure");
            ParameterInfo[] parameters = info.GetParameters();
            Object[] obj = new Object[parameters.Length];
            for(Int32 i = 0; i < parameters.Length; i++)
            {
                obj[i] = _provider.GetRequiredService(parameters[i].ParameterType);
            }
            return  ()=> { startupType.GetMethod("Configure").Invoke(_provider.GetRequiredService(startupType), obj); };
        }
        public Action<IServiceCollection> GetConfigureServices(Type startupType)
        {
            return service => { startupType.GetMethod("ConfigureServices").Invoke(_provider.GetRequiredService(startupType), new Object[] { service }); };
        }
    }
}
