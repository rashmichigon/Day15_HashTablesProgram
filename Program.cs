namespace Day15_HashTablesProgram
{
    internal class Program
    {
        static void Main(String[] args)
        {
            String str = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            Console.WriteLine("Given String : " + str);

            // delete from index 5 to end of string
            Console.WriteLine("New String1 : " + str.Remove(111));

            // delete character from index 8 to end of string
            //Console.WriteLine("New String2 : " + str.Remove(20));
        }
    }
}