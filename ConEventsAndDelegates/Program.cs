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
            
            MailService mailService = new MailService();
            MessagingService messagingService = new MessagingService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messagingService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
