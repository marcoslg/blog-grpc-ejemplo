// See https://aka.ms/new-console-template for more information
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcEjemplo.Protos;

Console.WriteLine("Hello, World!");

// es como si fuera el httpClient, de hecho le puedes indicar tu un httpClient
var channel = GrpcChannel.ForAddress("http://localhost:5282"); 

//creamos una instancia del servicio client
var client = new GrpcEjemplo.Protos.WeatherService.WeatherServiceClient(channel);

//El mensaje que queremos enviar
var request = new Location()
{
    City = "Barcelona",
    Day = Timestamp.FromDateTime(DateTime.UtcNow)
};
//hacemos la llamada
var response = await client.sendAsync(request);

Console.WriteLine($"Temperatura {response.Celsius}");

Console.ReadLine();