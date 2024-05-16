using GuessNumberGame.Library.Classes;
using GuessNumberGame.Library.Interfaces;
using System;

namespace GuessNumberGame.ConsoleApp
{
    internal class Program
    {
        private IGame game;

        public Program(IGame game)
        {
            this.game = game;
        }
        static void Main(string[] args)
        {
            IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            IUI uI = new ConsoleUI();
            IGame game = new Game(randomNumberGenerator, uI);
            Program program = new Program(game);
            program.game.Play(1, 100, 8);

            Console.ReadKey();
        }
    }
}
