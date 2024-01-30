using System;
using System.Collections.Generic;   // when using List

namespace CSharp {
    class Program {
        
        class Person {
            int my_id;
            public Person(int id)
            {
                this.my_id = id;
            }
        }

        class Mage: Person {

            public Mage(int id) : base(id)
            {
                
            }

        }

        // static void ChooseClass() {
        //     Console.WriteLine("직업을 선택하세요호!");
        //     Console.WriteLine("[1] 궁수");
        //     Console.WriteLine("[2] 전사");
        //     Console.WriteLine("[3] 마법사");

        //     string input = Console.ReadLine();
        // }

        public class Animal {
            public virtual void Sound() {
                Console.WriteLine("부모");
            }
        }

        // public class Lion: Animal {
        //     public virtual void Sound() {
        //         Console.WriteLine("자식");
        //     }
        // }

        // public class Lion: Animal {
        //     public new void Sound() {
        //         Console.WriteLine("자식");
        //     }
        // }

        public class Lion: Animal {
            public sealed override void Sound() {
                base.Sound();
                Console.WriteLine("자식");
            }
        }

        static void Main(String[] args) {
            // Mage mage1 = new Mage();
            // Person person1 = new Person();
            // Mage mage2 = (Mage)person1;
            // Person person2 = mage1;

            Lion lion = new Lion();
            ActSound(lion);
            // animal.Sound();

            int[] array1 = new int[10];
            int[] array2 = {1, 2, 4};
            int[] array3 = new int[3] {1, 2, 4};

            int[,] two_d_array = new int[2,3] {{1,2,3}, {4,5,6}};
            two_d_array[1,1] = 1000;

            two_d_array.GetLength(1); // 2
            two_d_array.GetLength(0); // 3

            var variable = 3;   // type 안정해진 경우

            int[][] variable_array = new int[3][];
            variable_array[0] = new int[5];
            variable_array[1] = new int[2];
            variable_array[2] = new int[3];

            List<int> list = new List<int>();
            list.Add(100);
            list.Insert(0,99);
            Console.WriteLine(list.Count);
            list.Remove(99);
            list.RemoveAt(0);
            list.Clear();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            string str;
            dict.TryGetValue(7, out str);

        }

        static void ActSound(Animal animal) {
            animal.Sound();
        }
    }
}