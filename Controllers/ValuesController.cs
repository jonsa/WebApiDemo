using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using WebApiDemo.Models;
using WebApiDemo.NSwag;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private List<ValueModel> _values = new List<ValueModel>()
        {
            new ValueModel { Value = "value1" },
            new ValueModel { Value = "value2" }
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<ValueModel> Get()
        {
            return _values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.BadRequest, typeof(ErrorResponse<ValueModel>), Description = "Data failed validation")]
        public void Post([FromBody]ValueModel value)
        {
            _values.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
