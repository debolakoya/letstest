using LetsTest.Data;
using LetsTest.Model;
using System;
using System.Collections.Generic;

namespace LetsTest.Service
{
  public class CourseService : ICourseService
  {
    private readonly IRepository<Course> _repository;

    public CourseService(IRepository<Course> repository)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public int SaveCourse(Course course)
    {
      return _repository.Save(course);
    }

    public Course GetCourseById(int id)
    {
      return _repository.Get(id);
    }

    public IEnumerable<Course> GetAllCourses()
    {
      return _repository.GetAll();
    }
  }
}