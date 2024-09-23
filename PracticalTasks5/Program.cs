namespace PracticalTasks5
{
    internal class Program
    {

        static String[] SplitText(string text)
        {
            string[] arrText = text.Split();
            return arrText;
        }
        static void WriteText(string text)
        {
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку которую требуется резделить");
            String srcText = Console.ReadLine();
            String[] splittedText;
            splittedText = SplitText(srcText);
            foreach (var a in splittedText)
            {
                WriteText(a);
            }
        }
    }
}
