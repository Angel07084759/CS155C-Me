/// CS155 Final Project Exercise No.: FinalProject 
/// File Name:          MainWindow.xaml.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// Problem Statement:  10 levels: increment of speed of the game per level
///                     500 per level
///                     10 points per cleared lines
///                      1 point per step in fast drop
///                     -5 for step in hold or move the block up.
/// Algorithm:
/// 1) Create a TetrisCell class:
///     Create constant for default cell values: color, id
///     Create constant for available color values
///     Create an id generator helper that keeps track of a current generated id.
///     Create Cell properties: Rectangle Cell, int ID
///     Create a Default Constructor that initializes properties to default values
///     Create a isEmpty method: return true if Cell if empty when ID = DEFAULT_ID
///     Override ToString and Equals
/// 2) Create a TetrisBlock class:
///     Create a Constant Default number of cell per block
///     Create a Rotation map based on a 4 x 4 array matrix
///     Create instance variables: int[,] block; TetrisCell[,] board;
///     Define TetrisBlock properties Id and color: int BlockID; SolidColorBrush BlockColor
///     Create a TetrisBlock constructor that receives a TetrisBord and block definition: block map and block color
///     Create a method CkeckBlockDef(int[,] block) that checks the definition of a block
///     Create a method PaintBlock(int[,] block, int id, SolidColorBrush color)
///         Paints a block with the given block map, id, and color. 
///     Create a method GetRow()
///         Finds and returns the current row of a tetris block in its given tetrisBoard
///     Create a method GetColumn()
///         Finds and returns the current column of a tetris block in its given tetrisBoard
///     Create a method GetBlock()
///         Returns a copy of the current block map
///     Create a method int[,] GetBlock(int[,] src, int moveRow, int moveCol)
///         Returns a copy of the current block map with a offset value
///         Returns null if the given offset values are result in index out of bounds
///         Or if current cell are occupied by other tetris block
///     Create a method bool Move(int row, int col)
///         Moves a tetris block at the given row and column values
///         Returns true if given values result in valid block move; false otherwise
///     Create a method bool Rotate()
///         Rotates clockwise this tetris cell
///         Returns true of rotation lays in a valid move; false otherwise
/// 3)Create a class Tetris:
///     Create constants for Default tetris board definition
///     Create constants for Tetris blocks map definition (int [,]).
///     Create instance variable for Definition of blocks to be manipulated throwout the game
///     Create instance variables for views components.
///     Create a Constructor initializes all of the essential components of the game.
///     Create a method TetrisBlock generateBlock()
///         that Generates Tetris blocks with random colors.
///     Create a method InitGrids() that Initializes the grids views of the game.
///     Create a method InitCells() that Initializes the tetris cells of the game
///     Create a method bool MoveBlock(int row, int col) that
///         Moves a tetris block at the given row and column values
///         Returns true if given values result in valid block move; false otherwise
///     Create a method bool RotateBlock() that 
///         Rotates clockwise this tetris cell
///         Returns true of rotation lays in a valid move; false otherwise
///     Create a method bool Spawn(int row, int col) that 
///         Spawns a new tetris at the given row and column values
///     Create a method Reset() that
///         Resets the game by clearing all of the current used cells in the board
///     Create a method PaintNextBlock() that
///         paints the next block in the next block grid definition
///     Create a method bool isRowFull(int row) that 
///         Checks if the given row index is full.
///         And return true if all of the cell are empty not empty; false otherwise.
///     Create a method clearRow(int row) that
///         Deletes the given row and pulls down the rest of the rows
///     Create a method clearRow() that
///         Deletes any row that is full; pulls down the rest of the rows; 
///         and updates scores by adding one  for each cleared row.
/// 4) Implement a TetrisGame:
///     Create Constants definitions spawns indexes and score and points values
///     Create instance variable to manipulate current score penalties counter
///     Define a method Dt_Tick(object sender, EventArgs e) to be used
///         with the legate of a dispatcher timer 
///         This method Runs the game by moving the blocks down or spawn a new block:
///             Gets values before tick
///             Calculates points, scores, etc.
///             Checks for achieved level: audio speed and game speed
///     Initializes the games components in Windows constructor
///         set dt_timer.Tick += Dt_Tick;
///     Create a method Window_KeyDown(object sender, KeyEventArgs e) to be used as
///         Game Control (keyboard key event handler) 
///             use keyboard keys: left, right, up, down, enter = rotate space = play/pause
///     Create a Help_Btn_Click(object sender, RoutedEventArgs e)
///         Display the ruels of the game
using System;
using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;//multi-threading

