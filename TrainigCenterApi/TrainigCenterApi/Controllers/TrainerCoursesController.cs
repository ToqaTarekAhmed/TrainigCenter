
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainigCenterApi.DTOs;
using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;


namespace TrainingCenterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainerCoursesController : ControllerBase
    {

        private readonly ITrainerCourse _repo;

        public TrainerCoursesController(ITrainerCourse repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var TrainerCourse = await _repo.GetByIdAsync(id);
            if (TrainerCourse == null) return NotFound();
            return Ok(TrainerCourse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTrainerCourseDto dto)
        {
            var TrainerCourse = new TrainerCourse
            {
                TrainerId = dto.TrainerId,
                CourseId = dto.CourseId


            };
            await _repo.AddAsync(TrainerCourse);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTrainerCourseDto dto)
        {
            var TrainerCourse = await _repo.GetByIdAsync(dto.Id);
            if (TrainerCourse == null) return NotFound();


            TrainerCourse.TrainerId = dto.TrainerId;
            TrainerCourse.CourseId = dto.CourseId;
            await _repo.UpdateAsync(TrainerCourse);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.SoftDeleteAsync(id);
            return Ok();
        }
    }
}
