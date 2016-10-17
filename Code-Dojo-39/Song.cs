using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_39
{
    public class Song
    {
        string _song;
        public Song(string Song) {
            _song = Song;
        }
        public string Sing( string animal) { return _song.Replace("[animal1]", animal); }
    }
}
