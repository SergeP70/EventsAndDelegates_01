using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video { Title = "Gladiator" };
            VideoEncoder videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}
