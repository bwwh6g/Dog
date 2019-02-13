using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dogs puppy = new Dogs("Bob", "Rick", 1, Dogs.Gender.Male);
            puppy.Bark(3);
            Console.Out.WriteLine(puppy.GetTag());
        }
    }

    public class Dogs
    {
        public String name, owner, message;
        public int age;
        public Gender gender;
        public enum Gender
        {
            Male,
            Female
        }

        public Dogs(String name,String owner,int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
            
        }
        public void Bark(int numOfBarks)
        {
            for (int i = 1; i > numOfBarks; i++)
            {
                Console.Out.Write("Woof!");
            }
        }

        public String GetTag()
        {
            if(gender == Gender.Male)
            {
                if(age == 1)
                {
                    message = ("If lost, call " + owner + ". His name is " + name + " he is " + age + " year old.");
                    return message;
                }
                message = ("If lost, call " + owner + ". His name is " + name + " he is " + age + " years old.");
                return message;
            }
            else
            {
                if (age == 1)
                {
                    message = ("If lost, call " + owner + ". Her name is " + name + " she is " + age + " year old.");
                    return message;
                }
                message = ("If lost, call " + owner + ". Her name is " + name + " she is " + age + " years old.");
                return message;
            }
            

        }
    }
}
