using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    abstract class State : AbsThread
    {
        private PianoLooper looper;
        public State(PianoLooper looper)
        {
            this.looper = looper;
        }

        public State()
        {
            entry();
        }

        abstract protected void entry();

        public PianoLooper Looper
        {
            get { return this.looper; }
            set { this.looper = value; }
        }

    }
}
