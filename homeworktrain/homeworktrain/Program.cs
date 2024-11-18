Console.Write("lenght of train (meters) = ");
int trainLenght = int.Parse(Console.ReadLine());
Console.Write("Speed (m/sec) = ");
int trainSpeed = int.Parse(Console.ReadLine());
Console.Write("time (sec) =");
int trainTime = int.Parse(Console.ReadLine());

trainTime -= trainLenght / trainSpeed;

Console.WriteLine(trainSpeed * trainTime);