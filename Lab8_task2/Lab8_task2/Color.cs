using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_task2
{
    class ColorScreenPhone : BlackWhitePhone
    {
        public bool wifi = true;
        public override void Call()
        {
            Console.WriteLine("Call anyone you click on.");
        }
        public override void RingTone()
        {
            Console.WriteLine("*plays a song downloaded from the Internet*");
        }
        public virtual void SurfTheNet()
        {
            Console.WriteLine("KEKW");
        }

    }
}