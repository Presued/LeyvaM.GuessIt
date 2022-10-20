//Manuel Leyva
//10-19-22
//Guess it
//The user will select a level they want to play, with in that level are a set of numbers
//what ever number lies between the first number and last number, you have to guess the number the program 
//has chossen, durring the process of picking your number the program will tell you if its too high or too low
//Once you figure of the programs number it will tell you how many tries it took you to get the number.
//Peer review:

   Console.Clear();


string iChoice = "";

do{
Console.Clear();
Console.WriteLine("Guessing game! what level would you like to play");
Console.WriteLine(" Easy -  from 1 - 10");
Console.WriteLine(" Medium -  from 1 - 50");
Console.WriteLine(" Hard -  from 1 - 100");
Console.WriteLine("Please Enter 1 for easy, 2 for Medium, or 3 for Hard");



int option ;
bool isNumber = false;


isNumber = Int32.TryParse(Console.ReadLine(), out option);

while (option != 1 &&  option != 2 && option !=3)
{
    Console.WriteLine("Please enter 1, 2, or 3");
    isNumber = Int32.TryParse(Console.ReadLine(), out option);    
}


if (option == 1){
 
Random random = new Random();
int min = 1;
int max = 10;
int guess;
int number;
int guesses;
bool checkNum1;

 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
        do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine(" bro thats not a number , you gotta pick a number between 1 and 10");
                }
        }while(checkNum1 == false);

        if(guess > number)
        {
        Console.WriteLine(guess + " too high try again bro ");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " to low bro think higher ");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine(" I guess you got it");
    Console.WriteLine("");  
   
    Console.WriteLine("The number was: " + number);
   
    Console.WriteLine(" How did you win ");
   
    Console.WriteLine("Guesses: " + guesses);
   
}  

 
 
else if(option ==2){
   
Random random = new Random();
int min = 1;
int max = 50;
int guess;
int number;
int guesses;
bool checkNum1;
 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
        do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine(" Bro thats not a number , you gotta pick one between 1 to 50 ");
                }
        }while(checkNum1 == false);

        if(guess > number)
        {
        Console.WriteLine(guess + " Bro its too high ");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " bro its too low ");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine(" Bro how did you get it ");
    Console.WriteLine("");  
   
    Console.WriteLine("The number was: " + number);
    
    Console.WriteLine(" I guess you win ");
  
    Console.WriteLine("Guesses: " + guesses);
    
}

else if (option ==3)
{
Random random = new Random();
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
bool checkNum1;
 
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
   
    while(guess != number)
    {
     do{
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        checkNum1 = Int32.TryParse(Console.ReadLine(), out guess);
            if (checkNum1 == false)
                {
                    Console.WriteLine(" bro thats not a number , you gotta pick a number between 1 and 100 ");
                }
        }while(checkNum1 == false);   
        if(guess > number)

        {
        Console.WriteLine(guess + " bro thats to high");
        }else if(guess < number)
        {
          Console.WriteLine(guess + " Bro thats to low");
        }
    guesses++;
    }
    Console.WriteLine("");  
    Console.WriteLine(" Some how you got it ");
    Console.WriteLine("");  
    
    Console.WriteLine("The number was: " + number);
   
    Console.WriteLine(" I guess you win ");
    
    Console.WriteLine("Guesses: " + guesses);
    
}


do
{
   Console.WriteLine(" Bro do you wanna play again, Yes or No");
   iChoice = Console.ReadLine().ToUpper();
   if(iChoice != "Yes" && iChoice != "NO")
   {
       Console.WriteLine(" Try again bro, I said Yes or No");
   }
}while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");