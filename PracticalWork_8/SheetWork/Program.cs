﻿using System;

namespace SheetWork
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkSheet numbers = new WorkSheet();
            numbers.SheetFilling();

            ConsoleOperation.SheetPrinting(numbers.Numbers);

            numbers.NumberDeletion();

            ConsoleOperation.SheetPrinting(numbers.Numbers);
        }
    }
}