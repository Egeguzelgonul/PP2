using System;

namespace Ex7
{
    class Animal
    {
        public string name;
        public string weight;
        public string age;
        public string happiness;

        public Animal() { }

        public Animal(string name, string happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }
        public void Print()
        {
            Console.WriteLine(this.name + " " + weight + " " + age + " " + happiness);
        }

        public void Print(int k)
        {

        }

        public override string ToString()
        {
            return name + " " + weight + " " + age + " " + happiness;
        }

    }

    class Program
    {
        static void F1()
        {
            Animal st1 = new Animal();
            st1.name = "Doggo";
            st1.age = "8";
            st1.weight = "2";
            st1.happiness = "99";

            Animal st2 = new Animal();

            st1.Print();
            st2.Print();

        }
        static void F2()
        {
            int n = int.Parse(Console.ReadLine());
            Animal[] a = new Animal[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string name = arr[0];
                string weight = arr[1];
                string age = arr[2];
                string happiness = arr[3];
                a[i] = new Animal(name, happiness);
            }


            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i]);
        }

        static void F3()
        {
            Animal st1 = new Animal();
            st1.name = "aaa";
            st1.weight = "bbb";
            st1.age = "2";
            st1.happiness = "7";

            Animal st2 = new Animal("ccc", "ddd");
            st2.happiness = "0";

            Animal st3 = new Animal("qqq", "www");
        }
        static void Main(string[] args)
        {
            F2();
        }
    }
}