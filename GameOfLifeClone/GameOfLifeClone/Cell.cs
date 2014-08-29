using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeClone
{
    class Cell
    {
        #region Attributes region

        public bool isAlive { get; private set; }
        public bool isAliveNextGen;

        public int x { get; private set; }
        public int y { get; private set; }

        private Map map; // forse mapmanager, forse no

        #endregion 

        #region C'tor region

        public Cell(int w, int h)
        {
            this.x = w;
            this.y = h;

            isAlive = false;
            isAliveNextGen = false;
        }

        #endregion

        #region Methods region

        public void updateState()
        {
            isAlive = isAliveNextGen;
        }  

        #endregion



    }
}
