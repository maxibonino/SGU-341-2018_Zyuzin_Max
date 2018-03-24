using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Checker
    {
        private static bool IsValidLine(string line)
        {
            foreach (char symbol in line)
            {
                if (!Char.IsLetter(symbol))
                    return false;
            }

            return !String.IsNullOrEmpty(line);
        }
        public static void CheckName(string name)
        {
            if (!IsValidLine(name))
            {
                throw new ArgumentException("Invalid name");
            }
        }

        public static void CheckSurname(string surname)
        {
            if (!IsValidLine(surname))
            {
                throw new ArgumentException("Invalid surname");
            }
        }

        public static void CheckPatronymic(string patronymic)
        {
            if (!IsValidLine(patronymic))
            {
                throw new ArgumentException("Invalid patronymic");
            }
        }

        public static void CheckBirthDate(string birthDate)
        {
            DateTime date;

            if (!DateTime.TryParse(birthDate, out date))
            {
                throw new ArgumentException("Invalid birth date");
            }
        }

        public static void Position(string position)
        {
            if (!IsValidLine(position))
            {
                throw new ArgumentException("Invalid position");
            }
        }
    }
}