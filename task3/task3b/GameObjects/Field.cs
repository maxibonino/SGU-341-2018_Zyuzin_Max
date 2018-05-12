using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3b.GameObjects.Bonuses;
using task3b.GameObjects.Heroes;
using task3b.GameObjects.Obstacles;

namespace task3b.GameObjects
{
    public class Field
    {
        private int width;
        private int height;
        private char[,] field;
        public Field()
        {

        }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;

            field = new char[Width, Height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    field[i, j] = '.';
                }
            }
        }

        public void AddBonus(Bonus bonus)
        {
            if (bonus is AppearanceBonus)
            {
                field[bonus.PositionX, bonus.PositionY] = 'P';
            }
            else if (bonus is ArmorBonus)
            {
                field[bonus.PositionX, bonus.PositionY] = 'A';
            }
            else if (bonus is HealthBonus)
            {
                field[bonus.PositionX, bonus.PositionY] = 'H';
            }
            else if (bonus is SpeedBonus)
            {
                field[bonus.PositionX, bonus.PositionY] = 'S';
            }
        }

        public void AddObstacle(GameObject obstacle)
        {
            if (obstacle is Hole)
            {
                field[obstacle.PositionX, obstacle.PositionY] = 'o';
            }
            else if (obstacle is Stone)
            {
                field[obstacle.PositionX, obstacle.PositionY] = 'D';
            }
            else if (obstacle is Tree)
            {
                field[obstacle.PositionX, obstacle.PositionY] = '#';
            }
        }

        public void AddEnemy(AbstractHero hero)
        {
            if (hero is Elf)
            {
                field[hero.PositionX, hero.PositionY] = 'E';
            }
            else if (hero is Bear)
            {
                field[hero.PositionX, hero.PositionY] = 'B';
            }
            else if (hero is Wolf)
            {
                field[hero.PositionX, hero.PositionY] = 'W';
            }
            else if (hero is Human)
            {
                field[hero.PositionX, hero.PositionY] = 'U';
            }
        }

        public void SetStartHeroPosition(AbstractHero hero)
        {
            field[hero.PositionX, hero.PositionY] = '%';
        }

        public void ShowField()
        {
            Console.Clear();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    switch (field[i, j])
                    {
                        case '.':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '%':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'D':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 'o':
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 'E':
                        case 'B':
                        case 'W':
                        case 'U':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                            //PAHS
                    }
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int Width
        {
            get => width;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Width must be a positive number!");
                else
                    width = value;
            }
        }
        public int Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Height must be a positive number!");
                else
                    height = value;
            }
        }

    }
}
