namespace PracticalTasks5
{
    internal class Program
    {

        static string ReversWords(string inputPhrase)
        {
            string revText = Reverse(inputPhrase);
            
            return revText;
        }
        static string Reverse(string text)
        {
            string[] arrText = text.Split();
            string reversText = "";
            for (int i=arrText.Length; i > 0; i--) 
            {
                reversText = reversText + arrText[i-1] + " ";
            }
             
            return reversText;
        }
        static void WriteText(string text)
        {
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку которую требуется резделить");
            string srcText = Console.ReadLine();
            string NewReverseLine = ReversWords(srcText);
            WriteText(NewReverseLine);
            
        }
    }
}
