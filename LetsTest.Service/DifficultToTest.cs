using System;

namespace LetsTest.Service
{
  public class DifficultToTest
  {
    public void WriteUserName(int id)
    {
      var userDatabase = new UserDatabase();
      var userName = userDatabase.GetUserName(id);

      var writer = new FileWriter();
      writer.Write(userName);
    }
  }
}

public class EasierTotest
{
  private readonly IUserDatabase _userDatabase;

  public EasierTotest(IUserDatabase userDatabase)
  {
    _userDatabase = userDatabase;
  }

  public void WriteUserName(int id, IWriter writer)
  {
    var userName = _userDatabase.GetUserName(id);
    writer.Write(userName);
  }
}

public interface IWriter
{
  void Write(string text);
}

public class FileWriter : IWriter
{
  public void Write(string text)
  {
    throw new NotImplementedException();
  }
}

public interface IUserDatabase
{
  string GetUserName(int id);
}

public class UserDatabase : IUserDatabase
{
  public string GetUserName(int id)
  {
    throw new NotImplementedException();
  }
}