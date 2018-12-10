/// CS155 Final Project Exercise No.: FinalProject 
/// File Name:          Tetris.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// Tetris represents the essential part of the game
/// which contains definition of tetris blocks that are
/// manipulated in a given tetris board definition.
/// This class also contain essential methods such as
/// reset spawn move and paint next block.

using System;
using System.Windows.Controls;

namespace FinalProject
{
    class Tetris
    {
        //Default tetris board definition
        public const int ROWS = 20;
        public const int COLUMNS = ROWS / 2;
        //Tetris blocks map definition.
        private static readonly int[,] BLOCK_I = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 0, 3 }};
        private static readonly int[,] BLOCK_J = { { 0, 1 }, { 1, 1 }, { 2, 1 }, { 2, 0 }};
        private static readonly int[,] BLOCK_L = { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 2, 1 }};
        private static readonly int[,] BLOCK_O = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 }};
        private static readonly int[,] BLOCK_S = { { 0, 1 }, { 0, 2 }, { 1, 0 }, { 1, 1 }};
        private static readonly int[,] BLOCK_T = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 1 }};
        private static readonly int[,] BLOCK_Z = { { 0, 0 }, { 0, 1 }, { 1, 1 }, { 1, 2 }};

        //Definition of blocks to be manipulated throwout the game
        private TetrisBlock currentBlock;
        private TetrisBlock nextBlock;

        //Definition of the views components.
        private Grid boardGrids;
        private Grid nextBlockGrids;
        private TetrisCell[,] boardCells;
        private TetrisCell[,] nextBlockCells;
        private Random randon = new Random();

        //Property: Keeps track of the number of cleared row.
        public int RowsCleared { get; set; }

        //Constructor must receive NOT null grid views for tetris board and next block.
        //This initializes all of the essential components of the game.
        //Postcondition: has not error checking: throws null pointer exception.
        public Tetris(Grid tetris_board, Grid next_block)
        {
            boardGrids = tetris_board;
            nextBlockGrids = next_block;
            boardCells = new TetrisCell[ROWS, COLUMNS];
            nextBlockCells = new TetrisCell[TetrisBlock.CELLS, TetrisBlock.CELLS];
            InitGrids();
            InitCells();
            currentBlock = generateBlock();
            nextBlock = generateBlock();
        }

        //Generates Tetris blocks with random colors.
        private TetrisBlock generateBlock()
        {
            TetrisBlock[] blocks = {
                new TetrisBlock(boardCells, BLOCK_I, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_J, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_L, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_O, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_S, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_T, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)]),
                new TetrisBlock(boardCells, BLOCK_Z, TetrisCell.COLORS[randon.Next(TetrisCell.COLORS.Length)])
            };
            return blocks[randon.Next(blocks.Length)];
        }

        //Initializes the grids views of the game
        private void InitGrids()
        {
            for (int i = 0; i < ROWS; i++)
            {
                RowDefinition rowDef = new RowDefinition();
                ColumnDefinition colDef = new ColumnDefinition();
                boardGrids.RowDefinitions.Add(rowDef);
                if (i < COLUMNS)
                {
                    boardGrids.ColumnDefinitions.Add(colDef);
                }
                if (i < TetrisBlock.CELLS)
                {
                    RowDefinition rDef = new RowDefinition();
                    ColumnDefinition cDef = new ColumnDefinition();
                    nextBlockGrids.ColumnDefinitions.Add(cDef);
                    nextBlockGrids.RowDefinitions.Add(rDef);
                }
            }
        }

        //Initializes the tetris cells of the game
        private void InitCells()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLUMNS; col++)
                {
                    boardCells[row, col] = new TetrisCell();
                    Grid.SetRow(boardCells[row, col].Cell, row);
                    Grid.SetColumn(boardCells[row, col].Cell, col);
                    boardGrids.Children.Add(boardCells[row, col].Cell);

                    if (row < TetrisBlock.CELLS && col < TetrisBlock.CELLS)
                    {
                        nextBlockCells[row, col] = new TetrisCell();
                        Grid.SetRow(nextBlockCells[row, col].Cell, row);
                        Grid.SetColumn(nextBlockCells[row, col].Cell, col);
                        nextBlockGrids.Children.Add(nextBlockCells[row, col].Cell);
                    }
                }
            }
        }

        //Moves a tetris block at the given row and column values
        //Returns true if given values result in valid block move; false otherwise
        public bool MoveBlock(int row, int col)
        {
            return currentBlock.Move(row, col);
        }

        //Rotates clockwise this tetris cell
        //Returns true of rotation lays in a valid move; false otherwise
        public bool RotateBlock()
        {
            return currentBlock.Rotate();
        }

        //Spawns a new tetris at the given row and column values
        public bool Spawn(int row, int col)
        {
            RowsCleared += clearRow();
            currentBlock = nextBlock;
            nextBlock = generateBlock();
            PaintNextBlock();
            return MoveBlock(row, col);

        }

        //Reset the game by clearing all of the current used cells in the board
        public void Reset()
        {
            foreach (TetrisCell cell in boardCells)
            {
                cell.ID = TetrisCell.DEFAULT_ID;
                cell.Cell.Fill = TetrisCell.DEFAULT_COLOR;
            }
            foreach (TetrisCell cell in nextBlockCells)
            {
                cell.ID = TetrisCell.DEFAULT_ID;
                cell.Cell.Fill = TetrisCell.DEFAULT_COLOR;
            }
            RowsCleared = 0;
        }

        //paints the next block in the next block grid definition
        public void PaintNextBlock()
        {
            int[,] currBlock = currentBlock.GetBlock();
            int[,] nextBlock = this.nextBlock.GetBlock();

            foreach (TetrisCell cell in nextBlockCells)
            {
                cell.Cell.Fill = TetrisCell.DEFAULT_COLOR;
            }
            for (int i = 0; i < TetrisBlock.CELLS; i++)
            {
                nextBlockCells[nextBlock[i, 0], nextBlock[i, 1]].Cell.Fill = this.nextBlock.BlockColor;
            }

        }

        //Checks if the given row index is full.
        //return true if all of the cell are empty not empty; false otherwise.
        public bool isRowFull(int row)
        {
            for (int i = 0; i < boardCells.GetLength(1); i++)
            {
                if (boardCells[row,i].isEmpty())
                {
                    return false;
                }
            }
            return true;
        }
        
        //Deletes the given row and pulls down the
        //rest of the rows
        public void clearRow(int row)
        {
            if (row == 0)
            {
                for (int i = 0; i < boardCells.GetLength(1); i++)
                {
                    boardCells[row, i].ID = TetrisCell.DEFAULT_ID;//  CellID(board[row][i].CELL_DEFAULT_ID);
                    boardCells[row, i].Cell.Fill = TetrisCell.DEFAULT_COLOR;//  //setCellSymbol(board[row][i].CELL_DEFAULT_SYMBOL);
                }
            }
            else if (row > 0 && row < boardCells.GetLength(0))
            {
                for (int i = row; i > 0; i--)
                {
                    for (int j = 0; j < boardCells.GetLength(1); j++)
                    {
                        boardCells[i, j].ID = boardCells[i - 1, j].ID;
                        boardCells[i, j].Cell.Fill = boardCells[i - 1, j].Cell.Fill;
                    }
                }
            }
        }

        //Deletes any row that is full; pulls down the
        //rest of the rows; and updates scores by adding
        //one  for each cleared row.
        private int clearRow()
        {
            int score = 0;
            for (int i = boardCells.GetLength(0) - 1; i >= 0; i--)
            {
                if (isRowFull(i))
                {
                    score++;
                    clearRow(i++);
                }
            }
            return score;
        }
    }
}
