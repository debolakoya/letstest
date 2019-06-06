using LetsTest.Model;
using System.Collections.Generic;

namespace LetsTest.Service
{
  public interface ICourseService
  {
   int SaveCourse(Course course);
   Course GetCourseById(int id);
   IEnumerable<Course> GetAllCourses();
  }
}