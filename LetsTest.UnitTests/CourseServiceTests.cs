using FakeItEasy;
using LetsTest.Data;
using LetsTest.Model;
using LetsTest.Service;
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
      return new CourseService(fakeRepository);
    }

    [Fact]
    public void SaveCourseAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();
      var course = new Course ();

      // Act
      var result = unitUnderTest.SaveCourse(course);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetCourseByIdAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();
      int id = 1;

      // Act
      var result = unitUnderTest.GetCourseById(id);

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetAllCoursesAsync_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateService();

      // Act
      var result = unitUnderTest.GetAllCourses();

      // Assert
      Assert.True(false);
    }
  }
}
