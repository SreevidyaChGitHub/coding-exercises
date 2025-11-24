/* Tic-tac-toe (Exercise sourced from Future Skill)

# PROBLEM
This is an exercise centered around tic-tac-toe, a common three-in-a-row children's game.
Level 3 :: Three in a row for O?

Does circles / "O" have three in a row? The possible ways to have three in a row is horizontal lines (three possible rows), vertical lines (three possible columns) or diagonals (two possibilities). 
For a board state to be considered three in a row for O all three squares in the line must have an "O" in the current board state.

The current board state is sent as the input variable 'board' for each of the level methods. In 'board' you will get all nine squares starting from bottom left, with ascending indexes from left to right, 
and the last and ninth square in the top right of the board.
Ex:- List of string :         ["", "O", "X", "O", "", "O", "X", "O", ""]
     Corresponding Indexes :    0   1    2    3    4   5    6    7   8

  NOTE: The change I made to this exercise is allowing the user to input the winlength size of this board. The board size is made dynamic here. 
# The image of the board of size 3*3 is attached in this repository.
# You can find it in the 'images' folder as 'Tic-tac-toe.png'.
*/

// SOLUTION 

// This solution works for any size of winlength. The winlenth can be provided by the user through this method. 

         /*
          Level 3 - Does circles / "O" have three in a row? The input 'board'
          parameter represent all nine squares, the current board state, in a
          list with the first index, zero, in the bottom left (x=0, y=0). Index
          1 is (x=1, y=0), index 2 is (x=2, y=0), index 3 is (x=0, y=1) and so
          forth. 
         */

        public bool Level3DoesOHave3InARow(List<string> board, winLength)
        {
            // Write your code here
            bool isWin=false;
            int count =0;
            // Checking for Horizontal wins
            for(int y=0;y<winLength*(winLength-1);y+=winLength)
            {
                for(int x=y;x<y+winLength;x++)
                {
                    if(board[x]=="O")
                    {
                        count++;
                        if(count==winLength)
                        isWin=true;
                        else
                        break;
                    }
                }
            }
            // Checking for Vertical wins
            count=0;
             for(int x=0;x<winLength;x++)
            {
                for(int y=x;y<=winLength*(winLength-1);y+=5)
                {
                    if(board[y]=="O")
                    {
                        count++;
                        if(count==winLength)
                        isWin=true;
                        else
                        break;
                    }
                }
            }
            // Checking for Diagonal wins
            // Left to Right
            count =0;
            for(int i=0;i<(winLength*winLength);i+=(winLength+1))
            {
                 if(board[i]=="O")
                    {
                        count++;
                        if(count==winLength)
                        isWin=true;
                        else
                        break;
                    }
            }
            // Right to Left
            for(int j=(winLength-1);j<=(winLength*(winLength-1));j+=(winLength-1))
             {
                 if(board[j]=="O")
                    {
                        count++;
                        if(count==winLength)
                        isWin=true;
                        else
                        break;
                    }
            }
            return isWin;
        }
    }
