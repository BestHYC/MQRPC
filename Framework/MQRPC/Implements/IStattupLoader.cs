using Framework.IOCApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface IStartupLoader
    {
        Action GetConfigureDelegate(Type startupType);
        Action<IServiceCollection> GetConfigureServices(Type startupType);
    }
}
