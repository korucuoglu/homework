using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Bridge.Bad
{
    public abstract class Canlı
    {
        public void NefesAl()
        {
            Console.WriteLine("nefes alındı");
        }
    }

    public abstract class İnsan : Canlı
    {
        public abstract void ArabaDurumu();
        public abstract void EvDurumu();
    }

    public class Ali : İnsan
    {
        public override void ArabaDurumu()
        {
            Console.WriteLine("Arabası var.");
        }

        public override void EvDurumu()
        {
            Console.WriteLine("Evi yok");
        }
    }

    public class Hasan : İnsan
    {
        public override void ArabaDurumu()
        {
            Console.WriteLine("Arabası yok.");
        }

        public override void EvDurumu()
        {
            Console.WriteLine("Evi var");
        }
    }


}
