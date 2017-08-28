using System;
using System.Collections.Generic;
using System.Configuration;
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
    [EnableCors("*", "*", "*")]
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
                new Hero()    { Id=11, Name="Mr. Nice" },
                new Hero()    { Id=12, Name="Narco"},
                new Hero()    { Id=13, Name="Bombasto" },
                new Hero()    { Id=14, Name="Celeritas" },
                new Hero()    { Id=15, Name="Magneta" },
                new Hero()    { Id=16, Name="RubberMan" },
                new Hero()    { Id=17, Name="Dynama" },
                new Hero()    { Id=18, Name="Dr IQ" },
                new Hero()    { Id=19, Name="Magma" },
                new Hero()    { Id=20, Name="Tornado" }
            };
        }
    }
}
