using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace ProjectMato.Model
{
    public abstract class MusicCollectionInfo : ObservableObject, IBasicInfo
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string GroupHeader { get; set; }


        private IList<MusicInfo> _musics;

        public IList<MusicInfo> Musics
        {
            get
            {
                if (_musics == null)
                {
                    _musics = new ObservableCollection<MusicInfo>();
                }
                return _musics;

            }
            set
            {
                _musics = value;
                RaisePropertyChanged();
            }
        }
        public string Artist
        {
            get;
            set;
        }
        public ImageSource AlbumArt { get; set; }
        public string AlbumArtPath { get; set; }

        public int Count => Musics.Count();

        public string Time
        {
            get
            {
                var totalSec = Math.Truncate((double)Musics.Sum(c => (long)c.Duration));
                var totalTime = TimeSpan.FromSeconds(totalSec);
                var time = totalTime.ToString("g");
                return time;
            }
        }

    }
}