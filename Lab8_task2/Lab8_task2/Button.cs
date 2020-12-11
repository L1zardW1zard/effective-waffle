using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_task2
{
    class ButtonPhone : DiskPhone
    {

        public bool Buttons = true;

        public override void Call()
        {
            Console.WriteLine("Call someone using buttons");
        }

    }
}