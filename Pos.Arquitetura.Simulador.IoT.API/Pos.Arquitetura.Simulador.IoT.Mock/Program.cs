using System;
using System.Net.Http;

namespace Pos.Arquitetura.Simulador.IoT.Mock
{
    class Program
    {
        private static readonly HttpClient clientIoTAws = new HttpClient();
        private static readonly HttpClient clientApiHospital = new HttpClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Simulador de Paciente!");
            var urlCoisasAws = "https://a27ytjunf797pi-ats.iot.us-east-1.amazonaws.com/things/";
            var urlAPIHospital = "http://localhost:54033/api";
            var sufixoMedidorCardiaco = "/MedidorCardiaco/shadow";
            var sufixoMedidorPressao = "/MedidorPressao/shadow";
            var sufixoSensorRespiracao = "/SensorRespiracao/shadow";

            clientIoTAws.BaseAddress = new Uri(urlCoisasAws);

            var resultadoMedidorCardiaco = clientIoTAws.GetAsync(sufixoMedidorCardiaco);
            var resultadoMedidorPressao = clientIoTAws.GetAsync(sufixoMedidorPressao);
            var resultadoSensorRespiracao = clientIoTAws.GetAsync(sufixoSensorRespiracao);

            clientApiHospital.BaseAddress = new Uri(urlAPIHospital);

        }
    }
}
