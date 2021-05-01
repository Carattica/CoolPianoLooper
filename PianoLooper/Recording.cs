using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    class Recording : State
    {
        public Recording() : base() { }

        override
        public void RunThread()
        {

        }

        override
        protected void entry()
        {
            Console.WriteLine("This is playback");
        }
    }
}
