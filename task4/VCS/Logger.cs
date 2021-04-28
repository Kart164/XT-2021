using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace VCS
{
    class Logger
    {
        public List<Commit> Commits { get; set; }
        public List<MyFile> InitialFileList { get; set; }



        #region Save Origin Structure of directory to watch 
        public void SaveStartStateToJson()
        {
            if (!File.Exists(Storage.InitialLog))
            {
                File.Create(Storage.InitialLog);
                var files = Directory.GetFiles(Storage.DirectoryToWatch, "*.txt", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    InitialFileList.Add(new MyFile(file, File.ReadAllText(file)));
                }
                var json = JsonSerializer.Serialize<List<MyFile>>(InitialFileList);
                File.WriteAllText(Storage.InitialLog, json);
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


    }
}
