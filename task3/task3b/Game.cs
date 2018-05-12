using System;
using task3b.GameObjects.Heroes;
using task3b.GameObjects.Bonuses;
using task3b.GameObjects.Obstacles;
using task3b.GameObjects;

namespace task3b
{
    public class Game
    {
        private AbstractHero player;
        public Game()
        {
            Player = new Human(0, 0);
            Bonus b = new HealthBonus(3, 3);

            Field f = new Field(20, 40);

            f.AddBonus(b);
            f.AddEnemy(new Bear(15, 16));
            f.AddEnemy(new Wolf(13, 12));
            f.AddBonus(new ArmorBonus(7, 4));
            //f.AddObstacle(new Stone());

            f.SetStartHeroPosition(Player);
        }

        public AbstractHero Player
        {
            get => player;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                else
                    player = value;
            }
        }
    }
}
