using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：RequestDelegate  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/9 9:39:24
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    public delegate Task RequestDelegate(TransferContext context);
}
