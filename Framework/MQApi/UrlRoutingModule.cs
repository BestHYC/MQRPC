using Framework.MQRPC;
using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：UrlRoutingModule  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/12 10:42:30
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    /// <summary>
    /// 用作解析url,生成对应的controller
    /// </summary>
    public class UrlRoutingModule : IRoutingModule
    {
        public void Init(TransferBaseContext context)
        {
            RouteData routeData = RouteTable.Routes.GetRouteData(context);
            if (routeData == null) return;
            RequestContext request = new RequestContext()
            {
                Context = context,
                RouteData = routeData
            };
            IApiHandler handler = routeData.RouteHandler.GetApiHandler(request);
            handler.ProcessRequest();
        }
    }
}
