using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainigCenterApi.DTOs;
using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainigCenterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursePriceHistoryController : ControllerBase
    {
        private readonly ICoursePriceHistory _ICoursePriceHistory;

        public CoursePriceHistoryController(ICoursePriceHistory ICoursePriceHistory)
        {
            _ICoursePriceHistory = ICoursePriceHistory;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _ICoursePriceHistory.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Certificate = await _ICoursePriceHistory.GetByIdAsync(id);
            if (Certificate == null) return NotFound();
            return Ok(Certificate);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCoursePriceHistoryDto dto)
        {
            var CoursePriceHistory = new CoursePriceHistory
            {
                TrainerCourseId = dto.TrainerCourseId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                OriginalPrice = dto.OriginalPrice,
                HasOffer = dto.HasOffer,
                DiscountPrice=dto.DiscountPrice
            };
            await _ICoursePriceHistory.AddAsync(CoursePriceHistory);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCoursePriceHistoryDto dto)
        {
            var CoursePriceHistory = await _ICoursePriceHistory.GetByIdAsync(dto.Id);
            if (CoursePriceHistory == null) return NotFound();

            // تعديل البيانات

            CoursePriceHistory.TrainerCourseId = dto.TrainerCourseId;
            CoursePriceHistory.StartDate = dto.StartDate;
            CoursePriceHistory.EndDate = dto.EndDate;
            CoursePriceHistory.OriginalPrice = dto.OriginalPrice;
            CoursePriceHistory.HasOffer = dto.HasOffer;
            CoursePriceHistory.DiscountPrice = dto.DiscountPrice;
            await _ICoursePriceHistory.UpdateAsync(CoursePriceHistory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ICoursePriceHistory.SoftDeleteAsync(id);
            return Ok();
        }
    }
}
