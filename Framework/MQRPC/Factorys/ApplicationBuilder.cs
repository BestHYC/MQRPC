using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ApplicationBuilder  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 10:00:59
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public class ApplicationBuilder : IApplicationBuilder
    {
        private IList<Func<RequestDelegate, RequestDelegate>> middlewares = new List<Func<RequestDelegate, RequestDelegate>>();
        public RequestDelegate Build()
        {
            RequestDelegate seed = context => Task.Run(() => { });
            return middlewares.Reverse().Aggregate(seed, (current, next) => next(current));
        }

        public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware)
        {
            middlewares.Add(middleware);
            return this;
        }
    }
}
