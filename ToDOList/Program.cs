﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Add an task \n" +
                              "[2] Show all tasks \n" +
                              "[3] Delete all tasks \n" +
                              "Please, select an option: ");
            int option = int.Parse(Console.ReadLine());
            ActionHandler handler = new ActionHandler();
            handler.checkSelectedOption(option);

        }
    }
}