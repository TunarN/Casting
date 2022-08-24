using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    class GroupMate
    {
        private Student[] _students;
        public GroupMate()
        {
            _students = new Student[0];
        }
        public GroupMate(int length)
        {
            _students = new Student[length];
        }

        public Student this[int index]
        {
            get
            {
                if (index < _students.Length)
                {
                    return _students[index];
                }
                throw new Exception("Please input Correctly");
               
            }
            set
            {
                if (index < _students.Length)
                {
                    _students[index] = value;
                }
                throw new Exception("Please input correctly");
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                for (int l = i + 1; l < _students.Length; l++)
                {
                    if (_students[i] < _students[l])       
                    {
                        Student temp = _students[i];
                        _students[i] = _students[l];
                        _students[l]= temp;
                    }
                }
            }
        }
    }
}
