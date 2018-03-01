using System;
using System.Collections.ObjectModel;

namespace ProjectMato.Model
{
	public class LrcInfo : ObservableObject
    {
        public int Id { get; set; }
        /// <summary>
        /// 歌曲
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 艺术家
        /// </summary>
        public string Artist { get; set; }
        /// <summary>
        /// 专辑
        /// </summary>
        public string Album { get; set; }
        /// <summary>
        /// 歌词作者
        /// </summary>
        public string LrcBy { get; set; }
        /// <summary>
        /// 偏移量
        /// </summary>
        public string Offset { get; set; }

        /// <summary>
        /// 歌词
        /// </summary>


        private ObservableCollection<LrcWord> _lrcWords;

        public ObservableCollection<LrcWord> LrcWords
        {
            get
            {
                if (_lrcWords == null)
                {
                    _lrcWords = new ObservableCollection<LrcWord>();
                }
                return _lrcWords;

            }
            set
            {
                _lrcWords = value;
                RaisePropertyChanged();
            }
        }



        public void Clear()
        {
            this.Id = -1;
            this.Title = string.Empty;
            this.Artist = string.Empty;
            this.Album = string.Empty;
            this.LrcBy = string.Empty;
            this.Offset = string.Empty;
            this.LrcWords.Clear();
        }

    }


}
