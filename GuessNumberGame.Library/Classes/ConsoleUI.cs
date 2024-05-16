using GuessNumberGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Library.Classes
{
    public class ConsoleUI : IUI
    {
        public string? Input()
        {
            return Console.ReadLine();
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
