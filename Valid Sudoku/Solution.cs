public class Solution
{
    public bool ValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char val = board[r][c];

                if (val == '.') continue;

                //Calculate boxIdx each cell belongs to
                int boxIdx = (r / 3) * 3 + (c / 3);

                //Check if row, column or current box contains the value we are
                //trying to add into the current cell
                //boxes[boxIdx] -> has this number already appeared in current 3x3
                if (rows[r].Contains(val) || cols[c].Contains(val) || boxes[boxIdx].Contains(val))
                {
                    return false;
                }

                rows[r].Add(val);
                cols[c].Add(val);
                boxes[boxIdx].Add(val);
            }
        }

        return true;
    }
}