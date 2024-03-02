using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Exercise;
using Api.Domain.Interfaces.Services.Exercise;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class ExerciseController : ControllerBase {
        public IExerciseService _service { get; set; }

        public ExerciseController(IExerciseService service) {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll() {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _service.GetAll());
            } catch (ArgumentException error) {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post ([FromBody] ExerciseDtoCreate exercise) {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _service.Post(exercise);
                if(result != null) {
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                } else {
                    return BadRequest();
                }
            } catch (ArgumentException error) {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }
    }
}