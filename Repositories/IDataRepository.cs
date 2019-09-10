using System;
using System.Collections.Generic;
using projectgb_web.Models;

namespace projectgb_web.Repositories
{
    public interface IDataRepository<T>
    {
        IDictionary<string, GbWorkout> Data {get;}
        void Build();
        T Get(Func<T, bool> selector = null);
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
    }
}
