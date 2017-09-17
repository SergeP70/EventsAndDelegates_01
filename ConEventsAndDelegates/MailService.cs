using System;

namespace ConEventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("MAILSERVICE: sending an email...");
        }
    }
}
