using System;
using System.Threading;

namespace ConsoleAppEventsDelegates
{
    class Program
    {        
        static void Main(string[] args)
        {
            var video = new Video() { Tittle = "Video1" };  
            var videoEncoder = new VideoEncoder();  //publisher
            var mailServie = new MailService(); //subscriber

            videoEncoder.videoEncoded += MailService.onVideoEncoded;
            //videoEncoder.Encode(video);

            //Adding one more service now without many change to classes
            Console.WriteLine();
            var messageService = new MessageService();  //subsriber
            videoEncoder.videoEncoded += MessageService.onVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
