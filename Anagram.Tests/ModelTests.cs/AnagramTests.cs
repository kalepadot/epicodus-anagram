using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System; 

namespace Anagram.Tests
{
  [TestClass]
  public class Anagram : IDisposable
  {
    public void Dispose()
    {
      UserInput.ClearAll();
    }

    [TestMethod]
    public void InputConstructor_CreatesInstanceOfUserInput_UserImput()
    {
      // Arrange
      string string1 = "cat";
      List<string> list1 = new List<string> { "act","at", "home", "a", "pokemon" };
      UserInput newUserInput = new UserInput(string1, list1);

      // Act
      

      // Assert
      Assert.AreEqual(string1, newUserInput.UserWord);

    }
    [TestMethod]
    public void AnagramChecker_CheckForSingleLetterMatches_Act()
    {
      // Arrange
      string string1 = "cat";
      List<string> list1 = new List<string> {"act"};
      UserInput newUserInput = new UserInput(string1, list1);
      
      // Act
      List<string> anagramList = newUserInput.AnagramChecker();

      // Assert
      CollectionAssert.AreEqual(list1, anagramList);
    }

    [TestMethod]
    public void AnagramChecker_CheckForNonAnagrams_Lives()
    {
      // Arrange
      string string1 = "elvis";
      List<string> list1 = new List<string>{"lives", "Priscilla", "toilet", "pickles"};
      UserInput newUserInput = new UserInput(string1, list1);
      List<string> expectedList = new List<string>{"lives"};
      
      // Act
      List<string> anagramList = newUserInput.AnagramChecker();
      foreach (string item in anagramList)
      {
        Console.WriteLine(item);
      }
      // Assert
      CollectionAssert.AreEqual(expectedList, anagramList);
    }

  }
}