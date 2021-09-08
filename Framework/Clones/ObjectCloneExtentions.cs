using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


/* ==============================================================================
 * 格言:一只duck
 * 功能描述：ObjectCloneExtentions  
 * 创 建 者：Best_Hong
 * 创建日期：2019/7/2 17:53:35
 *
 *
 * 修改者：         修改时间：       修改说明:
 * ==============================================================================*/
namespace Framework.Clones
{
    public static class ObjectCloneExtentions
    {
        public static T ShallowCloneCopy<T>(this T obj) where T: IShallowCopy<T>
        {
            return obj.ShallowCopy();
        }
        public static T DeepClone<T>(this Object obj)
        {
            return (T)DeepClone(obj);
        }
        public static Object DeepClone(this Object obj)
        {
            BinaryFormatter BF = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            BF.Serialize(memStream, obj);
            memStream.Flush();
            memStream.Position = 0;
            return BF.Deserialize(memStream);
        }
    }
}
