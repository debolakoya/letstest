using FluentAssertions;
using LetsTest.Data;
using LetsTest.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LetsTest.UnitTests
{
  public class RepositoryTests
  {
    [Fact]
    public void Save_Ensure_Return_Id_IsValid()
    {
      // Arrange
      var unitUnderTest = new Repository<Course>();
      var t = new Course {Name = "Some Course"};

      // Act
      var result = unitUnderTest.Save(t);

      // Assert
      result.Should().BeGreaterOrEqualTo(1);
    }

    [Fact]
    public void Get_Ensure_Return_Data_Match_Request()
    {
      // Arrange
      var unitUnderTest = new Repository<Course>(FakeData());
      const int id = 1;

      // Act
      var result = unitUnderTest.Get(x=>x.Id== id);

      // Assert
      result.Id.Should().Be(id);
    }

    [Fact]
    public void Get_eEnsure_Return_Data_Match_Request()
    {
      // Arrange
      var unitUnderTest = new Repository<Course>(FakeData());
      const int id = 99;

      // Act
      var result = unitUnderTest.Get(x => x.Id == id);

      // Assert
      result.Should().Be(null);
    }

    [Fact]
    public void GetAll_Ensure_Has_Records()
    {
      // Arrange
      var unitUnderTest = new Repository<Course>(FakeData());

      // Act
      var result = unitUnderTest.GetAll();

      // Assert
      var resultList = result.ToList();
      resultList.Should().HaveCountGreaterOrEqualTo(1);
      resultList.Should().BeOfType<List<Course>>();
    }

    private static List<Course> FakeData()
    {
      return new List<Course>
      {
        new Course {Id = 1, Name = "Course 1"},
        new Course {Id = 2, Name = "Course 2"}
      };
    }
  }
}