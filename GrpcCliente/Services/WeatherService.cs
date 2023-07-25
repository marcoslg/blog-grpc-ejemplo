using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcCliente.Services
{
    internal class WeatherService 
    {
        private readonly GrpcEjemplo.Protos.WeatherService.WeatherServiceClient _client;
        public WeatherService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7069");
            _client = new GrpcEjemplo.Protos.WeatherService.WeatherServiceClient(channel);
        }
    }
}
