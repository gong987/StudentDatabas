namespace StudentDatabas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var thisDbContext = new MyDbContext();
            var thisStudentsHandler = new StudentsHandler(thisDbContext);
            var thisInterface = new UserInterface(thisStudentsHandler);

            thisInterface.StartInterface();


            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        }
    }
}
