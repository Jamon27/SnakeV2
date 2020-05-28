using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeV2
{
    class SnakeClass
    {
        private int widthOfSnake { get; set; }
        private int lenghtOfSnake { get; set; }
        private int startingPosition { get; set; }

        public SnakeClass(int width, int lenght, int startingPosition)
        {
            widthOfSnake = width;
            lenghtOfSnake = lenght;
            this.startingPosition = startingPosition;
        }

       // Brush colorOfSnake = Color.Black;

    }
}
