using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist {
    class Task {
        private string name;
        private DateTime deadline;
        private bool done;

        public Task(string name) {
            this.name = name;
            this.deadline = DateTime.Now;
            this.done = false;
        }
        public override string ToString() {
            string toString = String.Empty;
            toString += name + ", deadline: " + deadline.ToString();
            return toString;
        }
    }
}
