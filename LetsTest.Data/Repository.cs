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

    public Repository(List<T> data)
    {
      _store = data;
    }

    public virtual int Save(T t)
    {
      _store.Add(t);
      return new Random().Next(1, 100);
    }

    public T Get(Predicate<T> predicate)
    {
      return _store.Find(predicate);
    }

    public IEnumerable<T> GetAll()
    {
      return _store;
    }
  }
}