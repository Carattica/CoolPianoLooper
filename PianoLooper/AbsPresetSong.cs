using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    abstract class AbsPresetSong : AbsSong
    {
        protected PianoLooper env;
        protected string name;

        public AbsPresetSong(PianoLooper e)
        {
            this.env = e;
        }

        public abstract void play();
    }
}
