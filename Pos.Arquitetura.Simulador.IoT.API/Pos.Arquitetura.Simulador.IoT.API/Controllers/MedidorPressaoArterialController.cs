using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pos.Arquitetura.Simulador.IoT.API.Controllers
{
    public class MedidorPressaoArterialController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<MedidorPressaoArterial> Get()
        {            
            return MedidorPressaoArterial.Log.Get();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]MedidorPressaoArterial value)
        {
            MedidorPressaoArterial.Log.Add(value);
        }
    }
}