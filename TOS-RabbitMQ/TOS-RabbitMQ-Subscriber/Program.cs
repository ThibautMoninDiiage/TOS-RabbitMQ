using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost", UserName = "user", Password = "password"};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "tos", durable: false, exclusive: false, autoDelete: false, arguments: null);

Console.WriteLine("Waiting for messages.");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"Received {message}");
};
channel.BasicConsume(queue: "tos",
    autoAck: true,
    consumer: consumer);

Console.WriteLine(" Press a key to exit.");
Console.ReadLine();
