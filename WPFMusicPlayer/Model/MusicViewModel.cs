using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMusicPlayer.Model
{
    class ArtistViewModel : BaseViewModel
    {
        #region Members
        private Artist _artist;
        private ObservableCollection<AlbumViewModel> _albums; 
        #endregion

        #region Constructor
        public ArtistViewModel()
        {
            _artist = new Artist();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _artist._name; }
            set
            {
                _artist._name = value;
                RaisePropertyChangedEvent("Name");
            }
        }
        #endregion
    }

    class AlbumViewModel : BaseViewModel
    {
        #region Members
        private Album _album;
        private ObservableCollection<SongtViewModel> _songs;
        #endregion

        #region Constructor
        public AlbumViewModel()
        {
            _album = new Album();
        }
        #endregion

        #region Properties
        public string Title
        {
            get { return _album._title; }
            set
            {
                _album._title = value;
                RaisePropertyChangedEvent("Title");
            }
        }
        public string Description
        {
            get { return _album._description; }
            set
            {
                _album._description = value;
                RaisePropertyChangedEvent("Description");
            }
        }
        public DateTime Date
        {
            get { return _album._date; }
            set
            {
                _album._date = value;
                RaisePropertyChangedEvent("Date");
            }
        }
        public string ImageUri
        {
            get { return _album._imageUri; }
            set
            {
                _album._imageUri = value;
                RaisePropertyChangedEvent("ImageUri");
            }
        }
        #endregion
    }

    class SongtViewModel : BaseViewModel
    {
        #region Members
        private Song _song;
        #endregion

        #region Constructor
        public SongtViewModel()
        {
            _song = new Song();
        }
        #endregion

        #region Properties
        public string Title
        {
            get { return _song._title; }
            set
            {
                _song._title = value;
                RaisePropertyChangedEvent("Title");
            }
        }
        public TimeSpan Length
        {
            get { return _song._length; }
            set
            {
                _song._length = value;
                RaisePropertyChangedEvent("Length");
            }
        }
        #endregion
    }
}
