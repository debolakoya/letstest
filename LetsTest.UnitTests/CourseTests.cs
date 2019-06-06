using FakeItEasy;
using LetsTest.Model;
using System;
using Xunit;

namespace LetsTest.UnitTests
{
  public class CourseTests
  {


    public CourseTests()
    {

    }

    private Course CreateCourse()
    {
      return new Course();
    }

    [Fact]
    public void TestMethod1()
    {
      // Arrange
      var unitUnderTest = CreateCourse();

      // Act

      // Assert
      Assert.True(false);
    }
  }
}
