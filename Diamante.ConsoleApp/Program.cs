﻿using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Começo_e_Fim.ShowMenu();
                Validação.EntryValidation();
                GeradoresDoDiamante.ArraysGenerator();
                GeradoresDoDiamante.DiamondCreator();
                if (!Começo_e_Fim.Restart())
                    break;
            }
        }

    }
}

