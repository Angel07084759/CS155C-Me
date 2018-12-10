/// CS155 Final Project Exercise No.: FinalProject 
/// File Name:          TetrisCell.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// TetrisCell Represents A single cell of tetris: cell color and cell id

using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FinalProject
{
    class TetrisCell
    {
        //Default definitions of tetris cells
        public const double MARGIN = 1.0;
        public const int DEFAULT_ID = 0;
        public static  SolidColorBrush DEFAULT_COLOR = Brushes.LightSlateGray;
        public static readonly SolidColorBrush CYAN = Brushes.Cyan;
        public static readonly SolidColorBrush BLUE = Brushes.Blue;
        public static readonly SolidColorBrush ORANGE = Brushes.Orange;
        public static readonly SolidColorBrush YELLOW = Brushes.Yellow;
        public static readonly SolidColorBrush GREEN = Brushes.Green;
        public static readonly SolidColorBrush PURPLE = Brushes.Purple;
        public static readonly SolidColorBrush RED = Brushes.Red;
        public static readonly SolidColorBrush BLACK = Brushes.Black;
        public static readonly SolidColorBrush[] COLORS = { CYAN, BLUE, ORANGE, YELLOW, GREEN, PURPLE, RED, BLACK};

        //id generator helper
        private static int idGenerator = 1;
        //Tetris cells properties
        public Rectangle Cell { get; set; }
        public int ID { get; set; }

        //Default Constructor initializes properties to default values
        public TetrisCell()
        { 
            ID = DEFAULT_ID;
            Cell = new Rectangle();
            Cell.Fill = DEFAULT_COLOR;
            Cell.Margin = new Thickness(MARGIN);
        }

        //Generates uniques ID
        public static int GenerateID()
        {
            return idGenerator++;
        }

        //return true if Cell if empty when ID = DEFAULT_ID
        public bool isEmpty()
        {
            return ID == DEFAULT_ID;
        }

        //Returns Tetris cell properties values
        public override string ToString()
        {
            return "ID[" + ID + "] COLOR[" + Cell.Fill + "]";
        }

        //Compares two Tetris cells by ID and color
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType ())
            {
                return false;
            }
            TetrisCell other = (TetrisCell)obj;
            return ID == other.ID && Cell.Fill.Equals(other.Cell.Fill);
        }
    }
}
