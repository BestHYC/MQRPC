using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface IHostApplication<TContext>:IAsyncResult
    {
        void DisposeContext(TContext context, Exception exception);
    }
}
