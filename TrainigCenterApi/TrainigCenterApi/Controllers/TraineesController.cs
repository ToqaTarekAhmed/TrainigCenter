
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using TrainigCenterApi.DTOs;
using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainingCenterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TraineesController : ControllerBase
    {
        


        private readonly ITrainee _repo;

        public TraineesController(ITrainee repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Trainee = await _repo.GetByIdAsync(id);
            if (Trainee == null) return NotFound();
            return Ok(Trainee);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTraineeDto dto)
        {
            var Trainee = new Trainee
            {
                Name = dto.Name,
                Email=dto.Email,
                PhoneNumber=dto.PhoneNumber,
                Address = dto.Address,
               
            };
            await _repo.AddAsync(Trainee);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTraineeDto dto)
        {
            var trainee = await _repo.GetByIdAsync(dto.Id);
            if (trainee == null) return NotFound();

            // تعديل البيانات
            trainee.Name = dto.Name;
            trainee.Email = dto.Email;
            trainee.Address = dto.Address;
            trainee.PhoneNumber = dto.PhoneNumber;
            await _repo.UpdateAsync(trainee);
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
