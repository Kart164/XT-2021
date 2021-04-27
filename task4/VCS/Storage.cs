using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    /// <summary>
    /// Static class to save Roots to all important directories
    /// </summary>
    public static class Storage
    {

        public static string DirectoryToWatch { get; private set; }
        /// <summary>
        /// Root to the Directory with all backups
        /// </summary>
        public static string BackupDirectory { get; private set; }
        public static string Log { get; private set;  }

        public static void SetDirectory(string path)
        {
            DirectoryToWatch = path;
            BackupDirectory = Directory.GetParent(path) + @"\Backup";
            Log = BackupDirectory + @"\Log.json";
        }
    }
}
