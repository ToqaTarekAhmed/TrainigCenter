using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainigCenterApi.DTOs;
using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainigCenterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedBack _repo;

        public FeedbackController(IFeedBack repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var FeedBack = await _repo.GetByIdAsync(id);
            if (FeedBack == null) return NotFound();
            return Ok(FeedBack);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFeedbackDto dto)
        {
            var FeedBack = new Feedback
            {
                CourseRegistrationId = dto.CourseRegistrationId,
                Comment = dto.Comment,
                Rating = dto.Rating,
            };
            await _repo.AddAsync(FeedBack);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFeedbackDto dto)
        {
            var FeedBack = await _repo.GetByIdAsync(dto.Id);
            if (FeedBack == null) return NotFound();

            // تعديل البيانات
            FeedBack.CourseRegistrationId = dto.CourseRegistrationId;
            FeedBack.Comment = dto.Comment;
            FeedBack.Rating = dto.Rating;
            await _repo.UpdateAsync(FeedBack);
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
