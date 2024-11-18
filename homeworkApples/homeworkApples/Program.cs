Console.Write("box size = ");
int boxSize = int.Parse(Console.ReadLine());

if (boxSize < 1 || boxSize > 40)
{
    return;
}

int redApples = 0, yellowApples = 0;

for (int i = 1; i <= boxSize; i++)
{
    if (i % 2 == 0)
    {
        redApples += i * i;
    }
    else
    {
        yellowApples += i * i;
    }
}

Console.WriteLine("The difference between red and yellow apples is: " + (redApples - yellowApples));