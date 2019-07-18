using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.MQApi
{
    public interface IRouteHandler
    {
        IApiHandler GetApiHandler(RequestContext requestContext);
    }
}
