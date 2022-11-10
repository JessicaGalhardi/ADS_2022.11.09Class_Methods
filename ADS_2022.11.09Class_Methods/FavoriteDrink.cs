using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2022._11._09Class_Methods
{
    public class FavoriteDrink
    {
        public string ShowFavorite(string favoriteDrink)

        {

            switch (favoriteDrink)
            {
                case "Water":
                    favoriteDrink = "Your favorite drink is " + favoriteDrink + "? Is a nice choice!";
                    break;
                case "Beer":
                    favoriteDrink = "Your favorite drink is " + favoriteDrink + "? Me too! Which brand do you prefer?";
                    break;
                case "Orange juice":
                    favoriteDrink = "Your favorite drink is " + favoriteDrink + "? I love " + favoriteDrink + " too!";
                    break;
                default:
                    favoriteDrink = "I'm sorry, I don't know this drink!";
                    break;

            }

            return favoriteDrink;

        }
    }
}




