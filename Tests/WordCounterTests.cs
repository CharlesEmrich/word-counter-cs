using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class WordCounterTest
  {
    [Fact]
    public void CountRepeats_WordAppears_CatOne()
    {
      //Arrange
      RepeatCounter instance = new RepeatCounter("the cat is fast", "cat");
      Dictionary<string, int> expectedOutput = new Dictionary<string, int> {{"cat", 1}};
      //Act
      Dictionary<string, int> output = instance.CountRepeats();
      //Assert
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_WordsAppearOnce_CatOneFastOne()
    {
      //Arrange
      RepeatCounter instance = new RepeatCounter("the cat is fast", "cat fast");
      Dictionary<string, int> expectedOutput = new Dictionary<string, int> {{"cat", 1}, {"fast", 1}};
      //Act
      Dictionary<string, int> output = instance.CountRepeats();
      //Assert
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_WordDoesntAppear_CatOneDogZero()
    {
      //Arrange
      RepeatCounter instance = new RepeatCounter("the cat is fast", "cat dog");
      Dictionary<string, int> expectedOutput = new Dictionary<string, int> {{"cat", 1}, {"dog", 0}};
      //Act
      Dictionary<string, int> output = instance.CountRepeats();
      //Assert
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_WordAppearsTwice_CatTwo()
    {
      //Arrange
      RepeatCounter instance = new RepeatCounter("that cat is one fast cat", "cat");
      Dictionary<string, int> expectedOutput = new Dictionary<string, int> {{"cat", 2}};
      //Act
      Dictionary<string, int> output = instance.CountRepeats();
      //Assert
      Assert.Equal(expectedOutput, output);
    }
    [Fact]
    public void CountRepeats_MultipleWordsAppearsTwice_CatTwoTheTwo()
    {
      //Arrange
      RepeatCounter instance = new RepeatCounter("the cat is the fastest cat", "cat the");
      Dictionary<string, int> expectedOutput = new Dictionary<string, int> {{"cat", 2}, {"the", 2}};
      //Act
      Dictionary<string, int> output = instance.CountRepeats();
      //Assert
      Assert.Equal(expectedOutput, output);
    }
  }
}
