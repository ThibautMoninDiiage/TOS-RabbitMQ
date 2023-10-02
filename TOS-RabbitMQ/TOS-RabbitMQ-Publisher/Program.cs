using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost", UserName = "user", Password = "password"};
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "tos", durable: false, exclusive: false, autoDelete: false, arguments: null);

const string message = "TOS RabbitMQ";

var body = Encoding.UTF8.GetBytes(message);

channel.BasicPublish(exchange: string.Empty, routingKey: "tos", basicProperties: null, body: body);

Console.WriteLine($"Sent {message}");
Console.ReadLine();
