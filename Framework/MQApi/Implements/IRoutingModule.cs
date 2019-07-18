using Framework.MQRPC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQApi
{
    public interface IRoutingModule
    {
        void Init(TransferBaseContext context);
    }
}
