using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：RouteTable  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/16 17:54:19
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    /// <summary>
    /// 收集路由解析对象的值
    /// </summary>
    public class RouteTable
    {
        public static RouteDictionary Routes { get; private set; }
        static RouteTable()
        {
            Routes = new RouteDictionary();
        }
    }
}
