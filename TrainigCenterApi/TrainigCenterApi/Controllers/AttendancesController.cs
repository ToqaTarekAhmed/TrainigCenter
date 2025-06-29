
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
    public class AttendancesController : ControllerBase
    {

        private readonly IAttendance _repo;

        public AttendancesController(IAttendance repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Attendance = await _repo.GetByIdAsync(id);
            if (Attendance == null) return NotFound();
            return Ok(Attendance);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAttendanceDto dto)
        {
            var Attendance = new Attendance
            {
                CourseRegistrationId = dto.CourseRegistrationId,
                IsPresent = dto.IsPresent,
                Date     = dto.Date
            };
            await _repo.AddAsync(Attendance);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAttendanceDto dto)
        {
            var Attendance = await _repo.GetByIdAsync(dto.Id);
            if (Attendance == null) return NotFound();

            // تعديل البيانات
            Attendance.CourseRegistrationId = dto.CourseRegistrationId;
            Attendance.IsPresent = dto.IsPresent;
            Attendance.Date = dto.Date;
            await _repo.UpdateAsync(Attendance);
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
