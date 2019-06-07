using AutoMapper;
using LetsTest.Api;
using Xunit;

namespace LetsTest.UnitTests
{
  public class AutoMapperTests
  {
    [Fact]
    [System.Obsolete]
    public void AutoMapper_Configuration_IsValid()
    {
      Mapper.Initialize(cfg => cfg.AddProfile<DomainProfile>());
      Mapper.AssertConfigurationIsValid();
    }
  }
}
