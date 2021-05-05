namespace VCS
{
    /// <summary>
    /// Entity to serizalize files to initial log and desirilize from it
    /// </summary>
    public class FileEntity
    {
        public string FilePath { get; init; }
        public string Content { get; init; }

        public FileEntity()
        {

        }
        public FileEntity(string path,string content)
        {
            FilePath = path;
            Content = content;
        }
    }
}