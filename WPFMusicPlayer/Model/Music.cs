using System;

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
        #region Members
        public string _title;
        public string _description;
        public string _image;
        public DateTime _date;
        #endregion
    }

    class Song
    {
        #region Members
        public string _title;
        public TimeSpan _length;
        public bool _favorite;
        #endregion
    }
}
