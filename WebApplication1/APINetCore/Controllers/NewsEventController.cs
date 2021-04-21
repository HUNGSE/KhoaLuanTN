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
    [Route("api/newsEvent")]
    [ApiController]
    public class NewsEventController : ControllerBase
    {
        private readonly INewsEventService _services;
        private readonly IMapper _mapper;
        public NewsEventController(INewsEventService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _services.GetAll();
            var listMap = _mapper.Map<IEnumerable<NewsEventModel>>(list);
            return Ok(listMap);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var item = _services.GetByID(id);
            var itemMap = _mapper.Map<NewsEventModel>(item);
            return Ok(itemMap);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, NewsEventModel updateModel)
        {
            var newsEventFromRepo = _services.GetByID(id);
            _mapper.Map(updateModel, newsEventFromRepo);
            _services.Update(newsEventFromRepo);
            _services.SaveChange();
            return Ok(updateModel);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var newsEventFromRepo = _services.GetByID(id);
            if (newsEventFromRepo == null)
                return BadRequest("Not a value newsEvent id");
            _services.Delete(newsEventFromRepo);
            _services.SaveChange();

            return Ok();
        }
    }
}
