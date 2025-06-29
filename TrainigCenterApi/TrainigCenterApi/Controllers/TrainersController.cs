
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
    public class TrainersController : ControllerBase
    {


        private readonly ITrainer _repo;

        public TrainersController(ITrainer repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Trainer = await _repo.GetByIdAsync(id);
            if (Trainer == null) return NotFound();
            return Ok(Trainer);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTrainerDto dto)
        {
            var Trainer = new Trainer
            {
                Name = dto.Name,
                Email = dto.Email,
                Address = dto.Address,
                HireDate=dto.HireDate,
                PhoneNumber=dto.PhoneNumber
               

            };
            await _repo.AddAsync(Trainer);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTrainerDto dto)
        {
            var trainer = await _repo.GetByIdAsync(dto.Id);
            if (trainer == null) return NotFound();

            
            trainer.Name = dto.Name;
            trainer.Email = dto.Email;
            trainer.Address = dto.Address;
            trainer.HireDate = dto.HireDate;
            trainer.PhoneNumber = dto.PhoneNumber;
            await _repo.UpdateAsync(trainer);
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
