using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNameCheck
{
    class Employee
    {
        public Employee(string position)
        {
            this.Position = position;
            TotalCount++;
            GroupNo = Convert.ToString(Position[0]).ToUpper() + Convert.ToString(Position[1]).ToUpper() + Convert.ToString(No);
        }

        public static int TotalCount = 1000;

        public string Position;

        private string _fullName;
        public string FullName {
            get => _fullName;
               set
            {
                if (!value.HasDigit())
                {
                    this._fullName = value;
                }
            }
        }

        public string GroupNo;
    }
}
