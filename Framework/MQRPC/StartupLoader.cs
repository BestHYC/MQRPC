using System;
using System.Collections.Generic;
using System.Text;


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
    public class StartupLoader : IStattupLoader
    {
        public Action<IApplicationBuilder> GetConfigureDelegate(Type startupType)
        {
            return app => { startupType.GetMethod("Configure").Invoke(Activator.CreateInstance(startupType), new Object[] { app }); };
        }
    }
}
