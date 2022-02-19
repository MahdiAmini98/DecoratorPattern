using System;
using System.Net;
using DecoratorPattern.Example_2.SampleByClass.SendEmail;
using DecoratorPattern.Example_3.WebClient;
using DecoratorPattern.Example_4.Decorator;
using DecoratorPattern.Example_4.SimpleByInterface;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 : Decorator Design Pattern

            ConcreteComponent concreteComponent = new ConcreteComponent();
            ConcreteDecorator decorator = new ConcreteDecorator(concreteComponent);
            decorator.Operation();

            //Example 2 :A simple example of a class with a Decorator Design Pattern

            SendEmail sendEmail = new SendEmail();
            SendEmailDecorator decoratorEmail=new SendEmailDecorator(sendEmail);
            decoratorEmail.Send();

            //Example 3 : Use WebClient (Class .NetCore) with a Decorator Design Pattern

            WebClient webClient = new WebClient();
            //string source = webClient.DownloadString("https://www.google.com");

            WebClientDecorator decoratorWebClient=new WebClientDecorator(webClient);
            string source = decoratorWebClient.DownloadString("https://www.Bugeto.com");


            //Example 4 :Use Interface with a  Decorator Design Pattern

            IAddNewProductService service = new AddNewProductService();
            LoggingDecorator decoratorLogging = new LoggingDecorator(service);
            Console.ReadLine();
        }
    }
}
