﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Directions
    {
        // this is a enum class called Directions
        // we are using enum because its easier to classify the directions
        // for this game

        Left,
        Right,
        Up,
        Down
    };

    class Settings
    {
        public static int Width { get; set; } // set the width as int
        public static int Height { get; set; } // set the height as int
        public static int Speed { get; set; } // set the speed as int
        public static int Score { get; set; } // set the score as int
        public static int Points { get; set; } // set the points as int
        public static bool GameOver { get; set; } // set the game over as Boolean
        public static Directions direction { get; set; } // set the direction as the class we mentioned above

        public Settings()
        {
            // this is the default settings function
            Width = 16; // set the width to 16
            //Width = width; // set the width to 16
            Height = 16; // set the height to 16
            //Height = height; // set the height to 16
            Speed = 20; // set the speed to 20
            //Speed = speed; // set the speed to 20
            Score = 0; // set the score to 0
            Points = 100; // set points to 100
            GameOver = false; // set game over to false
            direction = Directions.Down; // the default direction will be down
        }
    }
}