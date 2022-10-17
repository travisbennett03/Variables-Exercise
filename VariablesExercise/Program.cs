namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Declerations
            int age;
            string name;
            bool isAlive;
            char namestartswith;
            double moneyspentoncoffee;
            decimal height; 
            
            // Variable Initalizations
            age = 26;
            name = "Travis";
            isAlive = true;
            namestartswith = 'T';
            moneyspentoncoffee = 6.42;
            height = 6;


            Console.WriteLine($"My name is {name}. I am {age}. is he alive: {isAlive}. My name starts with a {namestartswith}. Coffee this morning was {moneyspentoncoffee}. I am {height} feet tall");
        }
    }
}