using System.Collections.Generic;

namespace ProjectMato.Model
{
	public class MusicMassiveInfo : ObservableObject
	{
		public MusicMassiveInfo()
		{
			this.AlbumInfos=new List<AlbumInfo>();
			this.Title = "...";
		}
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
		public IList<AlbumInfo> AlbumInfos { get; set; }

		public IList<MusicInfo> GetOrigin()
		{

			var result = new List<MusicInfo>();
			if (AlbumInfos == null)
			{
				return result;

			}
			foreach (var item in AlbumInfos)
			{
				if (item.Musics == null)
				{
					continue;
				}
				result.AddRange(item.Musics);

			}
			return result;
		}

		private AlbumInfo _currentAlbum;

		public AlbumInfo CurrentAlbum
		{
			get { return _currentAlbum; }
			set
			{
				_currentAlbum = value;
				RaisePropertyChanged();
			}
		}

	}
}
