using RabbitMQ.Client;

namespace Pdf_Converter_RabbitMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|Word Files|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                SendMessageToQueue(filePath);
                MessageBox.Show("Dosya kuyru�a g�nderildi!");
            }
        }

        // RabbitMQ'ya dosya g�nderme fonksiyonu
        public void SendMessageToQueue(string filePath)
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

                // Dosyay� byte array'e �eviriyoruz
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // RabbitMQ kuyru�una dosya i�eri�ini g�nderiyoruz
                channel.BasicPublish(exchange: "",
                                     routingKey: "pdf_conversion_queue",
                                     basicProperties: null,
                                     body: fileBytes);

                Console.WriteLine(" [x] Dosya kuyru�a g�nderildi.");
            }
        }
    }
}
