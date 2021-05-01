using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    class Free : State 
    {
        public Free(PianoLooper looper) : base(looper) { entry(); }
        public Free() : base() { }

        override
        public void RunThread()
        {

        }

        override
        protected void entry()
        {
            Console.WriteLine("This is free");
        }
    }
}
