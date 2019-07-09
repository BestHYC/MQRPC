using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface ITransferServer
    {
        void Start<TContext>(ITransferApplication<TContext> application);
    }
}
