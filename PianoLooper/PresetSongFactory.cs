using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLooper
{
    class PresetSongFactory
    {
        public AbsPresetSong createSong(string discriminator)
        {
            Type t = Type.GetType(discriminator);
            Object o = Activator.CreateInstance(t);
            return (AbsPresetSong)o;
        }
    }
}
