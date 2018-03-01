using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMato.Model;

namespace ProjectMato.Interface
{
    public interface IMusicInfoManager
    {
        IDatabaseManager DatabaseManager { get; }

        /// <summary>
        /// 获取分组包装好的MusicInfo集合
        /// </summary>
        /// <returns></returns>
        Task<AlphaGroupedObservableCollection<MusicInfo>> GetAlphaGroupedMusicInfo();

        /// <summary>
        /// 获取分组包装好的ArtistInfo集合
        /// </summary>
        /// <returns></returns>
        Task<AlphaGroupedObservableCollection<ArtistInfo>> GetAlphaGroupedArtistInfo();

        /// <summary>
        /// 获取分组包装好的AlbumInfo集合
        /// </summary>
        /// <returns></returns>
        Task<AlphaGroupedObservableCollection<AlbumInfo>> GetAlphaGroupedAlbumInfo();

        /// <summary>
        /// 获取MusicInfo集合
        /// </summary>
        /// <returns></returns>
        Task<InfoResult<List<MusicInfo>>> GetMusicInfos();

        /// <summary>
        /// 获取AlbumInfo集合
        /// </summary>
        /// <returns></returns>
        Task<InfoResult<List<AlbumInfo>>> GetAlbumInfos();

        /// <summary>
        /// 获取ArtistInfo集合
        /// </summary>
        /// <returns></returns>
        Task<InfoResult<List<ArtistInfo>>> GetArtistInfos();

        /// <summary>
        /// 将MusicInfo插入到队列
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool CreateQueueEntry(MusicInfo musicInfo);

        /// <summary>
        /// 将MusicInfo集合插入到队列中的末尾
        /// </summary>
        /// <param name="musicInfos"></param>
        /// <returns></returns>
        Task<bool> InsertToEndQueueEntrys(List<MusicInfo> musicInfos);

        /// <summary>
        /// 将MusicInfo集合插入到队列
        /// </summary>
        /// <param name="musicInfos">需要进行操作的MusicInfo集合</param>
        /// <returns></returns>
        bool CreateQueueEntrys(List<MusicInfo> musicInfos);

        /// <summary>
        /// 将MusicInfo集合插入到队列
        /// </summary>
        /// <param name="musics">需要进行操作的MusicInfo集合</param>
        /// <returns></returns>
        bool CreateQueueEntrys(MusicCollectionInfo musics);


        /// <summary>
        /// 从队列中读取MusicInfo
        /// </summary>
        /// <returns></returns>
        Task<List<MusicInfo>> GetQueueEntry();

        /// <summary>
        /// 将MusicInfo插入到队列中的下一曲
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool InsertToNextQueueEntry(MusicInfo musicInfo);

        /// <summary>
        /// 将MusicInfo插入到队列中的末尾
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool InsertToEndQueueEntry(MusicInfo musicInfo);

        /// <summary>
        /// 返回一个值表明一个Title是否包含在队列中
        /// </summary>
        /// <param name="musicTitle">music标题</param>
        /// <returns></returns>
        bool GetIsQueueContains(string musicTitle);

        /// <summary>
        /// 从队列中删除指定MusicInfo
        /// </summary>
        /// <param name="musicTitle"></param>
        /// <returns></returns>
        bool DeleteMusicInfoFormQueueEntry(string musicTitle);

        /// <summary>
        /// 从队列中删除指定MusicInfo
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool DeleteMusicInfoFormQueueEntry(MusicInfo musicInfo);

        /// <summary>
        /// 交换队列中两个MusicInfo的位置
        /// </summary>
        /// <param name="oldMusicInfo"></param>
        /// <param name="newMusicInfo"></param>
        void ReorderQueue(MusicInfo oldMusicInfo, MusicInfo newMusicInfo);

        /// <summary>
        /// 从队列中清除所有MusicInfo
        /// </summary>
        void ClearQueue();

        /// <summary>
        /// 将MusicInfo插入到歌单
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool CreatePlaylistEntry(MusicInfo musicInfo, int playlistId);

        /// <summary>
        /// 将MusicInfo集合插入到歌单
        /// </summary>
        /// <param name="musicCollectionInfo"></param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool CreatePlaylistEntrys(MusicCollectionInfo musicCollectionInfo, int playlistId);