namespace FinalProject//SoundPlayer Branch Commit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constants definitions spawns indexes and score and points values
        private const int SPAWN_ROW = 0;
        private const int SPAWN_COLUMN = 3;
        private const int SCORE_PER_LEVEL = 500;
        private const int HOLD_UP_PENALTY = 5;
        private const int FAST_DROP_XTRA = 1;
        private const int SCORE_PER_CLEARED_LINE = 10;
        private const string AUDIO = "TetrisWav";//Audio prefix -audio suffix = LEVELS[index]
        private static readonly int[] LEVELS    = {  0,   2,   4,   6,   8,   10,   12,   13,   14,   15};
        private static readonly double[] SPEEDS = {1.0, 0.8, 0.6, 0.4, 0.2, 0.08, 0.06, 0.04, 0.02, 0.01};

        //Instance variables to manipulate values
        private int mScore;
        private int mPenalties;
        private int counter = 0;
        private Tetris tetris;
        private DispatcherTimer dt_timer;
        String audioPath = AppDomain.CurrentDomain.BaseDirectory + @"files\";
        SoundPlayer audio = null;

        //Constructor: initializes the games components
        public MainWindow()
        {
            InitializeComponent();
            tetris = new Tetris(board_grids, next_block_grids);

            dt_timer = new DispatcherTimer();
            dt_timer.Interval = TimeSpan.FromSeconds(SPEEDS[0]);
            dt_timer.Tick += Dt_Tick;//delegate: Runs the game by moving the blocks down or spawn a new block
            audio = new SoundPlayer(audioPath + AUDIO + (mScore / SCORE_PER_LEVEL));
        }

        //Runs the game by moving the blocks down or spawn a new block
        private void Dt_Tick(object sender, EventArgs e)
        {
            //Getting values before tick
            int rowsClr = tetris.RowsCleared;
            string level_check = level.Content.ToString();

            if (!(tetris.MoveBlock(1, 0)) && 0 != counter++)
            {
                if (!tetris.Spawn(SPAWN_ROW, SPAWN_COLUMN))
                {
                    counter = 0;
                    mScore = 0;
                    mPenalties = 0;
                    tetris.RowsCleared = 0;
                    audio.Stop();
                    dt_timer.Stop();
                    play.Content = "Game Over";
                    return;
                }
            }
            //Calculating points, scores, etc.
            mScore += SCORE_PER_CLEARED_LINE * (tetris.RowsCleared - rowsClr);
            level.Content = "" + (mScore / SCORE_PER_LEVEL);
            score.Content = "" + mScore;
            penalties.Content = "" + mPenalties;
            lines_cleared.Content = "" + tetris.RowsCleared;

            //Checking for achieved level: audio speed and game speed
            if ((!level.Content.Equals(level_check) && (mScore / SCORE_PER_LEVEL) < LEVELS.Length))
            {
                dt_timer.Interval = TimeSpan.FromSeconds(SPEEDS[mScore / SCORE_PER_LEVEL]);//throws exceptions
                audio.Stop();
                audio = new SoundPlayer(audioPath + "TetrisWav" + LEVELS[mScore / SCORE_PER_LEVEL]);
                audio.PlayLooping();
            }
        }

        //Game Control: keyboard key event handler
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (counter > 0 && !play.Content.Equals("paused"))
            {
                switch (e.Key)
                {
                    case Key.Up:
                        if (mScore >= HOLD_UP_PENALTY)
                        {
                            mScore -= HOLD_UP_PENALTY;
                            mPenalties += HOLD_UP_PENALTY;
                            tetris.MoveBlock(-1, 0);
                        }
                        break;
                    case Key.Down:
                        mScore += FAST_DROP_XTRA;
                        Dt_Tick(null, null);
                        break;
                    case Key.Right:
                        tetris.MoveBlock(0, 1);
                        break;
                    case Key.Left:
                        tetris.MoveBlock(0, -1);
                        break;
                    case Key.Enter:
                        tetris.RotateBlock();
                        break;
                }
            }
            if (e.Key == Key.Space)//Start/pause
            {
                play_pause_Click(play, null);
            }
        }

        //Play button definition
        private void play_pause_Click(object sender, RoutedEventArgs e)
        {
            if (0 == counter++)
            {
                tetris.Reset();
                tetris.Spawn(SPAWN_ROW, SPAWN_COLUMN);
                dt_timer.Start();
                audio.PlayLooping();
                play.Content = "playing";
            }
            else if (play.Content.Equals("playing"))
            { 
                play.Content = "paused";
                dt_timer.Stop();
            }
            else
            {
                play.Content = "playing";
                dt_timer.Start();
            }   
        }

        //Help button definition
        private void Help_Btn_Click(object sender, RoutedEventArgs e)
        {
            string msg = 
                "10 levels: increment of speed of the game per level\n" +
                "500 per level\n" +
                "10 points per cleared lines\n\n" + 
                String.Format("{0, -15}{1, -15}{2}\n", "BUTTON", "DETAILS", "PENALTIES") +
                String.Format("{0, -18}{1, -20}{2}\n", "[space]", "play/pause", "( 0 )") +
                String.Format("{0, -20}{1, -20}{2}\n", "   [^] ", "move up", "(-5 )") +
                String.Format("{0, -21}{1, -17}{2}\n", "   [v] ", "move down", "(+1)") +
                String.Format("{0, -20}{1, -21}{2}\n", "   [<] ", "move left", "( 0 )") +
                String.Format("{0, -20}{1, -20}{2}\n", "   [>] ", "move right", "( 0 )");

            if (0 == counter)//game is not running
            {
                MessageBox.Show(msg);
            }
            else//game is running
            {
                play.Content = "paused";
                dt_timer.Stop();
                MessageBox.Show(msg);
                play.Content = "playing";
                dt_timer.Start();
            }
        }
    }
}
