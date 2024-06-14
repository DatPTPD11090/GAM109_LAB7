using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            List<int> nums = new List<int> { 1, 3, 4, 5, 8, 9 };

            var result = nums.Where(n => n > 4)
                             .Select(n => n * n);

            Console.WriteLine("Binh phuong cua cac so lon hon 4 la:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

           
            string strb = "chao mung den voi binh nguyen vo tan";

            var wordCounts = strb.Split(' ')
                                 .GroupBy(word => word)
                                 .Select(group => new { Word = group.Key, Count = group.Count() });

            Console.WriteLine("So lan hien cua tung chu:");
            foreach (var wc in wordCounts)
            {
                Console.WriteLine($"'{wc.Word}': {wc.Count}");
            }

            
            string strc = "CHAO mung DEN Voi binh nguyen vo tan";

            var uppercaseWords = strc.Split(' ')
                                     .Where(word => word.All(char.IsUpper));

            Console.WriteLine("Chuoi duoc viet hoa toan bo:");
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}


