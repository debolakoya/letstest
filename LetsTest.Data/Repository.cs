using System;
using System.Collections.Generic;

namespace LetsTest.Data
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private readonly List<T> _store;

    public Repository()
    {
      _store = new List<T>();
    }

    public virtual int Save(T t)
    {
      _store.Add(t);
      return new Random().Next(1, 5);
    }

    public T Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
      return _store;
    }
  }
}