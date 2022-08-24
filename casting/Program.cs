using casting.Models;
using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tunar = new Student("Tunar", "Namazov", 100, 21);
            Person Ulvi = new Teacher("Ulvi", "Abdullazada", 5000, 22);
            Person Leman = new Student("Leman", "Yaqubova", 100, 19);
            GroupMate P326 = new GroupMate();
            Console.WriteLine(Tunar.ShowInfo());

            
        }
      
}
    }

