using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventsDelegates
{
    class MailService
    {
        public static void onVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail service");
        }
    }
}
