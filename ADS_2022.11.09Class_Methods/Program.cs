

namespace ADS_2022._11._09Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answer = new List<string>();
            try
            {
                string drink = "pro secco ";
                string temperature = "iced";
                string food = "hamburger";
                string favoriteDrink = "Orange juice";

                //________________________________________________________________________
                //Instantiate Answer class

                Answer objAnswer = new Answer();
                answer = objAnswer.ShowAnswer(drink, temperature, food);

                //foreach created to show for the program lstAnswer as a list and sent the correct value to console
                foreach (var answerItem in answer)
                {
                    Console.WriteLine(answerItem);

                }

                //________________________________________________________________________
                //Instantiate FavoriteDrink class

                FavoriteDrink obj = new FavoriteDrink();
                string favoriteChoice = obj.ShowFavorite(favoriteDrink);

                Console.WriteLine(favoriteChoice);
            }
            catch (Exception)
            {

                Console.WriteLine("Error while running the application!");

            }

        }
    }
}
