using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    /// <summary>
    /// Class to save changes to build all of them to one commit and for serializing into json
    /// </summary>
    public class Change
    {
        public string FilePath { get; init; }
        public string OldFullPath { get; init; }
        public WatcherChangeTypes ChangeType {get; init; }
        public DateTime DateTimeOfChange { get; init; }
        public string FileContent { get;init; }

        public Change()
        {

        }
        public Change(string filePath,WatcherChangeTypes typeOfChange, DateTime dateTime)
        {
            FilePath = filePath;
            ChangeType = typeOfChange;
            DateTimeOfChange = dateTime;
            if (typeOfChange == WatcherChangeTypes.Changed || typeOfChange == WatcherChangeTypes.Created)
                FileContent = File.ReadAllText(filePath);
            else FileContent=null;
        }
        public Change(string filePath,string oldPath, WatcherChangeTypes typeOfChange, DateTime dateTime)
        {
            FilePath = filePath;
            ChangeType = typeOfChange;
            DateTimeOfChange = dateTime;
            OldFullPath = oldPath;
            FileContent = File.ReadAllText(filePath);
        }
    }
}
