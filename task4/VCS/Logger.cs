using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace VCS
{
    /// <summary>
    /// This class helps to save to the json file and get from it all commits and changes
    /// </summary>
    public class Logger
    {
        public List<Commit> Commits { get; private set; }
        public List<FileEntity> InitialFileList { get; private set; }

        public Logger()
        {
            Commits = new List<Commit>();
            InitialFileList = new List<FileEntity>();
        }

        #region Save Origin Structure of directory to watch 
        public void SaveStartStateToJson()
        {
            if (!File.Exists(Storage.InitialLog))
            {
                var files = Directory.GetFiles(Storage.DirectoryToWatch, "*.txt", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    InitialFileList.Add(new FileEntity(file, File.ReadAllText(file)));
                }
                var json = JsonSerializer.Serialize(InitialFileList, new JsonSerializerOptions { WriteIndented = true });
                if (string.IsNullOrWhiteSpace(json))
                {
                    File.WriteAllText(Storage.InitialLog, "{}");
                }
                File.WriteAllText(Storage.InitialLog, json);
            }
            else
            {
                GetStartStateFromJson();
            }
        }
        public void GetStartStateFromJson()
        {
            if (File.Exists(Storage.InitialLog))
            {
                var json = File.ReadAllText(Storage.InitialLog);
                InitialFileList = JsonSerializer.Deserialize<List<FileEntity>>(json);
            }
            else
            {
                SaveStartStateToJson();
            }
        }
        #endregion

        #region Methods to work with commits
        public void ReadCommits()
        {
            if (File.Exists(Storage.Log))
            {
                var json = File.ReadAllText(Storage.Log);
                if(!string.IsNullOrWhiteSpace(json))
                    Commits = JsonSerializer.Deserialize<List<Commit>>(json);
            }
            else
            {
                File.Create(Storage.Log).Dispose();
            }
        }
        public void SaveCommits()
        {
            if (File.Exists(Storage.Log))
            {
                File.Delete(Storage.Log);
            }
            var json = JsonSerializer.Serialize<List<Commit>>(Commits, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Storage.Log, json);
        }
        #endregion

        public void AddCommit(Commit commit)
        {
            Commits.Add(commit);
        }
    }
}
