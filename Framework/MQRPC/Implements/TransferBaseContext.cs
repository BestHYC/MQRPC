using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQRPC
{
    public abstract class TransferBaseContext
    {
        public abstract TransferRequest Request { get; }
        public abstract TransferResponse Response { get; }
        public abstract TransferContext Context { get; }
    }
}
