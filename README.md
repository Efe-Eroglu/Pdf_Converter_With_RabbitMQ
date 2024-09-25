# <p align="center"> Word to PDF Converter with RabbitMQ </p>

## Proje Tanımı

Bu proje, RabbitMQ kullanarak Word belgelerini PDF formatına dönüştüren bir masaüstü uygulamasıdır. Uygulama, Word dosyalarını kuyruğa ekleyerek asenkron bir şekilde dönüştürme işlemini gerçekleştirir. Bu sayede, kullanıcılar dönüşüm işlemlerini arka planda gerçekleştirirken uygulamanın diğer özelliklerini kullanabilirler.

## Özellikler

- Word belgelerini PDF'ye dönüştürme
- RabbitMQ ile asenkron işlem yönetimi
- Kullanıcı dostu arayüz
- Dönüştürülen PDF dosyalarının belirtilen bir klasöre kaydedilmesi

## Gereksinimler

- .NET Framework
- RabbitMQ Server
- Aspose.Words

## Kurulum

1. **RabbitMQ Kurulumu**
   - RabbitMQ sunucusunu indirip kurun. [RabbitMQ İndirme Sayfası](https://www.rabbitmq.com/download.html)

2. **Projenin İndirilmesi**
   - Bu projeyi GitHub üzerinden indirin:
   
     ```bash
     git clone https://github.com/Efe-Eroglu/Pdf_Converter_With_RabbitMQ.git
     ```

3. **Gerekli Kütüphanelerin Yüklenmesi**
   - Proje dizininde gerekli kütüphaneleri yüklemek için ilgili .NET paket yöneticisini kullanın.


4. **Uygulamanın Çalıştırılması**

* 4.1
   - Uygulamayı başlatmak için projenin ana dosyasını çalıştırın.
   - Projeyi çalıştırmadan önce Proje yapılandırımasından iki projeninde aynı anda çalışması için seçeneği değiştirin.

  Veya;
  
* 4.2

  - Uygulama dosyalarının bulunduğu klasörde cmd kullanarak komutu çalıştırın.
    ```bash
    dotnet run
    ``` 

## Kullanım

1. Uygulamayı başlatın.
2. Dönüştürme işlemini için dosyanızı butona basarak seçin ve onaylayın.
3. Dönüştürülen PDF dosyası orijinal dosyanın yanına kaydedilecektir.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları izleyin:

1. Bu projeyi fork edin.
2. Yeni bir özellik için bir dal oluşturun (`git checkout -b feature/YeniOzellik`).
3. Değişikliklerinizi yapın ve commit edin (`git commit -m 'Yeni özellik eklendi'`).
4. Dalınızı GitHub'a push edin (`git push origin feature/YeniOzellik`).
5. Bir Pull Request açın.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakın.






## << En >>


# <p align="center"> Word to PDF Converter with RabbitMQ</p>

## Project Description

This project is a desktop application that converts Word documents to PDF format using RabbitMQ. The application performs the conversion asynchronously by queuing the Word files. This allows users to utilize other features of the application while the conversion process is carried out in the background.

## Features

- Convert Word documents to PDF
- Asynchronous task management with RabbitMQ
- User-friendly interface
- Saving converted PDF files to a specified folder

## Requirements

- .NET Framework
- RabbitMQ Server
- Aspose.Words

## Installation

1. **RabbitMQ Installation**
   - Download and install the RabbitMQ server from the [RabbitMQ Download Page](https://www.rabbitmq.com/download.html).

2. **Clone the Project**
   - Clone this project from GitHub:
   
     ```bash
     git clone https://github.com/Efe-Eroglu/Pdf_Converter_With_RabbitMQ.git
     ```

3. **Install Required Libraries**
   - Use the relevant .NET package manager to install the necessary libraries in the project directory.

4. **Run the Application**

* 4.1
   - To start the application, run the main file of the project.
   - Change the option in the project configuration to allow both projects to run simultaneously.

  Or;
  
* 4.2
   - Use the command line to run the command in the folder where the application files are located:
    ```bash
    dotnet run
    ``` 

## Usage

1. Start the application.
2. Select your file for conversion by clicking the button and confirm.
3. The converted PDF file will be saved next to the original file.

## Contribution

If you would like to contribute to this project, please follow these steps:

1. Fork this project.
2. Create a branch for a new feature (`git checkout -b feature/NewFeature`).
3. Make your changes and commit them (`git commit -m 'Added a new feature'`).
4. Push your branch to GitHub (`git push origin feature/NewFeature`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License. For more details, see the LICENSE file.
