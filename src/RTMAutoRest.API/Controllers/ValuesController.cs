using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace RTMAutoRest.API.Controllers
{   /// <summary>
    /// Test API
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// Gets a list of all of the strings
        /// </summary>
        /// <returns>IEnumerable of string</returns>
        [HttpGet]
        [Produces(typeof(IEnumerable<string>))]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(IEnumerable<string>))]
        public IEnumerable<string> Get()
        {
            return new string[] { "value 1", "value 2" };
        }

        /// <summary>
        /// Gets string by ID
        /// </summary>
        /// <returns>string</returns>
        [HttpGet("{id}")]
        [Produces(typeof(string))]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(string))]
        public string Get(int id)
        {
            return "value " + id;
        }


        /// <summary>
        /// Post string
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Put string
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete string by ID
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}