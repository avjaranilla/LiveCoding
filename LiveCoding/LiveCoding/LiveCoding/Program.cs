// See https://aka.ms/new-console-template for more information

/////Check Prime Numbers
//int input = 9;
//bool isPrimeNumber = true;

//var checkPrimeNumber = input % 2;

//if (input < 0)
//    throw new Exception("Invalid input. value should not be negative");

//for (int i = 2; i < input+1; i++)
//{

//    var result = input % i;
//    if (result == 0 && i != input)
//    { 
//        isPrimeNumber = false;
//        break;
//    }
//}


//if (isPrimeNumber)
//{
//    Console.WriteLine($"{input} is a prime number");
//}
//else 
//{
//    Console.WriteLine($"{input} is  not a prime number!");
//}




////Check if Palindrome
string word = "123454321";
string reversedWord = Reverse(word);

if (word == reversedWord)
{
    Console.WriteLine($"{word} is Palindrome");
}
else
{
    Console.WriteLine($"{word} is not Palindrome");
}

string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}




Console.Read();
