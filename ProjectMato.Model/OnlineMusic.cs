using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMato.Model
{
  class OnlineMusic
  {
  }
  public class MusicRadioList
  {
    public List<OnlineMusicItem> Hot { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Evening { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Love { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Theme { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Changjing { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Style { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Lauch { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> People { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> MusicTools { set; get; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Diqu { set; get; } = new List<OnlineMusicItem>();
  }

  public class MusicFLGDIndexItemsList
  {
    public List<OnlineMusicItem> Hot { get; set; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Lauch { get; set; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> LiuPai { get; set; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Theme { get; set; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Heart { get; set; } = new List<OnlineMusicItem>();
    public List<OnlineMusicItem> Changjing { get; set; } = new List<OnlineMusicItem>();
  }
  public class MusicPL
  {
    public string name { get; set; }
    public string img { get; set; }
    public string like { get; set; }
    public string text { get; set; }
  }
  public class OnlineMusicItem
  {
    public string Name { set; get; }
    public string Photo { set; get; }
    public string ID { set; get; }
  }

}
