﻿using System;

namespace Pos.Arquitetura.Simulador.IoT.Model.Things
{
    public class MedidorCardiaco
    {
        public string CodigoMedidor { get; set; }
        public int QuantidadeBatimentos { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }
        
        public static class Log 
        {
            private static List<MedidorCardiaco> lista = new List<MedidorCardiaco>();
            
            public static void Add(MedidorCardiaco model)
            {
                lista.add(model);
            }

            public static List<MedidorCardiaco> Get()
            {
                return lista;
            }
        }
    }
}
