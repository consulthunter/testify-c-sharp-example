namespace Testify_CSharp_Example{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello, welcome to the student database!\n" +
                              "This is a simple program that allows you to add and remove students from a list.\n" +
                              "You can also view the list of students.");
            string choice = "";
            StudentList studentList = new StudentList();
            while (choice != "4")
            {
                PrintMenu();
                choice = Console.ReadLine() ?? String.Empty;
                switch (choice)
                {
                    case "1":
                        studentList.AddStudent();
                        break;
                    case "2":
                        studentList.RemoveStudent();
                        break;
                    case "3":
                        studentList.Print();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
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