using AutoMapper;
using DataModule;
using IServiceBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINetCore.Controllers
{
    [Route("api/citys")]
    [ApiController]
    public class CitysController : ControllerBase
    {
        private readonly ICityServices _services;
        private readonly IMapper _mapper;
        public CitysController(ICityServices services,IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _services.GetAll();
            var listMap = _mapper.Map<IEnumerable<CityModel>>(list);
            return Ok(listMap);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var item = _services.GetByID(id);
            var itemMap = _mapper.Map<CityModel>(item);
            return Ok(itemMap);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CityModel updateModel)
        {
            var cityFromRepo = _services.GetByID(id);
            _mapper.Map(updateModel, cityFromRepo);
            _services.Update(cityFromRepo);
            _services.SaveChange();
            return Ok(updateModel);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cityFromRepo = _services.GetByID(id);
            if (cityFromRepo == null)
                return BadRequest("Not a value city id");
            _services.Delete(cityFromRepo);
            _services.SaveChange();

            return Ok();
        }

    }
}
