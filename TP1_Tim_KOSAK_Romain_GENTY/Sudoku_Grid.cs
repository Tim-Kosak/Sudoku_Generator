using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Sudoku_Grid
    {
        private short[,] grid;
        private short grid_size = 0;


        public Sudoku_Grid(short size)
        {
            grid = new short[size, size];
            grid_size = size;
        }

        public override String ToString()
        {
            String makeLine()
            {
                String foo = "";
                for (short i = 0; i < 4 * grid_size / 3 + 1; i++) foo += "- ";
                return foo;
            }


            String res = makeLine() + "\n";
            for (short i = 0; i < grid_size; i++)
            {
                res += "| ";
                for (short y = 0; y < grid_size; y++)
                {
                    res += grid[i, y] + " ";
                    if ((y + 1) % 3 == 0) res += "| ";
                }
                res += "\n";
                if ((i + 1) % 3 == 0)
                {
                    res += makeLine();
                    res += "\n";
                }
            }
            return res;
        }

        // Grid manipulations

        public short[,] Grid
        {
            get => grid;
        }

        public bool insertIntoGrid(short nb, short row, short column)
        {
            if (canBeInsert(nb, row, column))
            {
                grid[row, column] = nb;
                return true;
            }
            return false;
        }

        public bool canBeInsert(short nb, short row, short column)
        {
            if (nb >= 0 && nb <= grid_size && !existsInRow(nb, row) && !existsInColumn(nb, column) && !existsInBox(nb, row, column)) return true;
            else return false;
        }

        private bool existsInRow(short nb, short row)
        {
            for (short i = 0; i < grid_size; i++)
                if (grid[row, i] == nb) return true;
            return false;
        }
        private bool existsInColumn(short nb, short column)
        {
            for (short i = 0; i < grid_size; i++)
                if (grid[i, column] == nb) return true;
            return false;
        }
        private bool existsInBox(short nb, short caseX, short caseY)
        {
            for (short i = 0; i < Math.Sqrt(grid_size); i++)
            {
                for (short j = 0; j < Math.Sqrt(grid_size); j++)
                {
                    if (nb == grid[3 * (caseX / 3) + i, 3 * (caseY / 3) + j]) return true;
                }
            }
            return false;
        }

        public List<short> getPossibilitiesFor(short row, short column)
        {
            List<short> res = new List<short>();

            if (grid[row, column] != 0) return res;

            for (short i = 1; i <= grid_size; i++)
            {
                if (canBeInsert(i, row, column)) res.Add(i);
            }

            return res;
        }

        public short getEmptyCaseNumber()
        {
            short res = 0;
            for (short i = 0; i < grid_size; i++)
            {
                for (short j = 0; j < grid_size; j++)
                {
                    if (grid[i, j] == 0) res++;
                }
            }
            return res;
        }

        private bool getNextEmptyCaseCoords(ref short row, ref short column)
        {
            for (short i = 0; i < grid_size; i++)
            {
                for (short j = 0; j < grid_size; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        row = i; column = j;
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool solveWithBacktracking()
        {
            Sudoku_Grid buff = this;
            bool res = solveWithBacktrackingNode(ref buff, getEmptyCaseNumber());
            grid = buff.grid;
            return res;
        }

        private static bool solveWithBacktrackingNode(ref Sudoku_Grid p_grid, short emptyCase)
        {
            
            for(short i = 0; i < p_grid.grid_size; i++)
            {
                for (short j = 0; j < p_grid.grid_size; j++)
                {
                    List<short> curr_poss = p_grid.getPossibilitiesFor(i, j);
                    if (curr_poss.Count == 1)
                    {
                        p_grid.insertIntoGrid(curr_poss[0], i, j);
                        emptyCase--;
                    }
                }
            }
            
            if (emptyCase == 0)
                return true; //If there is no more empty Case

            short next_row = -1, next_column = -1;
            if (!p_grid.getNextEmptyCaseCoords(ref next_row, ref next_column)) return false; //Get the coords of da next empty case
            List<short> poss = p_grid.getPossibilitiesFor(next_row, next_column); //Determine the possibilities for the case considered earlier.

            if (poss.Count == 0) return false; //If there is no possibility at all, that is solutionless branch.

            short nbIter = (short)poss.Count;
            for (short i = 0; i < nbIter; i++) // For each possibily, we create a new fork with each possibility for the empty case considered
            {

                Sudoku_Grid possible_grid = new Sudoku_Grid(p_grid.grid_size); //Create the next sudoku_grid
                Array.Copy(p_grid.grid, possible_grid.grid, p_grid.grid.Length); //Make a deep copy of the array

                Random rand = new Random(); //Create a random (To avoid getting da same solution at each starting session.
                short cursor = (short)rand.Next(0, poss.Count);
                possible_grid.insertIntoGrid(poss[cursor], next_row, next_column); //Get the possiblity with da random and insert it into the grid
                poss.RemoveAt(cursor); //Remove the used possibility

                if (solveWithBacktrackingNode(ref possible_grid, (short)(emptyCase - 1)))
                {
                    p_grid = possible_grid; //Change the grid if success
                    return true;
                }
            }

            return false;
        }

        public void removeUnnecessaryCases()
        {
            for (short i = 0; i < grid_size; i++)
            {
                for (short j = 0; j < grid_size; j++)
                {
                    short back = grid[i, j];
                    grid[i, j] = 0;
                    if (getPossibilitiesFor(i,j).Count != 1)
                    {
                        grid[i, j] = back;
                    }
                }
            }
        }
    }
}