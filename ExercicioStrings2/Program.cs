namespace ExercicioStrings2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine("Digite a frase que você deseja saber a quantidade de letras: ");
            Console.WriteLine();
            String frase = "fala galera da academia";

            string[] palavras = frase.Split(' ');
            Console.WriteLine(palavras.Length);

            Console.ReadLine();




            ;





        }
    }
}