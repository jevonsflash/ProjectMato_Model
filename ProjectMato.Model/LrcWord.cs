using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMato.Model
{
	public class LrcWord : ObservableObject
	{
		public LrcWord()
		{
			Time = default(TimeSpan);
			Content = string.Empty;
			IsCurrent = false;
		}

		public int LrcWordId { get; set; }
		public TimeSpan Time { get; set; }
		public string Content { get; set; }
		private bool _isCurrent;

		public bool IsCurrent
		{
			get { return _isCurrent; }
			set
			{
				_isCurrent = value;
				base.RaisePropertyChanged();
			}
		}

	}
}
