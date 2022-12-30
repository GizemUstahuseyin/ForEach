namespace ForEach
{
    internal class ForEach
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Gizem", "Mehmet", "Güven" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}