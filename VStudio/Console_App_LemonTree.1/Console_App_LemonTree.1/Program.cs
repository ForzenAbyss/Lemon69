using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private float mark;
        private string email;

        public Student()
        {
            id = 1;
            name = "noname";
            age = 18;
            mark = 45.5f;
            email = "noname@gmail.com";
        }

        public Student(int id, string name, int age, float mark, string email)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.mark = mark;
            this.email = email;
        }

        ~Student()
        {
            Console.WriteLine("Deleted!");
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Display()
        {
            Console.WriteLine("\nId: " + id);
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
            Console.WriteLine("\nMark: " + mark);
            Console.WriteLine("\nEmail: " + email);
        }
    }
}