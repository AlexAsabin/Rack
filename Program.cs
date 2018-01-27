using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rack
{
    class Program
    {
        delegate void MessageHandler(string message);
        static void Main(string[] args)
        {
            ShowMessage("Hello World!", delegate(string message) {
                Console.WriteLine(message);
            });
            
            Console.ReadLine();
        }

        static void ShowMessage(string mes, MessageHandler handler) {
            handler(mes);
        }
    }
}
