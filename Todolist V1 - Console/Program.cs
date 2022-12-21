using Todolist;

List<Project> projects = new List<Project>();
String[] commands = {"help", "add", "list", "clear"};

while (true) {
    string command = Prompt("Give a command, for example \"add\"");
    switch (command) {
        case "add":
            string classToCreate = Prompt("Enter what to create, for example \"project\"");
            switch (classToCreate) {
                case "project":
                    string projectName = Prompt("Enter the name for the project");
                    projects.Add(new Project(projectName));
                    break;
                case "task":
                    string taskProject = Prompt("Enter the name of the project the task should belong to");
                    Project? project = projects.Find(x => x.GetName() == taskProject);
                    if (project == null) {
                        Console.WriteLine("There exists no such project");
                        break;
                    }
                    string taskName = Prompt("Enter the name of the task");
                    project.AddTask(new Todolist.Task(taskName));
                    break;
                default:
                    break;
            }
            break;
        case "list":
            Console.WriteLine("Listing all projects:");
            foreach(Project project in projects) {
                Console.WriteLine(project.ToString());
            }
            break;
        case "clear":
            Console.Clear();
            break;
        case "help":
            Console.WriteLine("All available commands");
            foreach(string exampleCommand in commands) {
                Console.WriteLine(exampleCommand);
            }
            break;
        default:
            break;
    }
}

string Prompt(string textToPromt) {
    Console.WriteLine(textToPromt);
    string? command = Console.ReadLine();
    if (command == null) {
        return "";
    }
    return command;
}