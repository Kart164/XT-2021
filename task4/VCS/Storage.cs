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
        public static string InitialLog { get; private set; }       
        public static string Log { get; private set;  }

        public static void SetDirectory(string path)
        {
            DirectoryToWatch = path;
            Log = Directory.GetParent(path) + @"\Log.json";
            InitialLog = Directory.GetParent(path) + @"\InitialLog.json";
        }
    }
}
