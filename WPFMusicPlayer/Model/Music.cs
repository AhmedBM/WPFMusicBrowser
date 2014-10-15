using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMusicPlayer.Model
{
    class Artist
    {
        #region Members
        public string _name;
        #endregion
    }

    class Album
    {
        //"title": "The King of Limbs",
        //  "image": "http://upload.wikimedia.org/wikipedia/en/2/24/The_king_of_limbs.jpg",
        //  "description": "The King of Limbs is the eighth studio album by English rock band Radiohead, produced by Nigel Godrich. It was self-released on 18 February 2011 as a download in MP3 and WAV formats, followed by physical CD and 12' vinyl releases on 28 March, a wider digital release via AWAL, and a special 'newspaper' edition on 9 May 2011. The physical editions were released through the band's Ticker Tape imprint on XL in the United Kingdom, TBD in the United States, and Hostess Entertainment in Japan.",
        //  "date": "2012-04-23T18:25:43.511Z",
        #region Members
        public string _title;
        public string _description;
        public string _imageUri;
        public DateTime _date;
        #endregion
    }

    class Song
    {
        #region Members
        public string _title;
        public TimeSpan _length;
        #endregion
    }
}
