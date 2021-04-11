using System;
using Xunit;
using System.Collections.Generic;

namespace BowlingGameScoring.Tests
{
    public class CheckIfFrameScoreIsCorrect
    {
        [Fact]
        public void first_try_of_four_pins_and_second_try_of_three_pins_should_return_score_of_seven()
        {
            var sequenceOfRolls = new List<int>() { 4, 3 };
            var frameScoring = new FrameScoring();

            var actualScore = frameScoring.scoreByMultipleFrames(sequenceOfRolls);

            Assert.Equal(7, actualScore);
        }

        [Fact]
        public void spare_should_add_ten_plus_next_roll()
        {
            var sequenceOfRolls = new List<int>() { 7, 3, 2, 5 };
            var frameScoring = new FrameScoring();

            var actualScore = frameScoring.scoreByMultipleFrames(sequenceOfRolls);

            Assert.Equal(19, actualScore);
        }

        [Fact]
        public void strike_should_add_ten_plus_next_two_rolls()
        {
            var sequenceOfRolls = new List<int>() { 7, 2, 10, 5, 4 };
            var frameScoring = new FrameScoring();

            var actualScore = frameScoring.scoreByMultipleFrames(sequenceOfRolls);

            Assert.Equal(37, actualScore);
        }

        [Fact]
        public void strike_will_not_add_more_if_it_is_the_last_frame()
        {
            var sequenceOfRolls = new List<int>() { 7, 2, 5, 4, 3, 7, 10 };
            var frameScoring = new FrameScoring();

            var actualScore = frameScoring.scoreByMultipleFrames(sequenceOfRolls);

            Assert.Equal(48, actualScore);
        }
    }
}
