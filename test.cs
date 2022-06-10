using System;

class Person {
    public string name;
    public int age;

    public Person (string name, int age) {
        this.name = name;
        this.age = age;
    }

    public virtual void Greet() {
        Console.WriteLine("asdasdasdasdasd");
    }
}

class Student : Person {
    private string className;

    public Student (string name, int age) : base(name, age) {
        this.name = name;
        this.age = age;
    }

    public override void Greet() {
        Console.WriteLine("asdasd");
    }
}

class Teacher : Person {
    private string subject;

    public Teacher (string name, int age) : base(name, age) {
        this.name = name;
        this.age = age;
    }

    public override void Greet() {
        ConSole.WriteLine("fghfghgfhfgh");
    }
}
class Program {
    static void Main(string[] args) {
        Person per = new Person("Henry", 20);
        per.Greet();
    }
}