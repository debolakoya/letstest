using System;

namespace LetsTest.Model
{
  public class Course
  {
    public Course()
    {
      Id = new Random().Next(1, 1000);
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string SomeInternalField { get; set; }
  }
}