using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    class CoolLocalPresetSong : AbsPresetSong
    {
        public CoolLocalPresetSong(PianoLooper e) : base(e)
        {
            this.name = "Cool Song!";
        }

        override
        public void play()
        {
            env.keyC4.PerformClick();
        }
    }
}
