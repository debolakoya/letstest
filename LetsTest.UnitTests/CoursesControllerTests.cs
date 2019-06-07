using AutoMapper;
using FakeItEasy;
using LetsTest.Api.Controllers;
using LetsTest.Service;
using Xunit;

namespace LetsTest.UnitTests
{
  public class CoursesControllerTests
  {
    private readonly ICourseService fakeCourseService;
    private readonly IMapper fakeMapper;

    public CoursesControllerTests()
    {
      fakeCourseService = A.Fake<ICourseService>();
      fakeMapper = A.Fake<IMapper>();
    }

    private CoursesController CreateCoursesController()
    {
      return new CoursesController(fakeCourseService, fakeMapper);
    }

    [Fact]
    public void Get_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateCoursesController();

      // Act
      var result = unitUnderTest.Get();

      // Assert
      Assert.True(false);
    }

    [Fact]
    public void GetById_StateUnderTest_ExpectedBehavior()
    {
      // Arrange
      var unitUnderTest = CreateCoursesController();
      int id = 5;

      // Act
      var result = unitUnderTest.GetById(id);

      // Assert
      Assert.True(false);
    }
  }
}
