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
    [Route("aip/districts")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrictService _services;
        private readonly IMapper _mapper;
        public DistrictsController(IDistrictService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult getALL()
        {
            var list = _services.GetAll();
            var listMap = _mapper.Map<IEnumerable<DistrictsModel>>(list);
            return Ok(listMap);

        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var item = _services.GetByID(id);
            var itemMap = _mapper.Map<DistrictsModel>(item);
            return Ok(itemMap);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, DistrictsModel updateModel)
        {
            var districtFromRepo = _services.GetByID(id);
            _mapper.Map(updateModel, districtFromRepo);
            _services.Update(districtFromRepo);
            _services.SaveChange();
            return Ok(updateModel);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var districtFromRepo = _services.GetByID(id);
            if (districtFromRepo == null)
                return BadRequest("Not a value distric   id");

            _services.Delete(districtFromRepo);
            _services.SaveChange();
            return Ok();
        }
    }
}
