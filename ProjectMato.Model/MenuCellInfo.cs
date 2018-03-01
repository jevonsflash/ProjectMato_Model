namespace ProjectMato.Model
{
    public class MenuCellInfo
    {
        public MenuCellInfo()
        {
            Enable = true;
        }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Icon { get; set; }
        public bool Enable { get; set; }
    }
}