using System;

namespace ConEventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("MAILSERVICE: sending an email..." + e.Video.Title);
        }
    }
}
