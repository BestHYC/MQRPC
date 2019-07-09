using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public interface IApplicationBuilder
    {
        RequestDelegate Build();
        IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    }
}
