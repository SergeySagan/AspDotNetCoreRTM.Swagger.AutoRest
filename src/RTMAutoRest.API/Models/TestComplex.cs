using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RTMAutoRest.API.Models
{
    public class TestComplex
    {
        public TestComplex()
        {
            Id = DateTime.Now.Ticks;
            Names = new List<string> { "Some", "Cool", "Names" };
        }

        [Required]
        public long Id { get; set; }

        public List<string> Names { get; set; }
    }
}
