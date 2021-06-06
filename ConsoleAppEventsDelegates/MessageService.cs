using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventsDelegates
{
    class MessageService
    {
        public static void onVideoEncoded(object source,VideoEventArgs vargs)
        {
            Console.WriteLine("Message service " + vargs.video.Tittle);
        }
    }
}
