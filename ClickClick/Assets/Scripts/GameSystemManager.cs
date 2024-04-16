using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManager : MonoBehaviour
{
    public static GameSystemManager Instance;
    private int score;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnScore(bool isCorrect)
    {
        if(isCorrect)
        {
            this.score++;
        }
        else
        {
            this.score--;
        }
    }
}
