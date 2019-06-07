using AutoMapper;
using LetsTest.Api.DTOs;
using LetsTest.Model;

namespace LetsTest.Api
{
  public class DomainProfile : Profile
  {
    public DomainProfile()
    {
      AllowNullDestinationValues = true;
      CreateMap<Course, CourseDto>() 
        .ReverseMap();
    }
  }
}