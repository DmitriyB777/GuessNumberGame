using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Library.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int GenerateNumber(int min, int max);
    }
}
