using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HeroesAPI.Models;
using Swashbuckle.Swagger.Annotations;

namespace HeroesAPI.Controllers
{
    //[EnableCors("http://learningangular.azurewebsites.net", "*", "*")]
    [EnableCors("http://localhost:8808", "*", "*")]
    public class ValuesController : ApiController
    {
        public Hero[] Heroes { get; set; }

        // GET api/values
        [SwaggerOperation("GetAll")]
        public IEnumerable<Hero> Get()
        {
            return Heroes;
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Hero Get(int id)
        {
            return Heroes.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }

        public ValuesController()
        {
            Heroes = new Hero[]
            {
                new Hero() {Id = 20, Name = "Hero 1"},
                new Hero() {Id = 21, Name = "Hero 2"}
            };
        }
    }
}
