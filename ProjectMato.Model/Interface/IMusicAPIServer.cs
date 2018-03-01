using ProjectMato.Model;

namespace ProjectMato.Interface
{
    public interface IMusicAPIServer
    {
        /// <summary>
        /// 搜索API
        /// </summary>
        /// <param name="s">要搜索的内容</param>
        /// <param name="limit">要返回的条数</param>
        /// <param name="offset">设置偏移量 用于分页</param>
        /// <param name="type">类型 [1 单曲] [10 专辑] [100 歌手] [1000 歌单] [1002 用户]</param>
        /// <returns>JSON</returns>
        string Search(string s = null, int limit = 30, int offset = 0, int type = 1);

        /// <summary>
        /// 获取歌曲详情API(包含mp3地址)
        /// </summary>
        /// <param name="ids">要获取的歌曲id列表</param>
        /// <returns>JSON</returns>
        string Detail(params string[] ids);

        /// <summary>
        /// 获取歌曲歌词API
        /// 根据JSON判断是否有歌词，nolyric表示无歌词，uncollected表示暂时无人提交歌词
        /// </summary>
        /// <param name="id">要获取的歌曲id</param>
        /// <returns>JSON</returns>
        string Lyric(string id);

        /// <summary>
        /// 获取用户歌单信息
        /// 排行榜也归类为歌单
        /// </summary>
        /// <param name="id">要获取的歌单id</param>
        /// <returns>JSON</returns>
        string PlayList(string id);

        /// <summary>
        /// 歌曲MV API
        /// </summary>
        /// <param name="id">要获取的mvid</param>
        /// <returns>JSON</returns>
        string MV(string id);

        /// <summary>
        /// 请求网易云音乐接口
        /// </summary>
        /// <typeparam name="T">要请求的接口类型</typeparam>
        /// <param name="config">要请求的接口类型的对象</param>
        /// <returns>请求结果(JSON)</returns>
        string Request<T>(T config) where T : RequestData, new();

    }
}