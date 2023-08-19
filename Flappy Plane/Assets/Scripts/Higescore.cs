using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Higescore : MonoBehaviour
{
    Scorer scorer;
    private void Start()
    {
        scorer = FindObjectOfType<Scorer>().GetComponent<Scorer>();
    }
    private void Update()
    {
        TrySetNewHigescore(scorer.score);
    }

    // Start is called before the first frame update
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
    




