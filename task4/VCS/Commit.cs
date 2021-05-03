using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    /// <summary>
    /// Class that saves all changes in files
    /// </summary>
    public class Commit
    {
        public List<Change> Changes { get; set; }
        public DateTime DateTimeOfCommit { get; set; }

        public Commit()
        {

        }
        public Commit(List<Change> list)
        {
            Changes = list;
        }
        public Commit(List<Change>list, DateTime dateTimeOfCommit)
        {
            Changes = list;
            DateTimeOfCommit = dateTimeOfCommit;
        }

        
    }
}
