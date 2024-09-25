using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfConverterConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "pdf_conversion_queue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    string outputPdfPath = "convertedFile.pdf"; 

                    using (MemoryStream ms = new MemoryStream(body))
                    {
                        using (FileStream fs = new FileStream(outputPdfPath, FileMode.Create))
                        {
                            Document doc = new Document();
                            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Burada dosya içeriğini PDF'ye ekleyebilirsiniz
                            doc.Add(new Paragraph("Dosya başarıyla PDF'ye çevrildi!"));

                            doc.Close();
                        }
                    }

                    Console.WriteLine(" [x] Dosya PDF'ye çevrildi ve kaydedildi.");
                };

                channel.BasicConsume(queue: "pdf_conversion_queue",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" [x] Kuyruktan mesajlar bekleniyor...");
                Console.ReadLine();  // Konsol açık kalsın
            }
        }
    }
}
