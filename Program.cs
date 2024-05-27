

const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

int computerWins = 0;
int playerWins = 0;
int gameCount = 0;
bool weHaveAWinner = false;

Console.WriteLine("Enter Username:");
string playersName = Console.ReadLine();
Console.WriteLine();


while (weHaveAWinner==false)
{

    gameCount++;

    Console.Write($"Game {gameCount}. Choose [r]ock, [p]aper, [s]cissors: ");
    string playerMove = Console.ReadLine();

    while (true)
    {
        if (playerMove == "r" || playerMove == "rock")
        {
            playerMove = rock;
            break;
        }
        else if (playerMove == "p" || playerMove == "paper")
        {
            playerMove = paper;
            break;
        }
        else if (playerMove == "s" || playerMove == "scissors")
        {
            playerMove = scissors;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input. Try Again...");
            playerMove = Console.ReadLine();
        }
    }

    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);

    string computerMove = "";
    switch (computerRandomNumber)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = paper;
            break;
        case 3:
            computerMove = scissors;
            break;


        default:
            break;
    }

    Console.WriteLine($"The computer chose {computerMove}.");

    if ((playerMove == rock && computerMove == scissors) ||
        (playerMove == paper && computerMove == rock) ||
        (playerMove == scissors && computerMove == paper))
    {
        playerWins++;
        Console.WriteLine("You win.");
        Console.WriteLine($"\nBest of 3\n{playersName}\t\tComputer\n{playerWins}\t\t{computerWins}\n\n");
        if (playerWins == 2)
        {
            weHaveAWinner = true;
        }
    }
    if ((playerMove == rock && computerMove == paper) ||
        (playerMove == paper && computerMove == scissors) ||
        (playerMove == scissors && computerMove == rock))
    {
        computerWins++;
        Console.WriteLine("You lose.");
        Console.WriteLine($"\nBest of 3\n{playersName}\t\tComputer\n{playerWins}\t\t{computerWins}\n\n");
        if (computerWins == 2)
        {
            weHaveAWinner = true;
        }

    }
    if ((playerMove == rock && computerMove == rock) ||
        (playerMove == paper && computerMove == paper) ||
        (playerMove == scissors && computerMove == scissors))
    {
        Console.WriteLine("Draw.");
        Console.WriteLine($"\nBest of 3\n{playersName}\t\tComputer\n{playerWins}\t\t{computerWins}\n\n");

    }

}

if (playerWins == 2)
{
    Console.WriteLine("The winner is Player");
}
else
{
    Console.WriteLine("The winner is Computer");

}


