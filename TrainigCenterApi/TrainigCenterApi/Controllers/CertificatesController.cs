
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
    public class CertificatesController : ControllerBase
    {

        private readonly ICertificate _repo;

        public CertificatesController(ICertificate repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Certificate = await _repo.GetByIdAsync(id);
            if (Certificate == null) return NotFound();
            return Ok(Certificate);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCertificateDto dto)
        {
            var Certificate = new Certificate
            {
                CourseRegistrationId = dto.CourseRegistrationId,
                CertificateUrl = dto.CertificateUrl,
                IssueDate = dto.IssueDate,
            };
            await _repo.AddAsync(Certificate);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCertificateDto dto)
        {
            var Certificate = await _repo.GetByIdAsync(dto.Id);
            if (Certificate == null) return NotFound();

            // تعديل البيانات
            Certificate.CourseRegistrationId = dto.CourseRegistrationId;
            Certificate.CertificateUrl = dto.CertificateUrl;
            Certificate.IssueDate = dto.IssueDate;
            await _repo.UpdateAsync(Certificate);
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
