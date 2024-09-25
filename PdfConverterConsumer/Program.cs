using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Aspose.Words;
using System.IO;

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
                    // Kuyruktan alınan dosya yolunu al
                    string wordFilePath = System.Text.Encoding.UTF8.GetString(ea.Body.ToArray());
                    string outputPdfPath = Path.ChangeExtension(wordFilePath, ".pdf"); // Çıktı PDF dosyası için yol

                    // Word dosyasını PDF'ye dönüştür
                    ConvertWordToPdf(wordFilePath, outputPdfPath);

                    Console.WriteLine(" [x] Dosya PDF'ye dönüştürüldü ve kaydedildi: " + outputPdfPath);
                };

                channel.BasicConsume(queue: "pdf_conversion_queue",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" [x] Kuyruktan mesajlar bekleniyor...");
                Console.ReadLine();  // Konsol açık kalsın
            }
        }

        private static void ConvertWordToPdf(string wordFilePath, string pdfFilePath)
        {
            Document doc = new Document(wordFilePath);
            doc.Save(pdfFilePath); 
        }
    }
}
