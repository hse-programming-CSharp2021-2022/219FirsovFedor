using System;
using System.IO;

namespace HS_11
{
        class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                using (var fileStream = new FileStream("Numbers.txt",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    if (fileStream.Length == 0)
                    {
                        BinaryWriter bw = new(fileStream);
                        for (int i = 0; i < 10; i++)
                        {
                            bw.Write(rnd.Next(1, 179));
                        }
                    }
                    else
                    {
                        BinaryReader fin = new(fileStream);
                        int[] arrayNum = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            arrayNum[i] = fin.ReadInt32();
                            Console.Write(arrayNum[i] + " ");
                        }
                        int a = int.Parse(Console.ReadLine());
                        int id = 0, minDiff = Math.Abs(a - arrayNum[0]);
                        for (int i = 1; i < 10; i++)
                        {
                            if (Math.Abs(a - arrayNum[0]) < minDiff)
                            {
                                id = i;
                            }
                        }
                        arrayNum[id] = a;
                        fileStream.Position = 0;

                        BinaryWriter fout = new(fileStream);
                        for (int i = 0; i < 10; i++)
                        {
                            fout.Write(arrayNum[i]);
                        }
                        fileStream.Position = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            arrayNum[i] = fin.ReadInt32();
                            Console.Write(arrayNum[i] + " ");
                        }
                    }
                }
            }
        }
}
