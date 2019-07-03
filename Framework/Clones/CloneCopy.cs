using System;
using System.Collections.Generic;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：CloneCopy  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 17:52:51
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.Clones
{
    public interface IShallowCopy<T>
    {
        T ShallowCopy();
    }
    public interface IDeepCopy<T>
    {
        T DeepCopy();
    }
}
