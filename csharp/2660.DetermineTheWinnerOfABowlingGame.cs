// You are given two 0-indexed integer arrays player1 and player2, that represent the number of pins that player 1 and player 2 hit in a bowling game, respectively.

// The bowling game consists of n turns, and the number of pins in each turn is exactly 10.

// Assume a player hit xi pins in the ith turn. The value of the ith turn for the player is:

// 2xi if the player hit 10 pins in any of the previous two turns.
// Otherwise, It is xi.
// The score of the player is the sum of the values of their n turns.

// Return

// 1 if the score of player 1 is more than the score of player 2,
// 2 if the score of player 2 is more than the score of player 1, and
// 0 in case of a draw.

public class Solution {
    public int IsWinner(int[] player1, int[] player2) {
        
        int score1 = Score(player1);
        int score2 = Score(player2);

        if (score1 > score2)
            return 1;
        else if (score1 < score2)
            return 2;
        else
            return 0;
    }
    
    static int Score(int[] player)
    {
        int score = 0;
        int up = 0;

        for (int i = 0; i < player.Length; i++)
        {
            score += up > 0 ? player[i] * 2 : player[i];

            if (up > 0)
                up -= 1;

            if (player[i] == 10)
                up = 2;
        }

        return score;
    }
}