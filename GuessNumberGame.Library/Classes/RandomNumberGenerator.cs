using GuessNumberGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Library.Classes
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int GenerateNumber(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }
    }
}
