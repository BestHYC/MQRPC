using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.IOCApplication
{
    public interface IServiceCollection
    {
        IServiceCollection AddTransient<T1, T2>() where T2 : T1;
        IServiceCollection AddTransient<T1>(T1 t2);
        IServiceCollection AddSingleton<T1, T2>() where T2 : T1;
        IServiceCollection AddSingleton<T1>(T1 t2);
        IServiceProvider BuildServiceProvider();
    }
}
