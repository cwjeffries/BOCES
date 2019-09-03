/*******************************************
 * Author: Chase Jeffries
 * Purpose: Class file for creating task
 *          objects for use in functions
 ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffries_BOCES1
{
    class Task
    {
        private string taskID;
        private string taskName;

        public string TaskID { get => taskID; set => taskID = value; }
        public string TaskName { get => taskName; set => taskName = value; }

        public Task()
        {
            this.taskID = "";
            this.taskName = "";
        }

        public Task(string pID, string pName)
        {
            this.taskID = pID;
            this.taskName = pName;
        }
    }
}
