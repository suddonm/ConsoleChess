using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class Program
    {
        // https://www.chessclub.com/help/PGN-spec
        static void Main(string[] args)
        {
            WebController web = new WebController("<URI>"); //https://172.24.166.45
            web.RetrieveGames().Wait();
            Console.ReadLine();
        }
    }
}
