using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Dojo_39;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_39.Tests
{
    [TestClass()]
    public class SongTests
    {
        string firstVerse = "There was an old lady who swallowed a fly." +
           "I don't know why she swallowed a fly - Perhaps she'll die!";
        string secondVerse = "There was an old lady who swallowed a spider." +
           "That wriggled and wiggled and tickled inside her." +
           "She swallowed the spider to catch the fly;" +
           "I don't know why she swallowed a fly - Perhaps she'll die!";

        [TestMethod()]
        public void SingTest()
        {
            var song = new Song();
            Assert.AreEqual( song.Sing("fly") , firstVerse );
        }

        [TestMethod()]
        public void TwoVerseTest()
        {
            var song = new Song();
            Assert.AreEqual(song.Sing("fly"), firstVerse);
            Assert.AreEqual(song.SingAgain("spider", "That wriggled and wiggled and tickled inside her."), firstVerse+secondVerse);
        }

    }
}