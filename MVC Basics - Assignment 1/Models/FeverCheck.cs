using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics___Assignment_1.Models
{
    public class FeverCheck
    {
        static readonly int FEVER = 38;
        static readonly int HYPOTHERMIA = 35;

        public static string Fever(int temperature, string celciusfahrenheit)
        {
            if (temperature.Equals(0))
            {
                return null;
            }
            else if (celciusfahrenheit== "fahrenheit")
            {
                temperature = Convert.ToInt16((temperature - 32) / 1.8000);
            }

            if (temperature >= FEVER)
            {
                return "You've got fever";
            }
            else
            {
                if (temperature < HYPOTHERMIA)
                {
                    return "You don't have any fever but you suffer of hypothermia. Call for ambulance!";
                }
                else
                {
                    return "You don't have any fever";
                }
            }
        }

    }
}
