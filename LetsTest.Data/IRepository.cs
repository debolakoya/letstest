using System.Collections.Generic;

namespace LetsTest.Data
{
  public interface IRepository< TEntity> where TEntity : class
  {
    int Save (TEntity t);
    TEntity Get (int id);
    IEnumerable<TEntity> GetAll();
  }
}
