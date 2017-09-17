using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConEventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a Delegate (eventhandler)
        // 2. Define an Event based on that Delegate
        // 3. Raise the event
        public delegate void VideoEncodeEventHandler(object sender, EventArgs e);
        public event VideoEncodeEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);

            OnVideoEncoded();
        }

        public void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
