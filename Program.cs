﻿using System;

namespace SyntaxSugar;

internal class SyntaxSugar
{

    static void Main(string[] args)
    {
        int answer = 4;
        var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
        Console.WriteLine(response);

    }
}
