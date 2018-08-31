namespace _06ConnectedAreasInAMatrix
{
    using System;

    public class ComparingArea : IComparable<ComparingArea>
    {
        public ComparingArea(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public int CompareTo(ComparingArea other)
        {
            if (this.Size.CompareTo(other.Size) != 0)
            {
                return -1 * this.Size.CompareTo(other.Size);
            }

            if (this.Row.CompareTo(other.Row) != 0)
            {
                return this.Row.CompareTo(other.Row);
            }

            return this.Col.CompareTo(other.Col);
        }

        public override string ToString()
        {
            return $"({this.Row}, {this.Col}), size: {this.Size}";
        }
    }
}
