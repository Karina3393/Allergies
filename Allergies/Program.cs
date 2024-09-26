namespace Allergies
{
    internal class Program
    {
        class Allergies
        {
            
            private Dictionary<string, int> allergens = new Dictionary<string, int>
    {
        { "Eggs", 1 },
        { "Peanuts", 2 },
        { "Shellfish", 4 },
        { "Strawberries", 8 },
        { "Tomatoes", 16 },
        { "Chocolate", 32 },
        { "Pollen", 64 },
        { "Cats", 128 }
    };

            
            private int score;

           
            public Allergies(int score)
            {
                this.score = score;
            }

            
            public bool IsAllergicTo(string allergen)
            {
                if (allergens.ContainsKey(allergen))
                {
                    return (score & allergens[allergen]) != 0;
                }
                return false;
            }

          
            public List<string> GetAllergies()
            {
                List<string> result = new List<string>();

                foreach (var allergen in allergens)
                {
                    if ((score & allergen.Value) != 0)
                    {
                        result.Add(allergen.Key);
                    }
                }

                return result;
            }
        }


        static void Main(string[] args)
        {
            Allergies tomAllergies = new Allergies(34);

            Console.WriteLine("Чи є алергія на арахіс? " + tomAllergies.IsAllergicTo("Peanuts"));
            Console.WriteLine("Чи є алергія на кішок? " + tomAllergies.IsAllergicTo("Cats")); 

           
            List<string> allergies = tomAllergies.GetAllergies();
            Console.WriteLine("Алергії Тома: " + string.Join(", ", allergies)); 
        }
    }
}

