using System;

// Write a public method that accepts a number

// when the number is divisible by 3 return the word fizz

// when the number is divisible by 5 return the word buzz

// when the number is divisible by both, return the word fizzbuzz

public string fizzbuzz (int number)
{
    string word = "";

    if (number % 3 == 0)
    {
        word += "fizz";
    }
    if (number % 5 == 0)
    {
        word += "buzz";
    }

    return word;
}
