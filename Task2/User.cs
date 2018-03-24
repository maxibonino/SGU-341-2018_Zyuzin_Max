using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private string birthDate;
        public User(string surname, string name, string patronymic, string birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birthDate;
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                Checker.CheckSurname(value);
                surname = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Checker.CheckName(value);
                name = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                Checker.CheckPatronymic(value);
                patronymic = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                Checker.CheckBirthDate(value);
                birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                return GetAge(birthDate);
            }

        }

        public override string ToString()
        {
            return $"Фамилия: {Surname}{Environment.NewLine}Имя: {Name}{Environment.NewLine}Отчество: {Patronymic}{Environment.NewLine}Возраст: {Age}{Environment.NewLine}День рождения: {BirthDate}{Environment.NewLine}";
        }
        private int GetAge(string birthDate)
        {
            DateTime date = DateTime.Parse(birthDate);

            if (DateTime.Today.Month > date.Month)
            {
                return DateTime.Today.Year - date.Year;
            }

            return DateTime.Today.Year - date.Year - 1;
        }
    }
}