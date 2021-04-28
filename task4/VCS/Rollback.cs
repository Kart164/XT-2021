using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    public static class Rollback
    {
        /// <summary>
        /// this method makes a rollback of changes by rolling back the directory to the initial state
        /// and alternately performs them from the very beginning of the list of commits to the specified index
        /// </summary>
        /// <param name="index">index of commit</param>
        public static void MakeRollBack(int index,Logger logger)
        {
            RollBackToInitialState(logger);
            for (int i = 0; i <= index; i++)
            {
                foreach (var change in logger.Commits[i].Changes)
                {
                    switch (change.ChangeType)
                    {
                        case WatcherChangeTypes.Created:
                            File.Create(change.FilePath);
                            break;
                        case WatcherChangeTypes.Changed:
                            File.Delete(change.FilePath);
                            File.WriteAllText(change.FilePath, change.FileContent);
                            break;
                        case WatcherChangeTypes.Deleted:
                            File.Delete(change.FilePath);
                            break;
                        case WatcherChangeTypes.Renamed:
                            File.Copy(change.OldFullPath, change.FilePath);
                            File.Delete(change.OldFullPath);
                            break;
                    }
                }
            }
        }
        public static void RollBackToInitialState(Logger logger)
        {
            var files = Directory.GetFiles(Storage.DirectoryToWatch);
            foreach (var file in files)
            {
                File.Delete(file);
            }
            Directory.Delete(Storage.DirectoryToWatch, true);
            Directory.CreateDirectory(Storage.DirectoryToWatch);
            foreach (var file in logger.InitialFileList)
            {
                if (!Directory.Exists(Path.GetDirectoryName(file.FilePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(file.FilePath));
                File.WriteAllText(file.FilePath, file.Content);
            }
        }
        
    }
}
