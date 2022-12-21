using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist_V1___Console {
    class Task {
        private string name;
        private DateTime deadline;
        private bool done;

        public Task(string name) {
            this.name = name;
            this.deadline = DateTime.Now;
            this.done = false;
        }
    }
}
