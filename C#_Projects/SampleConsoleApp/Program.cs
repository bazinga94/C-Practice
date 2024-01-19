using System;

namespace CSharp {
    class Program {

        class Person {

        }

        class Mage: Person {

        }

        static void ChooseClass() {
            Console.WriteLine("직업을 선택하세요호!");
            Console.WriteLine("[1] 궁수");
            Console.WriteLine("[2] 전사");
            Console.WriteLine("[3] 마법사");

            string input = Console.ReadLine();
        }

        public class Animal {
            public virtual void Sound() {
                Console.WriteLine("부모");
            }
        }

        public class Lion: Animal {
            public virtual void Sound() {
                Console.WriteLine("자식");
            }
        }

        // public class Lion: Animal {
        //     public new void Sound() {
        //         Console.WriteLine("자식");
        //     }
        // }

        // public class Lion: Animal {
        //     public override void Sound() {
        //         Console.WriteLine("자식");
        //     }
        // }

        static void Main(String[] args) {
            // Mage mage1 = new Mage();
            // Person person1 = new Person();
            // Mage mage2 = (Mage)person1;
            // Person person2 = mage1;

            Animal animal = new Lion();
            animal.Sound();
        }
    }
}