using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    public class Meth3InClass
    {
        public void Meth3InCls(double a, double b, double c, ref string X1, ref string X2)
        {  //Решение в классе
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d == 0)
            {   //Дискриминант равен 0
                x1 = (-b / (2 * a));
                if (x1 >= 0.01 || x1 <= -0.01)
                    X1 = String.Format("{0:0.##}", x1);
                else
                    X1 = String.Format("{0:G1}", x1);
                X2 = X1;
            }
            else if (d > 0)
            {  //Дискриминант больше 0
                x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                if (x1 >= 0.01 || x1 <= -0.01)
                    X1 = String.Format("{0:0.##}", x1);
                else
                    X1 = String.Format("{0:G1}", x1);
                if (x2 >= 0.01 || x2 <= -0.01)
                    X2 = String.Format("{0:0.##}", x2);
                else
                    X2 = String.Format("{0:G1}", x2);
            }
            else
            {  //Дискриминант меньше 0
                double part1, part2;
                d *= -1;
                part1 = -1 * b / (2 * a);
                part2 = Math.Sqrt(d) / (2 * a);
                if (part2 < 0)
                    part2 *= -1;
                X1 = String.Format("{0:0.##}", part1) + "-" + String.Format("{0:0.##}", part2) + "i";
                X2 = String.Format("{0:0.##}", part1) + "+" + String.Format("{0:0.##}", part2) + "i";
            }
        }
    }
}
