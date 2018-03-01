using System.Collections.Generic;
using ProjectMato.Model;

namespace ProjectMato.Interface
{
    public interface IDatabaseManager
    {
        void Connect();
        void Disconnect();
        List<PlaylistTable> FetchPlaylists();
        List<PlaylistEntryTable> FetchPlaylistEntriesForPlaylist(int playlistId);
        List<PlaylistEntryTable> FetchPlaylistEntriesForPlaylistAndSongId(int playlistId, int songId);
        List<PlaylistEntryTable> FetchPlaylistEntriesForPlaylistAndSongTitle(int playlistId, string songTitle);
        List<BackgroundTable> FetchBackgroundItems();
        List<QueueEntryTable> FetchQueueEntryTables();
        List<SettingTable> FetchSettingTables();
        int AddQueueEntryTable(QueueEntryTable queueEntry);
        int AddQueueEntryTables(IEnumerable<QueueEntryTable> queueEntrys);
        int AddPlaylistEntry(PlaylistEntryTable newPlaylistEntry);
        int AddPlaylistEntryTables(IEnumerable<PlaylistEntryTable> newPlaylistEntrys);
        int AddPlaylist(PlaylistTable newPlaylist);
        int AddBackgroundEntry(BackgroundTable entry);
        int AddSettingTable(SettingTable setting);
        BackgroundTable QuerySelectedBackground();
        QueueEntryTable QueryQueueEntryByMusicTitle(string musicTitle);
        int DeletePlaylistEntry(int rowId);
        int DeletePlaylist(int playlistId);
        int DeleteQueueItem(int rowId);
        void ClearBackground();
        void ClearSetting();
        void ClearQueue();
        int Update(BaseTable entry);
        void InterchangeQueueEntry(string firstMusicTitle, string secondMusicTitle);
        void InterchangePlaylistEntry(string firstMusicTitle, string secondMusicTitle, int playlistId);
    }
}