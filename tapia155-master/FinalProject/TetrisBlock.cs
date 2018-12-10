/// CS155 Final Project Exercise No.: FinalProject 
/// File Name:          TetrisBlock.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// TetrisBlock represents tetris block 
/// composed of a group, by default, four tetris cells.

using System;
using System.Windows.Media;

namespace FinalProject
{
    class TetrisBlock
    {
        //Constant Default number of cell per block
        public const int CELLS = 4;       
        //Rotation map based on a 4 x 4 array matrix
        public static readonly int[,,] ROTATE = {
            { { 0,3}, { 1,3}, { 2,3}, { 3,3} },
            { { 0,2}, { 1,2}, { 2,2}, { 3,2} },
            { { 0,1}, { 1,1}, { 2,1}, { 3,1} },
            { { 0,0}, { 1,0}, { 2,0}, { 3,0} },};

        //instance variables
        private int[,] block;//current TetrisBlock map
        private TetrisCell[,] board;//TetrisBoard to display this Tetris block

        //TetrisBlock properties Id and color
        public int BlockID { get; set; }
        public SolidColorBrush BlockColor { get; set; }

        //TetrisBlock constructor that receives a TetrisBord and block definition: block map and block color
        //Throws block definition exception if a block is defined with more than CELLS cells of block defined
        //out of tetrisBoard bounds
        public TetrisBlock(TetrisCell[,] board, int[,] block, SolidColorBrush color)
        {
            this.board = board;
            this.block = block;
            this.BlockColor = color;
            this.BlockID = TetrisCell.GenerateID();
            CkeckBlockDef(block);
        }

        //Checks and throws exception.
        //definition of a block: 
        //number of cells = CELLS
        //and block defined in of tetrisBoard bounds
        private void CkeckBlockDef(int[,] block)
        {
            if (block == null || block.GetLength(0) > CELLS || block.GetLength(1) > 2)
            {
                throw new Exception("Invalid Tetris Block Definition: LENGTH.");
            }
            int row = block[0, 0];
            int col = block[0, 1];
            for (int i = 1; i < CELLS; i++)
            {
                row = block[i, 0] > row ? block[i, 0] : row;
                col = block[i, 1] > col ? block[i, 1] : col;
                if (row > 3 || col > 3)
                {
                    throw new Exception("Invalid Tetris Block Definition: OUT OF BOUNDS.");
                }
            }
        }

        //Paints a block with the given block map, id, and color. 
        //Postcondition: has not error checking
        private void PaintBlock(int[,] block, int id, SolidColorBrush color)
        {
            for (int i = 0; i < CELLS; i++)
            {
                board[block[i, 0], block[i, 1]].ID = id;
                board[block[i, 0], block[i, 1]].Cell.Fill = color;
            }
        }

        //Finds and returns the current row of a tetris block in its given tetrisBoard
        public int GetRow()
        {
            int row = block[0, 0];
            for (int i = 1; i < CELLS; i++)
            {
                row = block[i, 0] < row ? block[i, 0] : row;
            }
            return row;
        }

        //Finds and returns the current column of a tetris block in its given tetrisBoard
        public int GetColumn()
        {
            int col = block[0, 1];
            for (int i = 1; i < CELLS; i++)
            {
                col = block[i, 1] < col ? block[i, 1] : col;
            }
            return col;
        }

        //Returns a copy of the current block map
        public int[,] GetBlock()
        {
            int currRow = GetRow();//block current row 
            int currCol = GetColumn();//block current column 
            int[,] temp = new int[CELLS, 2];//copy of this block

            for (int i = 0; i < CELLS; i++)
            {
                temp[i, 0] = block[i, 0] - currRow;
                temp[i, 1] = block[i, 1] - currCol;
            }
            return temp;
        }

        //Returns a copy of the current block map with a offset value
        //Returns null if the given offset values are result in index out of bounds
        //Or if current cell are occupied by other tetris block
        public int[,] GetBlock(int[,] src, int moveRow, int moveCol)
        {            
            int[,] copy = new int[CELLS, 2];
            for (int i = 0; i < CELLS; i++)
            {
                int cellRow = copy[i, 0] = src[i, 0] + moveRow;
                int cellCol = copy[i, 1] = src[i, 1] + moveCol;

                if (!(cellRow >= 0 && cellCol >= 0 
                    && cellRow < board.GetLength(0) && cellCol < board.GetLength(1) 
                    && (board[cellRow, cellCol].isEmpty() || board[cellRow, cellCol].ID == BlockID)))
                {
                    return null;
                }
            }
            return copy;
        }       

        //Moves a tetris block at the given row and column values
        //Returns true if given values result in valid block move; false otherwise
        public bool Move(int row, int col)
        {
            int[,] helper;
            if ((helper = GetBlock(block, row, col)) != null)
            {
                PaintBlock(block, TetrisCell.DEFAULT_ID, TetrisCell.DEFAULT_COLOR);
                PaintBlock(helper, BlockID, BlockColor);
                block = helper;
                return true;
            }
            return false;
        }
               
        //Rotates clockwise this tetris cell
        //Returns true of rotation lays in a valid move; false otherwise
        public bool Rotate()
        {
            int currRow = GetRow();//current block row 
            int currCol = GetColumn();//current block column 
            int nextRow = board.GetLength(0);//after rotation block row 
            int nextCol = board.GetLength(1);//after rotation block column 
            int[,] rotate = new int[CELLS, 2];//rotation helper
            int[,] backup = GetBlock(block, 0, 0);//backing up in case rotation fails

            if (backup == null)//cannot rotate because of the current position
            {
                return false;
            }

            //unpainting current block temporarily
            PaintBlock(block, TetrisCell.DEFAULT_ID, TetrisCell.DEFAULT_COLOR);

            //calculating rotation using the ROTATE array map
            for (int i = 0; i < CELLS; i++)
            {
                rotate[i, 0] = ROTATE[(block[i, 0]) - currRow, (block[i, 1] - currCol), 0];
                rotate[i, 1] = ROTATE[(block[i, 0]) - currRow, (block[i, 1] - currCol), 1];
                nextRow = rotate[i, 0] < nextRow ? rotate[i, 0] : nextRow;
                nextCol = rotate[i, 1] < nextCol ? rotate[i, 1] : nextCol;                
            }

            //calculating current block position after rotating
            for (int i = 0; i < CELLS; i++)
            {
                rotate[i, 0] += (currRow - nextRow);
                rotate[i, 1] += (currCol - nextCol);
            }

            //fixing rotate out of bounds errors in row and column with three cells max error
            for (int i = 0; (block = GetBlock(rotate, -i, 0)) == null && i < 3; i++) ;//empty loop
            rotate = block != null ? block : rotate ;//updating rotated block
            for (int i = 0; (block = GetBlock(rotate, 0, -i)) == null && i < 3; i++) ;//empty loop with no body

            if (block == null)//failed to rotate
            {
                block = backup;
                return !Move(0, 0);//false since rotation failed
            }
            return Move(0, 0);//true if rotation is valid ; false otherwise.
        }
    }
}
