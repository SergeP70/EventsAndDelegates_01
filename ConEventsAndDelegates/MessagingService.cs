using System;

namespace ConEventsAndDelegates
{
    public class MessagingService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("MESSAGING-SERVICE: sending a text message...");
        }
    }
}
