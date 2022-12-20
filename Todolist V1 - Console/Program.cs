using Todolist_V1___Console;

List<Project> projects = new List<Project>();

while (true) {
    string command = Prompt("Give a command, for example \"add\"");
    switch (command) {
        case "add":
            string name = Prompt("Enter a name for the project");
            projects.Add(new Project(name));
            break;
        case "list":
            Console.WriteLine("Listing all projects:");
            foreach(Project project in projects) {
                Console.WriteLine(project.Name);
            }
            break;
        default:
            break;
    }
    Console.WriteLine();
}

string Prompt(string textToPromt) {
    Console.WriteLine(textToPromt);
    string? command = Console.ReadLine();
    if (command == null) {
        return "";
    }
    return command;
}