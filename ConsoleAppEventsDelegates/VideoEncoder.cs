using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppEventsDelegates
{
    class VideoEventArgs
    {
        public Video video { get; set; }
    }
    class VideoEncoder
    {
        public delegate void VideoEncodeEventHandlerDelegate(object Source, VideoEventArgs videoEventArgs);    //delegate

        public event VideoEncodeEventHandlerDelegate videoEncoded;  //event of above delegate
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding vedio...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (videoEncoded != null)
            {
                videoEncoded(this, new VideoEventArgs(){ video = video});
            }
        }
    }
}
