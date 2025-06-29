
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
    public class CourseRegistrationsController : ControllerBase
    {

        private readonly ICourseRegistartion _repo;

        public CourseRegistrationsController(ICourseRegistartion repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var CourseRegistration = await _repo.GetByIdAsync(id);
            if (CourseRegistration == null) return NotFound();
            return Ok(CourseRegistration);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseRegistrationDto dto)
        {
            var CourseRegistration = new CourseRegistration
            {
                TraineeId = dto.TraineeId,
                TrainerCourseId = dto.TrainerCourseId,
                CoursePriceHistoryId = dto.CoursePriceHistoryId,
                RegistrationDate=DateTime.Now
            };
            await _repo.AddAsync(CourseRegistration);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCourseRegistrationDto dto)
        {
            var CourseRegistration = await _repo.GetByIdAsync(dto.Id);
            if (CourseRegistration == null) return NotFound();

            // تعديل البيانات
            CourseRegistration.TraineeId = dto.TraineeId;
            CourseRegistration.TrainerCourseId = dto.TrainerCourseId;
            CourseRegistration.CoursePriceHistoryId = dto.CoursePriceHistoryId;
            CourseRegistration.IsPaid = dto.IsPaid;
            CourseRegistration.PaidDate = dto.PaidDate;
            await _repo.UpdateAsync(CourseRegistration);
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