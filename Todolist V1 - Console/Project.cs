namespace Todolist {
    class Project {
        private string name;
        private string description;
        private List<Task> tasks;

        public Project(string name_) {
            name = name_;
            description = "No description";
            tasks = new List<Task>();
        }

        public void AddTask(Task task) {
            tasks.Add(task);
        }

        public string GetName () {
            return name;
        }

        public override string ToString() {
            string toString = String.Empty;
            toString += "Name: " + name + "\n";
            toString += "Description: " + description + "\n";

            toString += "Has tasks: \n";
            foreach (Task task in tasks) {
                toString += "\t" + task.ToString();
            }
            return toString;
        }
    }
}
