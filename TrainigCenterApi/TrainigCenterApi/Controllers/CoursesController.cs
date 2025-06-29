using Microsoft.AspNetCore.Mvc;
using TrainigCenterApi.DTOs;
using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;


[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly  ICourse  _ICourse;

    public CourseController(ICourse ICourse)
    {
        _ICourse = ICourse;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _ICourse.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var course = await _ICourse.GetByIdAsync(id);
        if (course == null) return NotFound();
        return Ok(course);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCourseDto dto)
    {
        var course = new Course
        {
            Name = dto.Name
            
        };
            await _ICourse.AddAsync(course);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCourseDto dto)
    {
        var course = await _ICourse.GetByIdAsync(dto.Id);
        if (course == null) return NotFound();

        // تعديل البيانات
        course.Name = dto.Name;
       

        await _ICourse.UpdateAsync(course);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _ICourse.SoftDeleteAsync(id);
        return Ok();
    }
}
