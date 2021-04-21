using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IServices;
using AutoMapper;
using DataModule;

namespace APINetCore.Controllers
{
    [Route("api/projectTypes")]
    [ApiController]
    public class ProjectTypesController : ControllerBase
    {
        private readonly  IProjectTypeService _services;
        private readonly IMapper _mapper;
        public ProjectTypesController(IProjectTypeService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _services.GetAll();
            var listMap = _mapper.Map<IEnumerable<ProjectTypesModel>>(list);
            return Ok(listMap);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var item = _services.GetByID(id);
            var itemMap = _mapper.Map<ProjectTypesModel>(item);
            return Ok(itemMap);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProjectTypesModel updateModel)
        {
            var projectTypesFromRepo = _services.GetByID(id);
            _mapper.Map(updateModel, projectTypesFromRepo);
            _services.Update(projectTypesFromRepo);
            _services.SaveChange();
            return Ok(updateModel);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var projectTypesFromRepo = _services.GetByID(id);
            if (projectTypesFromRepo == null)
                return BadRequest("Not a value projectType id");
            _services.Delete(projectTypesFromRepo);
            _services.SaveChange();

            return Ok();
        }
    }
}
