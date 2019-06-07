using AutoMapper;
using LetsTest.Api.DTOs;
using LetsTest.Model;
using LetsTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LetsTest.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  [Produces("application/json")]
  [ProducesResponseType(StatusCodes.Status500InternalServerError)]
  public class CoursesController : ControllerBase
  {
    private readonly ICourseService _courseService;
    private readonly IMapper _mapper;

    public CoursesController(ICourseService courseService, IMapper mapper)
    {
      _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    {
      var data = _courseService.GetAllCourses();
      return Ok(_mapper.Map<List<CourseDto>>(data));
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetById(int id)
    {
      var data = _courseService.GetCourseById(id);
      if (data == null)
        return NotFound();

      return Ok(_mapper.Map<CourseDto>(data));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(CourseDto), StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] CourseDto course)
    {
      //Check if the course exist 
      if (!ModelState.IsValid)
        return StatusCode(StatusCodes.Status400BadRequest, new
        {
          Message = "Course Name is required"
        });
      var newCourseModel = _mapper.Map<Course>(course);
      var result = _courseService.SaveCourse(newCourseModel);

      if (result <= 0)
        return StatusCode(StatusCodes.Status400BadRequest, new
        {
          Message = "Chapter could not be saved."
        });

      return CreatedAtAction("Get", new {id = newCourseModel.Id}, _mapper.Map<CourseDto>(newCourseModel));
    }
  }
}