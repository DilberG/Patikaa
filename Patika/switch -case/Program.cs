﻿using System;

namespace switch__case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                 Console.WriteLine("Ocak Ayındasınnız");
                 break;
                case 2:
                 Console.WriteLine("Şubat Ayındasınnız");
                 break;
                case 3:
                 Console.WriteLine("Mart Ayındasınnız");
                 break;
                case 4:
                 Console.WriteLine("Nisan Ayındasınnız");
                 break;
                default:
                 Console.WriteLine("Yanlış Veri Girşi");
                break;
            }
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                     Console.WriteLine("Kış Ayındasınız");
                    break;
                    case 3:
                    case 4:
                    case 5:
                     Console.WriteLine("İlkbahar Ayındasınız");
                    break;
                    case 6:
                    case 7:
                    case 8:
                     Console.WriteLine("Yaz Ayındasınız");
                    break;
                    case 9:
                    case 10:
                    case 11:
                     Console.WriteLine("Sonbahar Ayındasınız");
                    break;

                    default:
                    break;
                }
        }
    }
}