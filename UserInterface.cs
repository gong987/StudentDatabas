namespace StudentDatabas
{
    internal class UserInterface
    {

        private StudentsHandler thisStudentsHandler;
       
        public UserInterface(StudentsHandler thisstudentshandler) 
        {
            thisStudentsHandler = thisstudentshandler;
        }

        public void StartInterface()
        {
            int choice;


            do
            {
                Console.WriteLine("Välkommen till studentdatabasen. Vad vill du göra?");
                Console.WriteLine("");

                Console.WriteLine("1. Lägg till en student");
                Console.WriteLine("2. Ändra/radera en student");
                Console.WriteLine("3. Lista alla studenter");
                Console.WriteLine("4. Avsluta programmet");
                Console.WriteLine("");
                Console.Write("Mitt val:"); choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (choice == 1)
                    AddStudentDialog(); 

                    if (choice == 2)
                    ChangeStudentDialog();

                    if (choice == 3)
                    
                    thisStudentsHandler.ListStudents();
                    Console.WriteLine("");

            }
            while (choice != 4);
        }

        public void AddStudentDialog() 
        {
            String? newOne = "";

            do
            {
                
                Console.WriteLine("Lägg till en ny student: ");
                Console.WriteLine("");
                Console.Write("Förnamn: "); string? firstName = Console.ReadLine();
                Console.Write("Efternamn: "); string? lastName = Console.ReadLine();
                Console.Write("Stad: "); string? city = Console.ReadLine();
                Console.WriteLine("");
                
                thisStudentsHandler.AddStudent(firstName, lastName, city);

                Console.Write("Student sparad i databasen. Vill du lägga till en ny student (j/n)?"); newOne = Console.ReadLine();
            }
            while (newOne != "n");


        }

        public void ChangeStudentDialog() 
        {
            int choice;
            
            do
            {
                thisStudentsHandler.ListStudents();
                Console.WriteLine("");
                Console.Write("Vilken student vill du ändra eller radera? (Skriv in studentens ID-nummer): "); 
                int studentId = Convert.ToInt32(Console.ReadLine());
                
                
                Console.WriteLine("Vad vill du göra för ändringar på aktuell student?");
                Console.WriteLine("");
                Console.WriteLine("1. Ändra Förnamn");
                Console.WriteLine("2. Ändra Efternamn");
                Console.WriteLine("3. Ändra Stad ");
                Console.WriteLine("4. Radera Studenten från databasen");
                Console.WriteLine("5. Återvända till huvudmenyn");
                Console.WriteLine("");

                Console.Write("Mitt val:"); choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (choice == 1)
                { 
                    Console.Write("Skriv in nytt förnamn: "); string? firstName = Console.ReadLine();
                    thisStudentsHandler.ChangeStudentFirstName(studentId, firstName);
                    Console.WriteLine("Gratulerar. Studentuppgifter ändrade.");
                    Console.WriteLine("");
                }
                if (choice == 2)
                {
                    Console.Write("Skriv in nytt efternamn: "); string? lastName = Console.ReadLine();
                    thisStudentsHandler.ChangeStudentLastName(studentId, lastName);
                    Console.WriteLine("Gratulerar. Studentuppgifter ändrade.");
                    Console.WriteLine("");
                }

                if (choice == 3)
                {
                    Console.Write("Skriv in ny ort: "); string? city = Console.ReadLine();
                    thisStudentsHandler.ChangeStudentCity(studentId, city);
                    Console.WriteLine("Gratulerar. Studentuppgifter ändrade.");
                    Console.WriteLine("");
                }
                if (choice == 4)
                {
                    Console.Write("Radera aktuell student (j/n): "); string? answer = Console.ReadLine();
                    if (answer == "j")
                    thisStudentsHandler.RemoveStudent(studentId);
                    Console.WriteLine("Gratulerar. Studenten är nu raderad.");
                    Console.WriteLine("");
                }

            }
            while (choice != 5);

        }


    }
}
