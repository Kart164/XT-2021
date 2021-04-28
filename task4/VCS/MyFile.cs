namespace VCS
{
    public class MyFile
    {
        public string FilePath { get; set; }
        public string Content { get; set; }
        public MyFile()
        {

        }
        public MyFile(string path,string content)
        {
            FilePath = path;
            Content = content;
        }
    }
}