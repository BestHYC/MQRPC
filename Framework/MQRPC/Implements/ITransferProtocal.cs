using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Framework.MQRPC.Implements
{
    public interface ITransferProtocal
    {
        IDictionary<String, Object> Header { get;}
        Stream Content { get; }
    }
}
