using System;

namespace Homework1.Bridge.Good
{
    public interface IEvDurumu
    {
        public void EvDurumu();
    }
    public interface IArabaDurumu
    {
        public void ArabaDurumu();
    }

    public class EviYok : IEvDurumu
    {
        public void EvDurumu()
        {
            Console.WriteLine("Evi yok");
        }
    }

    public class EviVar : IEvDurumu
    {
        public void EvDurumu()
        {
            Console.WriteLine("Evi var");
        }
    }

    public class ArabaVar : IArabaDurumu
    {
        public void ArabaDurumu()
        {
            Console.WriteLine("Arabası var.");
        }
    }

    public class ArabaYok : IArabaDurumu
    {
        public void ArabaDurumu()
        {
            Console.WriteLine("Arabası yok.");
        }
    }


    public abstract class İnsan
    {
        public void NefesAl()
        {
            Console.WriteLine("nefes alındı");
        }

        protected readonly IEvDurumu _evDurumu;
        protected readonly IArabaDurumu _arabaDurumu;

        protected İnsan(IEvDurumu evDurumu, IArabaDurumu arabaDurumu)
        {
            _evDurumu = evDurumu;
            _arabaDurumu = arabaDurumu;
        }

        public void ArabaDurumu()
        {
            _arabaDurumu.ArabaDurumu();
        }
        public void EvDurumu()
        {
            _evDurumu.EvDurumu();
        }
    }

    public class Ali : İnsan
    {
        public Ali(IEvDurumu evDurumu, IArabaDurumu arabaDurumu) : base(evDurumu, arabaDurumu)
        {
        }
    }

    public class Hasan : İnsan
    {
        public Hasan(IEvDurumu evDurumu, IArabaDurumu arabaDurumu) : base(evDurumu, arabaDurumu)
        {
        }
    }
}
