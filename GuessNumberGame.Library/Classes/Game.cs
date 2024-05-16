using GuessNumberGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Library.Classes
{
    public class Game : IGame
    {
        private readonly IRandomNumberGenerator randomNumberGenerator;
        private readonly IUI uI;

        public Game(IRandomNumberGenerator randomNumberGenerator, IUI uI)
        {
            this.randomNumberGenerator = randomNumberGenerator;
            this.uI = uI;
        }

        public void Play(int min, int max, int numberOfAttempts)
        {
            int targetNumber = randomNumberGenerator.GenerateNumber(min, max);
            uI.Output($"Я загадал число от {min} до {max}");

            Guess(targetNumber, numberOfAttempts);
        }

        private void Guess(int targetNumber, int numberOfAttempts)
        {

            while (true)
            {
                uI.Output($"Введите число ");
                string? input = uI.Input();
                int Number;

                bool isNumber = int.TryParse(input, out Number);

                if (!isNumber)
                {
                    uI.Output($"Это не число {Number}");
                    continue;
                }

                if (Number == targetNumber)
                {
                    uI.Output($"Вы угадали число! Это было {targetNumber}");
                    break;
                }

                if (Number > targetNumber)
                {
                    uI.Output($"Ваше число больше {Number}");
                }

                if (Number < targetNumber)
                {
                    uI.Output($"Ваше число меньше {Number}");
                }

                numberOfAttempts--;

                if (numberOfAttempts == 0)
                {
                    uI.Output($"У вас закончились попытки.");
                    break;
                }
                else
                {
                    uI.Output($"Осталось {numberOfAttempts}.");
                }
            }
        }
    }
}
