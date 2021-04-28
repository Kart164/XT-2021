using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace VCS
{
    public class Logger
    {
        public List<Commit> Commits { get; set; }
        public List<MyFile> InitialFileList { get; set; }

        public Logger()
        {
            Commits = new List<Commit>();
            InitialFileList = new List<MyFile>();
        }

        #region Save Origin Structure of directory to watch 
        public void SaveStartStateToJson()
        {
            if (!File.Exists(Storage.InitialLog))
            {
                var files = Directory.GetFiles(Storage.DirectoryToWatch, "*.txt", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    InitialFileList.Add(new MyFile(file, File.ReadAllText(file)));
                }
                var json = JsonSerializer.Serialize(InitialFileList, new JsonSerializerOptions { WriteIndented = true });
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
                InitialFileList = JsonSerializer.Deserialize<List<MyFile>>(json);
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
                File.Create(Storage.Log);
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
