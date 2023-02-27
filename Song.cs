using System;
using System.Data;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace HelloWorld
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; // Belongs ot the class and no the object

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration; 
            songCount++; 
        }

        public int getSongCount()
        {
            return songCount; 
        }
    }    
}