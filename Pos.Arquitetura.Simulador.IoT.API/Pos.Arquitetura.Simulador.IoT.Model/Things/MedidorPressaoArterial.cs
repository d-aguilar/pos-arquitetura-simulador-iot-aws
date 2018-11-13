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
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }

        public static class Log 
        {
            private static List<MedidorPressaoArterial> lista = new List<MedidorPressaoArterial>();
            
            public static void Add(MedidorPressaoArterial model)
            {
                lista.add(model);
            }

            public static List<MedidorPressaoArterial> Get()
            {
                return lista;
            }
        }
    }
}
