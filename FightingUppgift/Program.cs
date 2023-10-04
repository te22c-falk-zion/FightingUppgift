
bool maincode = true;
int money = 0;
bool block = false;

while (maincode == true)
{
int player1Hp = 100;
int player2Hp = 100;
string[] names = {"Astolfo","Zote","Gabriel"};


Console.WriteLine("Welcome challenger to the placeholder Colossuem. Bet on or against your figher and gain points!");
// Console.WriteLine("Points can be used at the shop or something");
string player1name = "";
while (player1name.Length <3 || player1name.Length >10)
{
Console.WriteLine("Player, pick your representing fighter!");
player1name = Console.ReadLine();
}




Random generator = new Random();
var random = new Random();
string player2name = names[random.Next(0, names.Length)];

Console.WriteLine($"You have {money} points");
Console.WriteLine($"Your opponent is {player2name}!\n Who do you bet on winning? {player1name} or {player2name}?");
if (player2name == "zote")
{
    Console.WriteLine("Zote: Of course they will bet on me! I am the greatest in this whole Colosseum!!");
}
string guess = Console.ReadLine().ToUpper();
// Console.WriteLine($"How much gold do you want to bet?\nYou have {money} gold left.");
// int bet = Console.ReadLine(); // Hur fuck läser jag deras bet????


// ----------------------------------------------------------------------------------------------------------------------------------------

while (player1Hp > 0 && player2Hp > 0)
{
    Console.WriteLine("\n New Round");
    Console.WriteLine($"{player1name}: {player1Hp}  {player2name}: {player2Hp}\n");
    Console.WriteLine("[Heavy] or [Light] or [Block]?");
    string attack = Console.ReadLine().ToUpper();

    if(attack == "LIGHT")
    {
    int damage1 = generator.Next(20);
    player2Hp -= damage1;
    player2Hp = Math.Max(0, player2Hp);
    Console.WriteLine($"{player1name} used their light attack!\n {player1name} did {damage1} damage on {player2name}!!");
    }
    else if (attack == "HEAVY")
    {
    int accuracy = generator.Next(10);
    if (accuracy >5)
    {
    int damage1 = generator.Next(10,35);
    player2Hp -= damage1;
    player2Hp = Math.Max(0, player2Hp);
    Console.WriteLine($"{player1name} used their heavy attack!\n {player1name} did {damage1} damage on {player2name}!!");
    }
    else
    {
        Console.WriteLine($"{player1name} charges their fist, ready to puncture it through the stomach of {player2name}\n But he missed and fell over, taking 1 damage...");
        player1Hp -= 1;
    }
    }
    else if (attack == "BLOCK")
    {
        block = true;
        Console.WriteLine($"{player1name} prepares to block {player2name}'s attack!");
    }
    else
    {
        Console.WriteLine($"{player1name} fumbled under pressure and failed to attack!");
    }

// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

if (player2name == "Gabriel")
{
        if (attack == "BLOCK")
    {
    int damage3 = generator.Next(49,49);
    player1Hp -= damage3;
    player1Hp = Math.Max(0, player1Hp);
    Console.WriteLine($"Gabriel: Foolish, attempt to block as you might. But in the end you shall prerish nontheless.");
    Console.WriteLine($"{player2name} did {damage3} damage on {player1name}!!");
    block = false;
    }
    else
    {
    int damage2 = generator.Next(99,99);
    player1Hp -= damage2;
    player1Hp = Math.Max(0, player1Hp);
    Console.WriteLine($"Gabriel: BEHOLD! The power of an Angel!\n {player2name} did {damage2} damage on {player1name}!!");
    Console.ReadKey();
    }
}
else if (block == true)
{
    Console.WriteLine($"{player2name} attemps to attack but was blocked!\n {player1name} takes no damage!");
    block = false;
}
else if (player2name == "Astolfo")
{
    int damage2 = generator.Next(1,25);
    player1Hp -= damage2;
    player1Hp = Math.Max(0, player1Hp);
    Console.WriteLine($" {player2name} used their {player2name} beam!!!\n {player2name} did {damage2} damage on {player1name}!!");
    Console.ReadKey();
}
else if (player2name == "Zote")
{
    int accuracy = generator.Next(10);
    if (accuracy >6)
    {
    int damage2 = generator.Next(5,5);
    player1Hp -= damage2;
    player1Hp = Math.Max(0, player1Hp);
    Console.WriteLine($"Zote: Perish! For I, Zote, will deliver the ultimate punsihment upon my opponent!\nZote: Bow down and quiver as you hear my attack shake the air itself!\n Go! Zote Slash!\n {player2name} did {damage2} damage on {player1name}... wow...");
    }
    else
    {
        Console.WriteLine($"Zote: Perish! For I, Zote, will deliver the ultimate punsihment upon my opponent! Bow down and quiver as you hear my attack shake the air itself!\n Go! Zote Slash!\n {player2name} Charges at {player1name} and trips onto the ground...");
        player2Hp -= 1;
        Console.WriteLine($"{player2name} took 1 damage and pitifully picks himself up from the ground");
        Console.WriteLine($"Zote: ...");
        Console.ReadKey();
        Console.WriteLine("Zote: Be glad! For I, Zote, have spared you on this day!");
        Console.ReadKey();

    }
}
 }

//----------------------------------------------------------------------------------------------------------------------

Console.WriteLine("\n Round end");

if (player1Hp == 0 && player2Hp == 0)
{
    Console.WriteLine("Draw!");
}
else if (player1Hp == 0)
{
    Console.WriteLine($"{player2name} won!");
    if (guess == player2name.ToUpper())
    {
        money = money + 5;
        Console.WriteLine($"Your prediction won and you won 5 points!!");

    }
     else if (guess == player1name)
    {
        money = money - 5;
        Console.WriteLine($"Your prediction lost and you lose 5 points.");
    }
}
else
{
    Console.WriteLine($"{player1name} won!");
    if (player2name == "Zote")
    {
        Console.WriteLine("Zote: hmph, I simply faked weakness in order to rise spirits in the colosseum\nZote: This win means nothing. Get that? NOTHING.");
    }
    if (guess == player1name)
    {
        money = money + 5;
        Console.WriteLine($"Your prediction won and you won 5 points!!");

    }
    else if (guess == player2name)
    {
        money = money - 5;
        Console.WriteLine($"Your prediction lost and you lose 5 points.");
    }
    else 
    {
        Console.WriteLine("Challenger did not bet/misspelt their name");
    }
}
Console.WriteLine($"\n {player1name}: {player1Hp}  {player2name}: {player2Hp}");
Console.WriteLine($"Points: {money}");
Console.ReadKey();

bool repeat = true;
while (repeat == true)
{
Console.WriteLine("Would you like to repeat? Y/N");
string answer = Console.ReadLine().ToUpper();
if (answer == "N")
{
    maincode = false;
    repeat = false;
}
else if (answer == "Y")
{
    repeat = false;
}
}
}

