using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMAutoRest.API
{
    public class SwashbuckleOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            var pathSegments = context.ApiDescription.RelativePath.Split(new[] { '/' });
            try
            {
                operation.OperationId = pathSegments.Last(x => !x.Contains("{"));
            }
            catch (Exception ex)
            {
                throw new Exception("Are you missing the [Route(\"[controller]/v1/[action]/\")] on your Controller?", ex);
            }
        }
    }
}
