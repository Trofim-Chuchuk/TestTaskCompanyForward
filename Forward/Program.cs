﻿using System;
using Forward.Logic;

namespace Forward {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Введите температуру окружающей среды");
            try {
                var temp = Convert.ToDouble(Console.ReadLine());
                if (temp > 10000 || temp <= -273) {
                    throw new Exception();
                }
                var RunningTest = new InitializationDataAndRunningTests("../../../Data.json",temp);
                RunningTest.ImplementationStandOne(RunningTest.InternalCombustionEngine);
                RunningTest.ImplementationStandTwo(RunningTest.InternalCombustionEngine);
                Console.ReadLine();
            }
            catch (FormatException) {
                throw new Exception("Ввели не коректные данные в температуру окружающей среды");
            }
            catch (Exception e) {
                throw new Exception("Температура не должна привышать 10000 по цельсию и ниже -273 по цельсию");
            }
          
        }
    }
}