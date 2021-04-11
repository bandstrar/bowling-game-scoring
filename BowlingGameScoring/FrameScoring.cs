using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BowlingGameScoring
{
    public class FrameScoring
    {
        public int scoreByMultipleFrames(List<int> sequenceOfRolls)
        {
            var totalScore = 0;
            var firstRoll = 0;
            var secondRoll = 1;

            for (var i = 0; i < sequenceOfRolls.Count; i++)
                {
                if (sequenceOfRolls[firstRoll] == 10)
                {
                    if (secondRoll >= sequenceOfRolls.Count)
                    {
                        totalScore += 10;
                    }
                    else if (secondRoll + 1 >= sequenceOfRolls.Count)
                    {
                        totalScore += (10 + sequenceOfRolls[secondRoll]);
                    }
                    else
                    {
                        totalScore += (10 + (sequenceOfRolls[secondRoll] + sequenceOfRolls[secondRoll + 1]));
                    }
                    firstRoll += 1;
                    secondRoll += 1;
                }
                else if (sequenceOfRolls[firstRoll] + sequenceOfRolls[secondRoll] == 10)
                {
                    if (secondRoll + 1 >= sequenceOfRolls.Count)
                    {
                        totalScore += 10;
                    }
                    else
                    {
                        totalScore += (10 + sequenceOfRolls[secondRoll + 1]);
                    } 
                    firstRoll += 2;
                    secondRoll += 2;
                    i++;
                }
                else
                {
                    totalScore += (sequenceOfRolls[firstRoll] + sequenceOfRolls[secondRoll]);
                    firstRoll += 2;
                    secondRoll += 2;
                    i++;
                }   
            }
            return totalScore;
        }

    }
}
