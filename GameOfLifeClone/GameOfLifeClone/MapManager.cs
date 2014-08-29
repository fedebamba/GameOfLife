using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeClone
{
    class MapManager
    {
        #region Attributes region

        private Map map;

        #endregion

        #region C'tor region

        public MapManager(Map _map)
        {
            this.map = _map;
        }

        #endregion

        #region Methods region

        public void updateNextGenState()
        {
            for (int y = 0; y < map.heigth; y++)
            {
                for (int x = 0; x < map.width; x++)
                {
                    Cell cell = map.getCell(x, y);

                    if (cell.isAlive)
                    {
                        int neighbours = findNeighboursAlive(cell);
                        if (neighbours < 2 || neighbours == 4)
                            cell.isAliveNextGen = false;
                    }
                    else
                    {
                        if (findNeighboursAlive(cell) == 3)
                            cell.isAliveNextGen = true;
                    }
                }
            }


        } //aggiorna lo stato futuro di ogni cella

        public void updateCells()
        {
            for (int y = 0; y < map.heigth; y++)
            {
                for (int x = 0; x < map.width; x++)
                {
                    Cell cell = map.getCell(x, y);

                    if (cell.isAlive != cell.isAliveNextGen)
                        cell.updateState();
                }
            }
        } //aggiorna lo stato delle celle con lo stato futuro
        
        private int findNeighboursAlive(Cell cell)
        {   
            int neighbours = 0;

            if (cell.x > 0 && map.getCell(cell.x-1, cell.y).isAlive)
                neighbours++;

            if (cell.x < map.width - 1 && map.getCell(cell.x + 1, cell.y).isAlive)
                neighbours++;

            if (cell.y > 0 && map.getCell(cell.x, cell.y - 1).isAlive)
                neighbours++;

            if (cell.y < map.heigth && map.getCell(cell.x, cell.y + 1).isAlive)
                neighbours++;

            return neighbours;
        } //restituisce il numero di celle adiacenti vive

        #endregion
    }
}
