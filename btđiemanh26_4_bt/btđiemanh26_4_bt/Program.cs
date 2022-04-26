using System;

namespace btđiemanh26_4_bt
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Nhap a,b,c: ");
                double a255 = Int32.Parse(Console.ReadLine());
                double b255 = Int32.Parse(Console.ReadLine());
                double c255 = Int32.Parse(Console.ReadLine());
                ptb2 pt = new ptb2(a255, b255, c255);

                double delta = pt.delta(a255, b255, c255);
                int check255 = pt.nghiem(delta);
                if (check255 < 0)
                {
                    Console.WriteLine("Pt vo nghiem");
                }
                else if (check255 == 0)
                {
                    double x = -b255 / (2 * a255);
                    Console.WriteLine("pt co nghiem kep: ", x);
                }
                else
                {
                    double x1 = (-b255 - Math.Sqrt(delta)) / (2 * a255);
                    double x2 = (-b255 + Math.Sqrt(delta)) / (2 * a255);

                    Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
                }
            }
        }

        class ptb2
        {
            private double a255;
            private double b255;
            private double c255;

            public ptb2()
            {
            }

            public ptb2(double a255, double b255, double c255)
            {
                A = a255;
                B = b255;
                C = c255;
            }

            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public double delta(double a255, double b255, double c255)
            {
                return b255 * b255 - 4 * a255 * c255;
            }

            public int nghiem(double delta255)
            {
                if (delta255 < 0)
                {
                    return -1;
                }
                else if (delta255 == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }

