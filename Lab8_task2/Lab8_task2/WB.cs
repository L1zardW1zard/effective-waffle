using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_task2
{
    class WBPhone : ButtonPhone
    {
        public bool display = true;
        public override void Call()
        {
            Console.WriteLine("Hi-hi! Personally I can call to someone using display!");
        }

        public override void RingTone()
        {
            Console.WriteLine("*plays Nokia 3310 ringtone*");
        }
    }
}