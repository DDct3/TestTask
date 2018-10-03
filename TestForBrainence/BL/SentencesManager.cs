using System;
using System.Linq;
using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class SentencesManager
    {
        public const string connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=TestDbForBrainence;Trusted_Connection=True;ConnectRetryCount=0";

        public static void ReverseSentences(string text, int entry)
        {
            text += ".";
            string [] strWithoutRev = text.Split(" ");
            string reverseString = "";
            for (int i = 0; i < strWithoutRev.Length; i++)
            {
                reverseString += new string(strWithoutRev[i].ToCharArray().Reverse().ToArray()) + " ";
            }
            reverseString = reverseString.TrimStart(' ');
            reverseString = reverseString.TrimEnd(' ');

            SaveToDb(reverseString, entry);
        }

        private static void SaveToDb(string text, int entry)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;
            DataContext context = new DataContext(options);

            context.Sentences.Add(new Sentences() { Text = text, EntryWord = entry });
            context.SaveChanges();
        }
    }
}
