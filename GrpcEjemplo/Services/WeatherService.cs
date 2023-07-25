
using Grpc.Core;
using GrpcEjemplo.Protos;

namespace GrpcEjemplo.Services
{
    public class WeatherService: GrpcEjemplo.Protos.WeatherService.WeatherServiceBase
    {
        
        public override async Task<Temperature> send(Location request, ServerCallContext context)
        {
            return new Temperature()
            {
                Celsius = 20.5
            };
        }
    }
}
