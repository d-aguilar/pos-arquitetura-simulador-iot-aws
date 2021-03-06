﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pos.Arquitetura.Simulador.IoT.Model.Things;

namespace Pos.Arquitetura.Simulador.IoT.API.Controllers
{
    [Route("api/[controller]")]
    public class MedidorCardiacoController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<MedidorCardiaco> Get()
        {
            return MedidorCardiaco.Log.Get();
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody]MedidorCardiaco value)
        {
            MedidorCardiaco.Log.Add(value);
        }

    }
}
