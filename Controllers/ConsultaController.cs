using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaMediMan.Controllers
{
    public class ConsultaController : ApiController
    {
        // GET: api/Consulta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Consulta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Consulta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Consulta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Consulta/5
        public void Delete(int id)
        {
        }
    }
}
