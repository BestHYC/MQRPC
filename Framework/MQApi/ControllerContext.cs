using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:撸起袖子加油干,树大江大河大气象,立基础基层基本功
 * 功能描述：ControllerContext  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/18 19:11:37
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQApi
{
    public class ControllerContext
    {
        public RequestContext RequestContext { get; set; }
        public IApiController Controller { get; set; }
    }
}
