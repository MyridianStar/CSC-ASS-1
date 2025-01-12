﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductStore.Controllers
{
    [RequireHttps]
    public class ValuesController : ApiController
    {
        [RequireHttps]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [RequireHttps]
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [RequireHttps]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [RequireHttps]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [RequireHttps]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
