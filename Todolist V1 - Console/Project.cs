using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist_V1___Console {
    class Project {
        private string name;
        private string description;
        private List<Task> tasks;

        public Project(string name_) {
            name = name_;
            description = "";
            tasks = new List<Task>();
        }

        public void AddTask(Task task) {
            tasks.Add(task);
        }

        public override string ToString() {
            return "Name: " + name + "; Description: " + description;
        }
    }
}
