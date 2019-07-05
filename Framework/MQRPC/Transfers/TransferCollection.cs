using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：TransferCollection  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/5 11:12:23
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.MQRPC
{
    /// <summary>
    /// 只是单纯做记录使用,不做任何判断
    /// 而类似于,域名判断,权限认证,此处只做收集
    /// 处理事情交由后期事项处理
    /// </summary>
    public class TransferCollection
    {
        /// <summary>
        /// 从哪里来的
        /// </summary>
        public Uri UrlReferrer { get; set; }
        /// <summary>
        /// 到哪里去
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// Uri请求参数处理
        /// </summary>
        public NameValueCollection QueryParams { get; set; }
        /// <summary>
        /// 内部字段处理,以dic存储,即使后期传递文件方式
        /// </summary>
        public NameValueCollection RequestContent { get; set; }
        /// <summary>
        /// 内部字段处理,以dic存储,即使后期传递文件方式
        /// </summary>
        public NameValueCollection ResponseContent { get; set; }
        /// <summary>
        /// 请求头参数
        /// </summary>
        public NameValueCollection Headers { get; set; }
    }
}
