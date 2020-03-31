using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsSwagger.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OperationsController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public double GetSomma(double a, double b)
        {
            return a + b;
        }
        [HttpGet]
        public double GetProdotto(double a, double b)
        {
            return a * b;
        }

        [HttpGet]
        public double GetSottrazione(double a, double b)
        {
            return a - b;
        }
        [HttpGet]
        public double GetDivisione(double a, double b)
        {
            return a/b;
        }

        [HttpGet]
        public double GetElevamentoAlQuadrato(double a )
        {
            return a * a;
        }

        RepositoryCovid repo;
        [HttpGet]

        public int GetNumeriPositivi()
        {
            repo = new RepositoryCovid();
            List<Covid19_Data> listaPositivi = repo.LoadCovidUmbria();
            Covid19_Data item = listaPositivi.Last<Covid19_Data>();
            return item.NuoviPositivi;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
