using System;
using System.Collections.Generic;

namespace LetsTest.Data
{
  public interface IRepository<T> where T : class
  {
    int Save(T t);
    T Get(Predicate<T> id);
    IEnumerable<T> GetAll();
  }
}