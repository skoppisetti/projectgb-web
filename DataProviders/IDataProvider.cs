using System;
using System.Collections.Generic;

namespace projectgb_web.DataProviders
{
    public interface IDataProvider<T>
    {
        IEnumerable<T> FetchData(Func<T, bool> predicate = null);
    }
}