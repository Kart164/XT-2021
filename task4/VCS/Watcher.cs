﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    /// <summary>
    /// A class that monitors the file system
    /// </summary>
    public class Watcher
    {
        private DateTime lastChange;
        private FileSystemWatcher watcher;

        public Action<string> ChangeHandler;
        public Commit Commit { get; private set; }
        
        public Watcher()
        {
            watcher = new FileSystemWatcher
            {
                Path = Storage.DirectoryToWatch,
                Filter = "*.txt",
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.FileName |
                NotifyFilters.LastWrite |
                NotifyFilters.CreationTime,
                EnableRaisingEvents = true,
            };
            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            Commit = new Commit(new List<Change>());
            lastChange = DateTime.MinValue;
        }

        #region EventHandlers
        private void OnChanged(object source,FileSystemEventArgs file)
        {
            var lastWriteTime = File.GetLastWriteTime(file.FullPath);
            if (lastWriteTime != lastChange)
            {
                ChangeHandler?.Invoke($"File: {file.FullPath} {file.ChangeType}");
                lastChange = lastWriteTime;
                Commit.Changes.Add(new Change(file.FullPath, file.ChangeType, lastWriteTime));
            }
        }
        private void OnRenamed(object source, RenamedEventArgs file)
        {
            ChangeHandler?.Invoke($"File: {file.OldFullPath} renamed to {file.FullPath}");
            Commit.Changes.Add(new Change(file.FullPath, file.OldFullPath, file.ChangeType, DateTime.Now));
        }
        private void OnDeleted(object source, FileSystemEventArgs file)
        {
            if (Commit.Changes.Count > 0)
            {
                if ((Commit.Changes[^1].ChangeType == WatcherChangeTypes.Deleted ||
                    Commit.Changes[^1].ChangeType == WatcherChangeTypes.Created)
                     && Commit.Changes[^1].FilePath == file.FullPath) { }
                else
                {
                    ChangeHandler?.Invoke($"File: {file.FullPath} {file.ChangeType}");
                    Commit.Changes.Add(new Change(file.FullPath, file.ChangeType, DateTime.Now));
                }
            }
            else
            {
                ChangeHandler?.Invoke($"File: {file.FullPath} {file.ChangeType}");
                Commit.Changes.Add(new Change(file.FullPath, file.ChangeType, DateTime.Now));
            }
        }
        private void OnCreated(object source, FileSystemEventArgs file)
        {
            if (Commit.Changes.Count>0)
            {
                if ((Commit.Changes[^1].ChangeType == WatcherChangeTypes.Deleted ||
                    Commit.Changes[^1].ChangeType == WatcherChangeTypes.Created)
                     && Commit.Changes[^1].FilePath == file.FullPath) { }
                else
                {
                    ChangeHandler?.Invoke($"File: {file.FullPath} {file.ChangeType}");
                    Commit.Changes.Add(new Change(file.FullPath, file.ChangeType, DateTime.Now));
                }
                
            }
            else
            {
                ChangeHandler?.Invoke($"File: {file.FullPath} {file.ChangeType}");
                Commit.Changes.Add(new Change(file.FullPath, file.ChangeType, DateTime.Now));
            }
        }
        #endregion

        public void SaveCommit(Logger logger)
        {
            Commit.DateTimeOfCommit = new DateTime(DateTime.Now.Ticks);
            logger.AddCommit(Commit);
            Commit=new Commit(new List<Change>());
        }

        public void EndMonitoring(Logger logger, bool saveLastChanges)
        {
            if(saveLastChanges)
                SaveCommit(logger);
            logger.SaveCommits();
            watcher.Dispose();
        }
    }
}
