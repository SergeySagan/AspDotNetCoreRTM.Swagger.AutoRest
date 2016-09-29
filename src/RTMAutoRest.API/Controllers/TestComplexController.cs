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
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<TestComplex>))]
        public IActionResult GetAll()
        {
            return Json(new List<TestComplex> { new TestComplex(), new TestComplex() });
        }

        [HttpGet("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TestComplex))]
        public IActionResult GetByID(int id)
        {
            return Json(new TestComplex() { Id = id });
        }


        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TestComplex))]
        public IActionResult Post([FromBody]TestComplex complex)
        {
            return Json(complex);
        }
    }
}