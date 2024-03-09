namespace Testify_CSharp_Example{
    public class Program{
        public static void Main(string[] args)
        {
            TextReader reader = Console.In;
            TextWriter writer = Console.Out;
            Start(reader, writer);
        }

        public static void Start(TextReader reader, TextWriter writer)
        {
            writer.WriteLine("Hello, welcome to the student database!\n" +
                              "This is a simple program that allows you to add and remove students from a list.\n" +
                              "You can also view the list of students.");
            string choice = "";
            StudentList studentList = new StudentList();
            while (choice != "4")
            {
                PrintMenu();
                choice = reader.ReadLine() ?? String.Empty;
                switch (choice)
                {
                    case "1":
                        studentList.AddStudent(reader, writer);
                        break;
                    case "2":
                        studentList.RemoveStudent(reader, writer);
                        break;
                    case "3":
                        studentList.Print();
                        break;
                    case "4":
                        writer.WriteLine("Goodbye!");
                        break;
                    default:
                        writer.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        private static void PrintMenu()
        {
            Console.WriteLine("1. Add a student\n" +
                              "2. Remove a student\n" +
                              "3. View the list of students\n" +
                              "4. Exit\n" +
                              "Enter your choice: ");
        }
    }
}