﻿using Xamarin.Forms;

namespace ProjectMato.Model
{
    public class PlaylistInfo : MusicCollectionInfo
    {
        public bool IsHidden { get; set; }

        public bool IsRemovable { get; set; }

        public ImageSource PlaylistArt { get; set; }

    }
}