﻿string hello = " we are the champtions?";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim ();

hello = hello.Trim();
char firstLetter = hello[0];
Console.WriteLine(firstLetter);


hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');



firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);




//int wordCounter = 0;
//for (int i = 1; i < hello.Length; i++)
//{
//    if (hello[i] == '  ')
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words");