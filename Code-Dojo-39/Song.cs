using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_39
{
    public class Song
    {
        string _song0;
        string _song1;
        string _previous;
        public Song()
        {
            _song0 = "There was an old lady who swallowed a [animal1].";
            _song1 =  "I don't know why she swallowed a [animal1] - Perhaps she'll die!";



        }
        public string Sing(string animal)
        {
            var r = _song0.Replace("[animal1]", animal);
            r+= _song1.Replace("[animal1]", animal);
            _previous = r;
            return r;
        }

        public string SingAgain(string animal, string line)
        {
            string r = "";
            return "";
        }
    }
}
