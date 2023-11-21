namespace GitTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Danial Abedini";
            Danial.Name = name;
            Console.WriteLine(Danial.Name);
            Console.ReadLine();
        }
    }

   public static class Danial
    {
        public static string Name { set; get; }

    }
}