using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface ITransferHostBuilder
    {
        ITransferHostBuilder UserStartup(Type startupType);
        ITransferHostBuilder UserServer(IServerFactory factory);
        ITransferHost Build();
    }
}
