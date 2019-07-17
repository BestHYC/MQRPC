using System;
using System.Collections.Generic;
using System.Text;
using Framework.MQRPC;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：Route  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/16 17:52:25
 * 路由模板,解析后获取具体的路由值
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    /// <summary>
    /// 通过路由,生成路由值
    /// </summary>
    public class Route : RouteBase
    {
        public String Url { get; set; }
        public override RouteData GetRouteData(TransferBaseContext httpContext)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 判断不同的路由比对是否正确
        /// "{controller}/{action}/{id}" 与 Home/Index/""之间的正确与否
        /// </summary>
        /// <param name="requestUrl"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        protected Boolean IsMatch(String requestUrl, out IDictionary<String, Object> values)
        {
            values = new Dictionary<String, Object>();
            String[] strArray1 = requestUrl.Split('/');
            String[] strArray2 = this.Url.Split('/');
            if (strArray1.Length != strArray2.Length) return false;
            for (Int32 i = 0; i < strArray2.Length; i++)
            {
                if (strArray2[i].StartsWith("{") && strArray2[i].EndsWith("}"))
                {
                    values.Add(strArray2[i].Trim("{}".ToCharArray()), strArray1[i]);
                }
                else
                {
                    //必须固定的形式{controller}/{action}/{index},否则直接报错
                    return false;
                }
            }
            return true;
        }
    }
}
