using Framework.MQRPC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：RouteDictionary  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/16 17:54:43
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class RouteValueDictionary : Dictionary<String, String>
    {

    }
    /// <summary>
    /// 生成路由模板,并加入集合
    /// </summary>
    public class RouteDictionary:Dictionary<String, RouteBase>
    {
        public RouteDictionary()
        {

        }
        private String ignore;
        /// <summary>
        /// 如果有忽略url,则直接跳过,执行文件路径读取
        /// </summary>
        /// <param name="url"></param>
        public void IgnoreRoute(String url)
        {
            ignore = url;
        }
        /// <summary>
        /// 通过对应的数据获取到值
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public RouteData GetRouteData(TransferBaseContext httpContext)
        {
            if(!String.IsNullOrWhiteSpace(ignore) && Regex.IsMatch(httpContext.Request.Url.ToString(), ignore))
            {
                return null;
            }
            foreach (var route in this.Values)
            {
                RouteData routeData = route.GetRouteData(httpContext);
                if (routeData != null)
                {
                    return routeData;
                }
            }
            return null;
        }
    }
}
