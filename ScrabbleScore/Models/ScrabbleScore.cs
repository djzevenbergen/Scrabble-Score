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
      int score = 8;
      return score;
    }
  }
}













/*
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10
*/




