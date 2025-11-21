using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap vao ten cua ban: ");
            string fullName = Console.ReadLine();
            string tempFullName = fullName;
            char kiTu = ' ';
            string[] words = fullName.Split(kiTu, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            fullName = string.Join(" ", words);

            Console.Write("Nhap vao tuoi: ");
            int tuoi;
            while (true) {
                tuoi = Convert.ToInt32(Console.ReadLine());
                if (tuoi > 0 && tuoi < 134) break;
                else Console.Write("Vui long nhap lai tuoi !!! : ");
            }
            Console.WriteLine("--------------------------------------------");
            bool result = string.Equals(fullName, tempFullName);
            Console.Write($"-> Ho ten cua you la: {fullName}");
            if (!result) Console.WriteLine(" (==^3^==) [TEN CUA BAN DA DUOC CHUAN HOA BOI TOI]");
            else Console.WriteLine();
            Console.WriteLine($"-> WHATTTTTT !!! Nam sau ban {++tuoi} roi a =)))))))))");

        }
    }
}