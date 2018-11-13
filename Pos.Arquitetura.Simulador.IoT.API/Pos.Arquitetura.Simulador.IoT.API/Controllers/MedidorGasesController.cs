using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pos.Arquitetura.Simulador.IoT.Model.Things;

namespace Pos.Arquitetura.Simulador.IoT.API.Controllers
{
    [Route("api/[controller]")]
    public class MedidorGasesController : Controller
    {
         // GET api/values
        [HttpGet]
        public IEnumerable<MedidorGases> Get()
        {
            return MedidorGases.Log.Get();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]MedidorGases value)
        {
            MedidorGases.Log.Add(value);
        }

    }
}