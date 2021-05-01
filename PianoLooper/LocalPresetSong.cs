using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    abstract class LocalPresetSong : AbsPresetSong
    {
        public LocalPresetSong(PianoLooper e) : base(e) { }
    }
}
