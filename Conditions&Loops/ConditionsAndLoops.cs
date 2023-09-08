using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fundamentals
{
    public class ConditionsAndLoops
    {
        public void ConditionalStatements()
        {
            Random dice = new Random();
            int roll1, roll2, roll3;

            roll1 = dice.Next(1,7);
            roll2 = dice.Next(1,7);
            roll3 = dice.Next(1,7);

            int total_roll = roll1 + roll2 + roll3;
            Console.WriteLine( $"Dice Roll: {total_roll} " );

            if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3) 
            {
                if(roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total_roll += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total_roll += 2;
                }

            }

            if (total_roll >= 16)
            {
                Console.WriteLine("You won a new car"); 
            }
            else if(total_roll >= 10)
            {
                Console.WriteLine("You won a new laptop!");
            }
            else if (total_roll == 7)
            {
                Console.WriteLine("You won a movie ticket for two");
            }
            else
            {
                Console.WriteLine("You won nothing");
            }

        }

        //  TASK : Improve renewal rate of subscriptions 
        public void MicrosoftTask()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your Subscription has expired");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires in one day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will be expiring soon. Renew now!");
            }
            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }

        }
        // UDEMY CHALLENGE
        public void CheckHighScore(int score , string playerName)
        {
            int highScore = 280;
            string highScoredPlayer = "Rohit Sharma";

            if (score > highScore)
            {
                highScore = score;
                highScoredPlayer = playerName;

                Console.WriteLine("The new high Score is " + score);
                Console.WriteLine("It's held by " + highScoredPlayer);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken, it's still  "
                    + highScore + " which is held by " + highScoredPlayer);
            }

        }
        public void TernaryOperator(int temperature)
        {
            string stateOfMatter;
            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine($"state of matter is {stateOfMatter}");

            //UDEMY TASK
            int input_temp = 0;
            string temp_message = string.Empty;
            string inputValue = string.Empty;
        }



    }
}
