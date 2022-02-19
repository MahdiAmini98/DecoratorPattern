using System;

namespace DecoratorPattern.Example_2.SampleByClass.SendEmail
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Send Email Is Success.......!");
        }
    }


    public class SendEmailDecorator : SendEmail
    {
        private readonly SendEmail _sendEmail;

        public SendEmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public void Send()
        {
            _sendEmail.Send();
            SaveLog();
        }


        //Add New Feature

        public void SaveLog()
        {
            Console.WriteLine("Save Log  Is Success....");
        }
    }
}
