using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Computer[] c = new Computer[3];
            c[0] = new Computer();
            c[0].xinghao = "computer01";
            c[0].time = "2019-8-7";
            c[1] = new Computer();
            c[1].xinghao = "computer02";
            c[1].time = "2019-8-8";
            c[2] = new Computer();
            c[2].xinghao = "computer03";
            c[2].time = "2019-8-9";
            for (int i = 0; i < c.Length; i++)
            {
                c[i].outPut();
                a.newId(c[i]);
            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < c.Length; i++)
            {
                c[i].outPut();
            }

                Console.ReadLine();
        }
    }

    class Computer
    {
        public string xinghao;
        public string id;
        public string time;
        public void outPut()
        {
            Console.WriteLine(xinghao+"\t"+id+"\t"+time);
        }
    }

    class A
    {
        public void newId(Computer c)
        {
            string id = c.xinghao + "-" + new Random().Next(1000, 9999);
            c.id = id;
        }





        public void tiFen(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] += 10;
                if (num[i] > 100)
                {
                    num[i] = 100;
                }
            }
        }
        public void show(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
