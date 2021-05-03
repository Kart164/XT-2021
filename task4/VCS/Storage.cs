using System.IO;

namespace VCS
{
    /// <summary>
    /// Static class to save Roots to all important directories
    /// </summary>
    public static class Storage
    {
        public static string DirectoryToWatch { get; private set; }
        public static string InitialLog { get; private set; }
        public static string Log { get; private set; }

        /// <summary>
        /// Method to set Directory to watch, and automatic set for Log and initial log
        /// </summary>
        /// <param name="path">Directory to watch</param>
        public static void SetDirectory(string path)
        {
            DirectoryToWatch = path;
            Log = Directory.GetParent(path) + @"\Log.json";
            InitialLog = Directory.GetParent(path) + @"\InitialLog.json";
        }
    }
}
