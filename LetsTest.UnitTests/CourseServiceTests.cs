using FakeItEasy;
using LetsTest.Data;
using LetsTest.Model;
using LetsTest.Service;
using System;
using Xunit;

namespace LetsTest.UnitTests
{
  public class CourseServiceTests
  {
    private IRepository<Course> fakeRepository;

    public CourseServiceTests()
    {
      fakeRepository = A.Fake<IRepository<Course>>();
    }

    private CourseService CreateService()
    {
      return new CourseService(
          fakeRepository);
    }

    [Fact]
    public void SaveCourseAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();
      Course course = TODO;

      // Act
      var result = unitUnderTest.SaveCourseAsync(
          course);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetCourseByIdAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();
      int id = TODO;

      // Act
      var result = unitUnderTest.GetCourseByIdAsync(
          id);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetAllCoursesAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();

      // Act
      var result = unitUnderTest.GetAllCoursesAsync();

      // Assert
      Assert.True(false);
    }
  }
}
