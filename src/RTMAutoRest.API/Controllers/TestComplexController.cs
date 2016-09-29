using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;
using System.Net;
using RTMAutoRest.API.Models;

namespace RTMAutoRest.API.Controllers
{
    [Route("api/[controller]/v1/[action]")]
    public class TestComplexController : Controller
    {
        [HttpGet]
        [Produces(typeof(IEnumerable<TestComplex>))]
        public IActionResult GetAll()
        {
            return Ok(new List<TestComplex> { new TestComplex(), new TestComplex() });
        }

        [HttpGet("{id}")]
        [Produces(typeof(TestComplex))]
        public IActionResult GetByID(int id)
        {
            return Ok(new TestComplex() { Id = id });
        }

        [HttpGet("{id}/{typeID}/{from}/{to}")]
        [Produces(typeof(IEnumerable<TestComplex>))]
        public IActionResult GetByManyThings(int id, decimal typeID, DateTime from, DateTime to)
        {
            return Ok(new List<TestComplex> { new TestComplex(), new TestComplex() });
        }

        [HttpGet("{id}/{typeID}/{from}/{to}")]
        [Produces(typeof(IEnumerable<TestComplex>))]
        public IActionResult GetByManyThingsNullable(int id, long typeID, DateTime from, DateTime to, [FromQuery]long? userID = null)
        {
            return Ok(new List<TestComplex> { new TestComplex(), new TestComplex() });
        }


        [HttpPost]
        [Produces(typeof(TestComplex))]
        public IActionResult Post([FromBody]TestComplex complex)
        {
            return Ok(complex);
        }
    }
}