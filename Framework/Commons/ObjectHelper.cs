using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ObjectHelper  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 18:36:56
 * 针对对象做扩展帮助
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.Commons
{

    public static class ObjectHelper<T>
    {
        private static Object _object = new Object();
        /// <summary>
        /// 创建对象缓存
        /// </summary>
        private static Func<T> _creator = null;

    }
}
