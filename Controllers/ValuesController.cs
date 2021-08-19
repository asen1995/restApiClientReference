using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace restApiClientReference.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "2", "3", "4", "5", "6" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "GET id : " + id ;
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return "Post value is : " + value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] string value)
        {
            return "Put value is : " + id;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Delete id is : " + id;
        }
    }
}
