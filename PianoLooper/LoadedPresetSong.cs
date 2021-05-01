using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    abstract class LoadedPresetSong : AbsPresetSong
    {
        public LoadedPresetSong(PianoLooper e) : base(e) { }
    }
}
