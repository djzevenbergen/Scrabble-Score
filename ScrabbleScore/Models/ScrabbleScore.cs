using System;
using System.Collections.Generic;
namespace ScrabbleScore.Models{
  public class ScrabbleGame{
    public string Word{get;set;}
    public int Score{get;set;}

    public ScrabbleGame(string word){
      Word = word;
      Score = GetScore(word);
    }

    public int GetScore(string word)
    {
      int totalPoints = 0;
      List<List <char>> charArrays = new List<List <char>>(){new List<char>() {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}, new List<char>() {'D', 'G'},new List<char>() {'B', 'C', 'M', 'P'}, new List<char>() {'F', 'H', 'V', 'W', 'Y' }, new List<char>() {'K'}, new List<char>() {'J', 'X'}, new List<char>() {'Q', 'Z'}};
     // charArrays = ;
      List<int> intList = new List<int> {};
      string userWord = word;
      char[] wordArray = userWord.ToCharArray(); 

     
      foreach(char letter in wordArray)
      {
        for (int i = 0; i < charArrays.Count; i++ )
        {
          if(charArrays[i].Contains(letter))
          {
            intList.Add(i);
          }
        }
      }
      
      foreach(int j in intList)
      {
        switch(j)
        {
          case 0:
            totalPoints += 1;
            break;
          case 1:
            totalPoints += 2;
            break;
          case 2:
            totalPoints += 3;
            break;
          case 3:
            totalPoints += 4;
            break;
          case 4:
            totalPoints += 5;
            break;
          case 5:
            totalPoints += 8;
            break;
          case 6:
            totalPoints += 10;
            break;
          default:
            break;
        }
      }
      return totalPoints;

      // int score = 8;
      // return score;
    }
  }
}


/*
List<char[]> charArrays = new List<char[]> {[A, E, I, O, U, L, N, R, S, T],[D, G],[B, C, M, P],[F, H, V, W, Y ],[K],[J, X],[Q, Z]}
List<int> intList = new List<int> {};
string word = word;
char[] wordArray = word.ToCharArray(); 
foreach(letter in wordArray)
{
  for (int i = 0; i < charArrays.Count; i++ )
  {
    if(charArrays[i].Contains(letter))
    {
      intList.Add(i);
    }
  }
}
*/
/*
List<List<int>> myList = new List<List<int>>(){{'A',2,3},{4,5,6},{7,8,9}};
int arr[] ={1,2,3}
List<int> list;
char [] letter = word.ToCharArray();
  for(int i=0;i<letter.Count;i++){
if(letter[i]== 'a' || letter[i] == 'i' )
   list.Add(1);
  }
*/






/*
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10
*/




