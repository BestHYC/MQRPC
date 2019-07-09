using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface IStattupLoader
    {
        Action<IApplicationBuilder> GetConfigureDelegate(Type startupType);
    }
}
