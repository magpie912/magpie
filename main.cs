using System;

class MyMain
{
    static void Main(string[] args)
    {
	int totals = 0;
	int trues = 0;
	long value;
	Console.WriteLine("C program for illustrating code coverage");

	while (true) {
	    Console.Write("Enter number to test for primality: ");
	    var input = Console.ReadLine();
	    if(!Int64.TryParse(input, out value)) {
		break;
	    }
	    if (Prime.isPrime(value)) {
		Console.WriteLine(value + " is a prime number");
		trues++;
	    } else {
		Console.WriteLine(value + " is not a prime");
	    }
	    totals++;
	}

	Console.WriteLine(" -> "+trues+"/"+totals+" tests resulted in a prime number\n");
	
    }
}
