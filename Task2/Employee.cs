using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Employee : User
    {
        private string position;
        public Employee(string surname, string name, string patronymic, string date, int experience, string position)
            :base(surname, name, patronymic, date)
        {
            Experience = experience;
            Position = position;
        }

        public int Experience { get; set; }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                Checker.Position(value);
                position = value;
            }
        }

        public override string ToString()
        {
            string userInfo = base.ToString();
            return  $"{userInfo}Стаж: {Experience}{Environment.NewLine}Должность: {Position}{Environment.NewLine}";
        }
    }
}