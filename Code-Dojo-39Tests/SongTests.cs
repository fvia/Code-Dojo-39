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
        [TestMethod()]
        public void SingTest()
        {
            var song = new Song("Hello [animal1]");
            Assert.AreEqual( song.Sing("Fox") , "Hello Fox" );
        }
    }
}