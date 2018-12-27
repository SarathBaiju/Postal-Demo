using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PostalEg.Controllers
{
    public class CronosCommLinkClientController : ApiController
    {
        // GET: api/CronosCommLinkClient
        [HttpPost]
        public IEnumerable<string> Send_E1([FromBody] MyClass obj)
        {
            
            return new string[] { "value1", "value2" };
        }

        
    }
    public class MyClass
    {
        public int UserId { get; set; }
    }
}
