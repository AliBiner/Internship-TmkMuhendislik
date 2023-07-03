using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace TmkMuhendislik.RandomData
{
    public class RandomDataNavbar
    {

        
        public static String[] RndCount(int piece)
        {
            Random rnd = new Random();
            String[] words = new string[piece];
            for (int i = 0; i < piece; i++)
            {
                //int length = rnd.Next(1, 11);
                words[i] = GenerateRandomWord(20);
            }
            
             
            return words;
        }

        public static string GenerateRandomWord(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var word = new char[length];

            for (int i = 0; i < length; i++)
            {
                word[i] = chars[random.Next(chars.Length)];
            }

            return new string(word);
        }
    }
}