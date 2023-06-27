namespace ElectronixWebAPI.Model
{
    public class AppResponse
    {
        public string Code { get; internal set; }
        public string Text { get; internal set; }
        public object? Response { get; internal set; }
    }
}