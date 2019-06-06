using FakeItEasy;
using LetsTest.Data;
using System;
using LetsTest.Model;
using Xunit;

namespace LetsTest.UnitTests
{
  public class RepositoryTests
  {


    public RepositoryTests()
    {

    }

    private Repository<Course> CreateRepository()
    {
      return new Repository<Course>();
    }

    [Fact]
    public void Save_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateRepository();
      Course t = TODO;

      // Act
      var result = unitUnderTest.Save(
          t);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void Get_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateRepository();
      int id = TODO;

      // Act
      var result = unitUnderTest.Get(
          id);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetAll_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateRepository();

      // Act
      var result = unitUnderTest.GetAll();

      // Assert
      Assert.True(false);
    }
  }
}
