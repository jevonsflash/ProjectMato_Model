namespace ProjectMato.Model
{
    public class Result2
    {
        public int aid { get; set; }
        public string lrc { get; set; }
        public int sid { get; set; }
        public int artist_id { get; set; }
        public string song { get; set; }
    }


    public class GecimeSearchInfo 
    {
        public int count { get; set; }
        public int code { get; set; }

        public Result2[] Result { get; set; }
    }

    public class Result2ForShow : Result2
    {

        public string artist { get; set; }
    }

}
