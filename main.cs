using System;

namespace some {
    class Person {
        public string name = "None";
        public int age = 0;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public virtual void Greet() {
            Console.WriteLine("I'm " + name + ", " + age + " years old.");
        }
    }
    class Student : Person {
        private string className;
        public Student(string name, int age) : base(name, age) {
            this.name = name;
            this.age = age;
        }

        public string ClassName {
            get {return className;}
            set {className = value;}
        }
        
        public override void Greet() {
            Console.WriteLine("I'm " + name + ", " + age + " years old, student of " + className + ".");
        }
    }   
    class Teacher : Person {
        private string subject;

        public Teacher(string name, int age) :base(name, age) {
            this.name = name;
            this.age = age;
        }

        public string Subject {
            get {return subject;} 
            set {subject = value;}
        }

        public override void Greet() {
            Console.WriteLine("I'm " + name + ", " + age + " years old, teacher of " + subject + ".");
        }
    }
    class Program {
        public void Input(string choice) {
            string name = "None";
            char pick = 'y';
            int age = 0;

            while (pick == 'y') {
                Console.WriteLine("What would you do with that thing my friend");
                choice = Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                age = int.Parse(Console.ReadLine());

                if(choice.ToLower() == "person" || choice.ToLower() == "p") {
                    Person per1 = new Person(name, age);
                    per1.Greet();
                }
                else if(choice.ToLower() == "teacher" || choice.ToLower() == "t") {
                    Teacher per1 = new Teacher(name, age);
                    Console.WriteLine("Enter the subject: ");
                    per1.Subject = Console.ReadLine();
                    per1.Greet();
                }
                else if(choice.ToLower() == "student" || choice.ToLower() == "s") {
                    Student per1 = new Student(name, age);
                    Console.WriteLine("Enter the class name: ");
                    per1.ClassName = Console.ReadLine();
                    per1.Greet();
                }

                Console.WriteLine("Do you want to continue? (y for yes, n for no)");
                pick = char.Parse(Console.ReadLine());
            }
            
            // Recursion
            /* if (pick == 'y') {
                Program prog = new Program();
                prog.Input(choice);
            } */
        }
        static void Main(string[] args) {
            string choice = "sada";                    
            Program prog = new Program();
            prog.Input(choice);
        }
    }
}
