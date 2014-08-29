using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeClone
{
    class Map
    {
        #region Attributes region
        
        public readonly int width;
        public readonly int heigth;

        private Cell[] buffer;

        #endregion

        #region C'tor region

        public Map(int w, int h)
        {
            this.width = w;
            this.heigth = h;

            buffer = new Cell[width * heigth];

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    buffer[(i * heigth) + j] = new Cell(j, i);
                }
            }

        }

        #endregion

        #region Methos region

        public Cell getCell (int x, int y)
        {
            return   buffer[(y * heigth) + x];
        }

        #endregion
    }
}
