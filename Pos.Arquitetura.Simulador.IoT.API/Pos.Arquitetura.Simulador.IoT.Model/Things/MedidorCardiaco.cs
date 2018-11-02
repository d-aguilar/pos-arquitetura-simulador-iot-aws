using System;

namespace Pos.Arquitetura.Simulador.IoT.Model.Things
{
    public class MedidorCardiaco
    {
        public string CodigoMedidor { get; set; }
        public int QuantidadeBatimentos { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }
    }
}
