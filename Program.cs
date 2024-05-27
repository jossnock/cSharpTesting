// // Printing things:
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, World!");

// /* Testing the
// multi-line comments */

// const int coolNum = 2;

// string printItem = "oOoOoOoOo";
// int printItem2 = 3050;
// float printItem3 = 0.43F;

// string spookyWord = "B" + printItem;

// int triangeSides = 3, squareSides = 4, pentagonSides = 5, hexagonSides = 6;

// float scienceWooo = 3.00e8F;

// const bool isGoodCode = true;

// char test = 'a';

// Console.WriteLine($"{printItem2} {spookyWord}");
// Console.WriteLine(printItem3);


// Console.WriteLine("Do you want to be spooked? (y/n):");
// char userResponse = Convert.ToChar(Console.ReadLine());
// if (userResponse == 'y'){
//     Console.WriteLine(spookyWord);
// }
// else{
//     Console.WriteLine($"Okay then, look at this cool number: {coolNum}");
// }

Console.Write("Circle radius: ");
double circleRadius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Area = {Math.PI * Math.Pow(circleRadius, 2):F3}\nCircumference = {Math.PI * circleRadius * 2:F3}");