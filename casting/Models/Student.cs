using System;

namespace casting.Models
{
    class

        Student : Person
    {
        private float _point;
        public float Point
        {
            get => _point;
            set
            {
                if (value >= 0)
                {
                    _point = value;
                }
            }
        }
        public Student(string Name, String Surname, float Point, int Age) : base(Name, Surname, Age)
        {

            this.Point = Point;
        }
        public override string ShowInfo()
        {
            return $"ID: {ID} \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nPoint: {Point}";
        }
        public static bool operator >(Student st1, Student st2)
        {
            return st1.Point > st2.Point;
        }
        public static bool operator <(Student st1, Student st2)
        {
            return st1.Point < st2.Point;
        }

    }
}
