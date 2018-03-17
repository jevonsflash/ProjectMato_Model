using SQLite;

namespace ProjectMato.Model
{

    [Table("QueueEntryTable")]
    public class QueueEntryTable : BaseTable
    {
        [PrimaryKey, AutoIncrement]
        public int QueueEntryId { get; set; }

        public static class Properties
        {
            public const string Rank = "Rank";
            public const string QueueEntryId = "QueueEntryId";
            public const string MusicTitle = "MusicTitle";
        }

        public QueueEntryTable()
        {
            Rank = 0;
            MusicTitle = string.Empty;
        }

        public QueueEntryTable(string musicTitle,int rank,int musicInfoId)
        {
            MusicTitle = musicTitle;
            Rank = rank;
            MusicInfoId = musicInfoId;
        }

        public int MusicInfoId { get; set; }

        public int Rank { get; set; }

        public string MusicTitle { get; set; }


    }
}
