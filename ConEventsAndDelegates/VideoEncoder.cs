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
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);
        }
    }
}
