using AutoMapper;
using DataModule;
using IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINetCore.Controllers
{
    [Route("api/communes")]
    [ApiController]
    public class CommunnesController : ControllerBase
    {
        private readonly ICommuneService _services;
        private readonly IMapper _mapper;
        public CommunnesController(ICommuneService repository, IMapper mapper)
        {
            _services = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult getALL()
        {
            var list = _services.GetAll();
            var listMap = _mapper.Map<IEnumerable<CommunesModel>>(list);
            return Ok(listMap);

        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var item = _services.GetByID(id);
            var itemMap = _mapper.Map<CommunesModel>(item);
            return Ok(itemMap);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CommunesModel updateModel)
        {
            var communeFromRepo = _services.GetByID(id);
            _mapper.Map(updateModel, communeFromRepo);
            _services.Update(communeFromRepo);
            _services.SaveChange();
            return Ok(updateModel);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var communeFromRepo = _services.GetByID(id);
            if (communeFromRepo == null)
                return BadRequest("Not a value commune   id");
            
            _services.Delete(communeFromRepo);
            _services.SaveChange();
            return Ok();
        }

    }
}
