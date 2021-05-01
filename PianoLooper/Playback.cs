using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    class Playback : State
    {
        public Playback() : base() { }

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
