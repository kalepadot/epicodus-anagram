
using System.Collections.Generic;
using System.Collections;
using System;

namespace Anagram.Models
{
  public class UserInput
  {
    public string UserWord {get; set;}
    public List<string> UserList = new List<string> {};
    private static List<string> _anagramList = new List<string> {};
    public UserInput(string userWord, List<string> userList)
    {
      UserWord = userWord;
      UserList = userList;
      
      // return _anagramList;
    }
    public List<string> AnagramChecker()
    {
      char[] splitWord = UserWord.ToCharArray();
      int letterCounter = 0;
      foreach(string word in UserList)
      {
        char[] splitListWord = word.ToCharArray();
        
        for (int i = 0; i < splitListWord.Length; i++)
        {
          if (UserWord.Contains(splitListWord[i]))
          {
            letterCounter++;
          }
        }
        if (letterCounter == splitListWord.Length)
        {
          string joinedListWord = string.Join("", splitListWord);
          _anagramList.Add(joinedListWord);
        }
      }
      return _anagramList;
    }
    public static List<string> GetAll()
    {
      return _anagramList;
    }
    public static void ClearAll()
    {
      _anagramList.Clear();
    }
    // words ends below
  }
  

}