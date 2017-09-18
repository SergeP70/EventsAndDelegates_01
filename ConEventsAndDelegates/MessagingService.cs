using System;

namespace ConEventsAndDelegates
{
    public class MessagingService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("MESSAGING-SERVICE: sending a text message..." + e.Video.Title);
        }
    }
}
