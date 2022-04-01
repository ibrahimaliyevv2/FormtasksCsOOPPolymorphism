using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCount
{
    class Student
    {
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }

  
        public int No;
        public static int TotalCount;
        public string FullName;
        public string GroupNo;
      
    }
}
