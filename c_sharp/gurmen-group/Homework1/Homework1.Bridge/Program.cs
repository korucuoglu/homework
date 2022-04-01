using System;

namespace Homework1.Bridge
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Is-A

            Bad.Ali badAli = new();

            badAli.NefesAl();
            badAli.ArabaDurumu();
            badAli.EvDurumu();


            #endregion

            Console.WriteLine("****************");

            #region Has-A

            Good.Ali goodAli = new(new Good.EviYok(), new Good.ArabaVar());

            goodAli.NefesAl();
            goodAli.ArabaDurumu();
            goodAli.EvDurumu();

          


            #endregion
        }
    }
}
