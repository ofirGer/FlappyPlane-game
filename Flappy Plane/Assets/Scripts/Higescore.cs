using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Higescore : MonoBehaviour
{
   
    private void Start()
    {        
      // ResetScore();
    }

    private static void ResetScore()
    {
        PlayerPrefs.SetInt("higescore", 0);
        PlayerPrefs.Save();
    }

    public  int GetHigescore()
    {
        return PlayerPrefs.GetInt("higescore");
    }

    public  bool TrySetNewHigescore(int score)
    {
        int currentHigescore = GetHigescore();
        if (score > currentHigescore)
        {
            PlayerPrefs.SetInt("higescore", score);
            PlayerPrefs.Save();
            return true;         
        }
        else
        {
            return false;
        }
    }
}
    




