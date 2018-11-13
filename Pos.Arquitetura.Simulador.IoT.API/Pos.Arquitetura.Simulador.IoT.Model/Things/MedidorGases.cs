using System;

namespace Pos.Arquitetura.Simulador.IoT.Model.Things
{
    public class MedidorGases
    {
        public string CodigoMedidor { get; set; }
        public string TipoGas{ get; set; }
        public double QuantidadeLiberada { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }

        public static class Log 
        {
            private static List<MedidorGases> lista = new List<MedidorGases>();
            
            public static void Add(MedidorGases model)
            {
                lista.add(model);
            }

            public static List<MedidorGases> Get()
            {
                return lista;
            }
        }
    }
}