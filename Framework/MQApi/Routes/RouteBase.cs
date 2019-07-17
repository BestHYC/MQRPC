using Framework.MQRPC;
using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：RouteBase  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/16 17:52:41
 * 路由抽象基类,获取具体的路由值
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public abstract class RouteBase
    {
        public abstract RouteData GetRouteData(TransferBaseContext httpContext);
    }
}
