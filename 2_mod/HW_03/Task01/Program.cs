using System;

namespace Task01
{
    class Program
    {
        public static string RandName(Random rnd)
        {
            string name = "";
            for (int i = 0; i < rnd.Next(2, 7); ++i)
            {
                name += (char)rnd.Next('a', 'z' + 1); 
            }
            return name;
        }
        public class VidioFile
        {
            private string _name;
            private int _duration;
            private int _quality;
            public VidioFile(string fir, int sec, int thi) 
            {
                _name = fir;
                _duration = sec;
                _quality = thi;
            }
            public int Size 
            { 
                get { return _duration * _quality; }
            }
            public override string ToString()
            {
                return $"Name - {_name}, duration - {_duration}, quality - {_quality}.";
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            VidioFile A = new VidioFile(RandName(rnd), rnd.Next(60, 361), rnd.Next(100, 1001));
            VidioFile[] line = new VidioFile[rnd.Next(5, 16)];
            Console.WriteLine(A);
            for (int i = 0; i < line.Length; ++i)
            {
                line[i] = new VidioFile(RandName(rnd), rnd.Next(60, 361), rnd.Next(100, 1001));
                if (line[i].Size > A.Size)
                {
                    Console.WriteLine('+' + " " + line[i]);
                }
                else
                {
                    Console.WriteLine('-' + " " + line[i]); 
                }
            }

        }
    }
}
