using System.Formats.Asn1;

        int choice = 0;
        Random rng = new Random(4000);

        do
        {
            choice = 0;

            Console.WriteLine("=== CSCI 1250 Lab 06 ===");
            Console.WriteLine("1. The Grade Checker");
            Console.WriteLine("2. The Dice Table");
            Console.WriteLine("3. The Score Report");
            Console.WriteLine("4. All three");
            Console.WriteLine("5. Quit");
            Console.Write("Pick an option between 1 and 5: ");
            choice = Convert.ToInt32(Console.ReadLine());            
        }

        

        while (choice < 1 || choice > 5);
        {
                Console.WriteLine("Error! Please enter a number between 1 and 5!");
        }
        if (choice == 1 || choice == 4)
        {
            Console.WriteLine("=== Exercise 1: The Grade Checker ===");
            Console.Write("Score: ");
            int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90) {
            Console.WriteLine(grade + " is an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine(grade + " is a B");       
        }
        else if (grade >= 70)
        {
            Console.WriteLine(grade + " is a C");
        }
        else if (grade >= 60)
        {
             Console.WriteLine(grade + " is a D");
        }
        else if (grade < 60)
        {
                Console.WriteLine(grade + " is an F");
            }
        }
        if (choice == 2 || choice == 4)
        {
            Console.WriteLine("=== Exercise 2: The Dice Table ===");
            int totalRoll = 0;
            int totalWin = 0;
            string answer;

            do
            {
                int firstDie = rng.Next(1, 7);
                int secondDie = rng.Next(1, 7);
                int total = firstDie + secondDie;

                totalRoll++;

                Console.Write("Roll " + totalRoll + ":" + firstDie + " & " + secondDie +", total " + total +". ");

                if (firstDie == 1 && secondDie == 1)
                    {
                        Console.WriteLine("Snake eyes.");
                    }
                else if (firstDie == secondDie)
                    {
                        Console.WriteLine("Doubles!");
                    }
                else if (total == 7 || total == 11)
                    {
                        Console.WriteLine("A winner.");
                        totalWin++;
                    }
                else
                    {
                        Console.WriteLine("");
                      }
                 Console.Write("Roll again? (y/n)? ");
                 answer = Console.ReadLine();
            }
                while (answer == "y");
                    {
                    Console.WriteLine("You rolled " + totalRoll + " and won " + totalWin);
                    }
            if (choice == 3 || choice == 4)
            {
                Console.WriteLine("=== Exercise 3: The Score Report ===");

                int[] grades = new int [5];

                for (int i = 0; i < grades.Length; i++)
                {
                    grades[i] = -1;

                    if (grades[i] < 0 || grades[i] > 100)
                    {
                        Console.WriteLine("Score: ");
                    }
                }
                 
            }
        }
        while (choice == 5)
        {
            Console.WriteLine("Goodbye.");
        }


