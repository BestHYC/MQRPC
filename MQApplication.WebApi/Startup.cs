using Framework.IOCApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.MQRPC;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：Startup  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 15:42:17
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace MQApplication.WebApi
{
    public class Startup
    {
        /// <summary>
        /// 添加服务
        /// </summary>
        /// <param name="service"></param>
        public void ConfigureServices(IServiceCollection service)
        {
        }
        /// <summary>
        /// 添加中间件
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
        }
    }
}
