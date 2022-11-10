using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_2022._11._09Class_Methods
{
    public class Answer
    {
        public List<string> ShowAnswer(string drink, string temperature, string food)

        {

            List<string> lstAnswer = new List<string>();

            if ((drink == "pro secco" || temperature == "iced")
                && (food == "pizza"))

            {
                lstAnswer.Add(" I want a " + drink + "bottle, please !" + " I love " + temperature + drink + " and " + food + "!");
            }
            else
            {
                lstAnswer.Add("A bottle of water, please." + " I only eat pizza!");
            }


            return lstAnswer;

        }



    }
}






