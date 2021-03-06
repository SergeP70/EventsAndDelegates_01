﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConEventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1. Define a Delegate (eventhandler)
        // 2. Define an Event based on that Delegate
        // 3. Raise the event
        public delegate void VideoEncodeEventHandler(object sender, VideoEventArgs e);
        public event VideoEncodeEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);

            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { Video = video });
        }
    }
}