        /// <summary>
        /// 从歌单中删除MusicInfo根据指定的Title
        /// </summary>
        /// <param name="musicTitle"></param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool DeletePlaylistEntry(string musicTitle, int playlistId);

        /// <summary>
        /// 从歌单中删除MusicInfo
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool DeletePlaylistEntry(MusicInfo musicInfo, int playlistId);

        /// <summary>
        /// 将MusicInfo插入到“我最喜爱”歌单
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool CreatePlaylistEntryToMyFavourite(MusicInfo musicInfo);

        /// <summary>
        /// 将MusicInfo集合插入到“我最喜爱”
        /// </summary>
        /// <param name="musicCollectionInfo"></param>
        /// <returns></returns>
        bool CreatePlaylistEntrysToMyFavourite(MusicCollectionInfo musicCollectionInfo);

        /// <summary>
        /// 从“我最喜爱”中删除MusicInfo
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool DeletePlaylistEntryFromMyFavourite(MusicInfo musicInfo);

        /// <summary>
        /// 从歌单中读取MusicInfo
        /// </summary>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        Task<List<MusicInfo>> GetPlaylistEntry(int playlistId);

        /// <summary>
        /// 从“我最喜爱”中读取MusicInfo
        /// </summary>
        /// <returns></returns>
        Task<List<MusicInfo>> GetPlaylistEntryFormMyFavourite();

        /// <summary>
        /// 返回一个值表明一个Title是否包含在某个歌单中
        /// </summary>
        /// <param name="musicTitle">music标题</param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool GetIsPlaylistContains(string musicTitle, int playlistId);

        /// <summary>
        ///  返回一个值表明一个MusicInfo是否包含在某个歌单中
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool GetIsPlaylistContains(MusicInfo musicInfo, int playlistId);

        /// <summary>
        /// 返回一个值表明一个Title是否包含在"我最喜爱"中
        /// </summary>
        /// <param name="musicTitle">music标题</param>
        /// <returns></returns>
        bool GetIsMyFavouriteContains(string musicTitle);

        /// <summary>
        ///  返回一个值表明一个MusicInfo是否包含在"我最喜爱"中
        /// </summary>
        /// <param name="musicInfo">musicInfo对象</param>
        /// <returns></returns>
        bool GetIsMyFavouriteContains(MusicInfo musicInfo);

        /// <summary>
        /// 交换某歌单中两个MusicInfo的位置
        /// </summary>
        /// <param name="oldMusicInfo"></param>
        /// <param name="newMusicInfo"></param>
        /// <param name="playlistId"></param>
        void ReorderPlaylist(MusicInfo oldMusicInfo, MusicInfo newMusicInfo, int playlistId);

        /// <summary>
        /// 交换"我最喜爱"中两个MusicInfo的位置
        /// </summary>
        /// <param name="oldMusicInfo"></param>
        /// <param name="newMusicInfo"></param>
        void ReorderMyFavourite(MusicInfo oldMusicInfo, MusicInfo newMusicInfo);

        /// <summary>
        /// 获取Playlist
        /// </summary>
        /// <returns></returns>
        List<PlaylistTable> GetPlaylist();

        /// <summary>
        /// 获取PlaylistInfo
        /// </summary>
        /// <returns></returns>
        Task<List<PlaylistInfo>> GetPlaylistInfo();

        /// <summary>
        /// 创建Playlist
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns></returns>
        bool CreatePlaylist(PlaylistInfo playlist);

        /// <summary>
        /// 更新Playlist
        /// </summary>
        /// <param name="playlistInfo"></param>
        /// <returns></returns>
        bool UpdatePlaylist(PlaylistInfo playlistInfo);

        /// <summary>
        /// 根据Id删除Playlist
        /// </summary>
        /// <param name="playlistId"></param>
        /// <returns></returns>
        bool DeletePlaylist(int playlistId);

        /// <summary>
        /// 根据PlaylistInfo删除Playlist
        /// </summary>
        /// <param name="playlistInfo"></param>
        /// <returns></returns>
        bool DeletePlaylist(PlaylistInfo playlistInfo);
    }
}
