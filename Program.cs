using System;
using System.Collections.Generic;

namespace _24._03._2023
{
    class Program
    {
        abstract class Component
        {
            public string Name_product;
            public int Count_Product;
            public int Price_Product;

            public Component(string Np, int CP, int PP)
            {
                Name_product = Np;
                Count_Product = CP;
                Price_Product = PP;
            }

            public abstract void Add(Component component);
            public abstract void Show();

        }
        class Box : Component
        {
            List<Component> list = new List<Component>();

            public Box(string Np, int CP, int PP):base(Np,CP,PP)
            {

            }

            public override void Add(Component component)
            {
                list.Add(component);
            }

            public override void Show()
            {
                Console.WriteLine($"Name_Product: {Name_product}\nCount_Product: {Count_Product}\nPrice_Product: {Price_Product}\n");
            }
        }
        class Leaf:Component
        {
            public Leaf(string Np, int CP, int PP) : base(Np, CP, PP)
            {

            }

            public override void Show()
            {
                Console.WriteLine($"Name_Product{Name_product}\nCount_Product{Count_Product}\nPrice_Product{Price_Product}\n");
            }

            public override void Add(Component component)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Component component = new Box("MaC",2,1300);
            Component leaf = new Leaf("MaC", 2, 1300);
            component.Add(leaf);
            component.Show();
        }
    }
}
