using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Fsudoku : Form
    {
        private Sudoku_Grid g; ///Pointeur to the current sudoku Grid
        private short[,] currentGrid; ///variable to stock the solution of the current grid
        

        public Fsudoku()
        {
            InitializeComponent();
            
            //Modification of the DataGridView Seting in order to have 9 lines and columns, with the value in the middle of the cell
            DG_Sudoku.ColumnCount = 9;
            DG_Sudoku.Rows.Add(9);
            DG_Sudoku.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //insertion of the 9 lines and columns in the DataGridView
            for (int i = 0; i < 9; i++) 
            {
                DataGridViewColumn column = DG_Sudoku.Columns[i];
                column.Width = (int)(DG_Sudoku.Width / 9f);//Every Column is 1/9 time DatagridView width wide
                DataGridViewRow row = DG_Sudoku.Rows[i];
                row.Height = (int)(DG_Sudoku.Height / 9f);//same pprocess for the lines
            }
            
            //From here, the for statements modifies the back color of every cell, in order to have a 3*3 bloc pattern
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++)
                {
                    DG_Sudoku.Rows[i].Cells[j].Style.BackColor = Color.LightYellow;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    DG_Sudoku.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    DG_Sudoku.Rows[j].Cells[i].Style.BackColor = Color.Orange;
                }
            }

            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    DG_Sudoku.Rows[i].Cells[j].Style.BackColor = Color.LightYellow;
                }
            }
        }

        private void BT_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            deleteGrid();
        }

        private bool deleteGrid() ///reset the grid to a blank grid
        {
            if((g!= null) && (currentGrid != null)){ //if the grid has not benn deleted before
                DialogResult res = MessageBox.Show(this, "Voulez-vous vraiment supprimer cette Grille ? Vous n'y aurez plus accès", "Suppression de la grille", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) //if the user decided to erase the grid
                {
                    for(int i = 0; i < 9; i++) //take every DataGridView cell and set it to blank
                    {
                        for(int j = 0; j<9; j++)
                        {
                            DG_Sudoku.Rows[i].Cells[j].Value = null;
                        }
                    }
                    g = null; //erase the current grid
                    currentGrid = null; //erase the current grid's solution
                }
                return res == DialogResult.Yes; //return if the user decided to erase the grid or not
            }
            else
            {
                return true; //return that the grid has already been deleted
            }
        }

        private void BT_start_Click(object sender, EventArgs e)///generate a new grid
        {
            if (deleteGrid()) //if the user has allowed to delete the current grid (or if it was already deleted)
            {
                g = new Sudoku_Grid(9); //this and the next line create a complete grid
                g.solveWithBacktracking();
                currentGrid = new short[9, 9];
                Array.Copy(g.Grid, currentGrid, 81); //we save the solution
                g.removeUnnecessaryCases(); //we make holes in the grid
                Show_Grid(g.Grid);
            }
           
            
        }

        private void Show_Grid(short[,] gr) ///Show the grid in parameters in the DataGridView
        {


            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    String charToAdd = gr[i, j].ToString();
                    if (charToAdd.Equals("0")) //Don't show the 0 but holes in the grid
                    {
                        DG_Sudoku.Rows[i].Cells[j].Value =" ";
                    }
                    else
                    {
                        DG_Sudoku.Rows[i].Cells[j].Value = charToAdd;
                    }
                }
            }
        }

        private void BT_show_Click(object sender, EventArgs e) ///show the solution on the DataViewGrid
        {
            if (g!=null)
            {
                Show_Grid(currentGrid);
            }
            else
            {
                MessageBox.Show("La grille n'a pas été générée ou a été effacée !", "Erreur Affichage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_maskSolution_Click(object sender, EventArgs e) ///show the grid with holes in the DataViewGrid
        {
            if (g != null)
            {
                Show_Grid(g.Grid);
            }
            else
            {
                MessageBox.Show("La grille n'a pas été générée ou a été effacée!", "Erreur Affichage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
