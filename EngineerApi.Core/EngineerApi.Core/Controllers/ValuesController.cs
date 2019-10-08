using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngineerApi.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using EngineerApi.Core.Entities.Extensions;
using EngineerApi.Core.Models;

namespace EngineerApi.Core.Controllers
{
    [Route("api/engineer")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public ValuesController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var engineer = _repository.Engineer.GetAllEngineers();

                return Ok(engineer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "EngineerById")]
        public IActionResult GetEngineerById(Guid id)
        {
            try
            {
                var engineer = _repository.Engineer.GetEngineerById(id);

                if (engineer.IsEmptyObject())
                {
                    return NotFound();
                }
                else
                {
                    return Ok(engineer);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult CreateEngineer([FromBody]Engineer engineer)
        {
            try
            {
                if (engineer.IsObjectNull())
                {
                    return BadRequest("Engineer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                _repository.Engineer.CreateEngineer(engineer);

                return CreatedAtRoute("EngineerById", new { id = engineer.Id }, engineer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult UpdateEngineer(Guid id, [FromBody]Engineer engineer)
        {
            try
            {
                if (engineer.IsObjectNull())
                {
                    return BadRequest("Engineer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var dbEngineer = _repository.Engineer.GetEngineerById(id);
                if (dbEngineer.IsEmptyObject())
                {
                    return NotFound();
                }

                _repository.Engineer.UpdateEngineer(dbEngineer, engineer);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEngineer(Guid id)
        {
            try
            {
                var engineer = _repository.Engineer.GetEngineerById(id);
                if (engineer.IsEmptyObject())
                {
                    return NotFound();
                }

                _repository.Engineer.DeleteEngineer(engineer);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
