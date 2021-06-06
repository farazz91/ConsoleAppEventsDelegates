using System;
using System.Threading;

namespace ConsoleAppEventsDelegates
{
    class Program
    {
        public delegate void VideoEncodeEventHandlerDelegate (object Source,EventArgs argss);    //delegate

        public event VideoEncodeEventHandlerDelegate videoEncoded;  //event of above delegate

        protected virtual void OnVideoEncoded()
        {
            if(videoEncoded!=null)
            {
                videoEncoded(this, EventArgs.Empty);
            }
        }
        public void Encode()
        {
            Console.WriteLine("Encoding vedio...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
