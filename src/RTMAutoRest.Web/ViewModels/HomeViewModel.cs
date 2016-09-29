using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTMAutoRest.Clients;
using System.Diagnostics;

namespace RTMAutoRest.Web.ViewModels
{
    public class HomeViewModel
    {
        public const string Success = "Success";
        public const string Failed = "Failed";
        private const string TestAPIUri = "http://localhost:8474/";
        bool? isEndpointCallable;

        public string EndpointStatus => IsEndpointCallable() ? Success : Failed;

        private bool IsEndpointCallable()
        {
            if (isEndpointCallable.HasValue)
                return isEndpointCallable.Value;

            try
            {
                ITestAPI testAPI = new TestAPI(new Uri(TestAPIUri));

                isEndpointCallable = testAPI.GetByID(1) != null;
            }
            catch (Exception e)
            {
                Debug.WriteLine("\n\t" + e.Message, "TestAPI Call Exception Message");

                isEndpointCallable = false;
            }

            return isEndpointCallable.Value;
        }
    }
}
