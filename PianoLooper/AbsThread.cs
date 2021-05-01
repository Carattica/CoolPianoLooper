using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PianoLooper
{
    /**
     *  We discovered that you can't just inherit from "Thread" like Java, 
     *  so we used this source:
     *  https://stackoverflow.com/questions/8123461/unable-to-inherit-from-a-thread-class-in-c-sharp
     *  to accomplish this task
     */
    abstract class AbsThread
    {
        private Thread thr;

        protected AbsThread()
        {
            thr = new Thread(new ThreadStart(this.RunThread));
        }

        public void Start() => thr.Start();
        public void Join() => thr.Join();
        public bool IsAlive() => thr.IsAlive;

        public abstract void RunThread();
    }
}
