using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Arquitetura.Simulador.IoT.Model.Things
{
    public class MedidorPressaoArterial
    {
        public string CodigoMedidor { get; set; }
        public decimal Sistolica { get; set; }
        public decimal Diastolica { get; set; }
    }
}
