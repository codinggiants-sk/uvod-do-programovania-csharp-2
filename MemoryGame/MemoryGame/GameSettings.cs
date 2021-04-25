using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    //class that stores all game settings
    class GameSettings
    {
        //game settings
        public int GameTime;
        public int DisplayTime;
        public int MaxPoints;
        public int Rows;
        public int Cols;
        public int Side;
        public int CurrentPoints;

        public string LogoFile = $@"{AppDomain.CurrentDomain.BaseDirectory}\images\logo.jpg";
        public string ImagesFolder = $@"{AppDomain.CurrentDomain.BaseDirectory}\images\cards";

        public GameSettings()
        {
            InitialSettings();
        }

        //method that set initial game parameters
        public void InitialSettings()
        {
            DisplayTime = 5;
            GameTime = 60;
            MaxPoints = 0;
            // 6 rows x 4 columns = 24 cards, so it is required that 12 different pictures are in folder with images
            Rows = 6;
            Cols = 4;
            Side = 150;
            CurrentPoints = 0;
        }
    }
}
