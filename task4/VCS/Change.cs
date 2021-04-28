using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    public class Change
    {
        public string FilePath { get; set; }
        public string OldFullPath { get; set; }
        public WatcherChangeTypes ChangeType {get; set; }
        public DateTime DateTimeOfChange { get; set; }
        public string FileContent { get; set; }

        public Change()
        {

        }
        public Change(string filePath,WatcherChangeTypes typeOfChange, DateTime dateTime)
        {
            FilePath = filePath;
            ChangeType = typeOfChange;
            DateTimeOfChange = dateTime;
            if(typeOfChange==WatcherChangeTypes.Changed)
                FileContent = File.ReadAllText(filePath);
        }
        public Change(string filePath,string oldPath, WatcherChangeTypes typeOfChange, DateTime dateTime)
        {
            FilePath = filePath;
            ChangeType = typeOfChange;
            DateTimeOfChange = dateTime;
            OldFullPath = oldPath;
            FileContent = string.Empty;
        }
    }
}
