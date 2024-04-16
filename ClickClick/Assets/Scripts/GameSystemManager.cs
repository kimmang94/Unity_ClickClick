using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManager : MonoBehaviour
{
    public static GameSystemManager Instance;
    private int score;
    [SerializeField] private int maxScore;
    [SerializeField] private int noteGroupSpawnConditionScore = 10;
    private int nextNoteGroupUnLockCount;
    [SerializeField] private GameObject gameClear;
    [SerializeField] private GameObject gameOver;
    [SerializeField]  private float maxTime = 30f;

    public bool isGameDone => gameClear.activeSelf == true || gameOver.activeSelf == true;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UIManager.Instance.OnScore(this.score, maxScore);
        NoteGroupManager.Instance.Activate();
        StartCoroutine(OnTimer());
        gameClear.SetActive(false);
        gameOver.SetActive(false);
    }
    
    IEnumerator OnTimer()
    {
        float _currentTime = 0f;

        while (_currentTime < maxTime)
        {
            _currentTime += Time.deltaTime;

            UIManager.Instance.OnTimer(_currentTime, maxTime);

            yield return null;

            if (isGameDone ==true)
            {
                yield break;
            }
        }

        gameOver.SetActive(true);

    }

    public void OnScore(bool isCorrect)
    {
        if(isCorrect)
        {
            this.score++;
            nextNoteGroupUnLockCount++;

            if (noteGroupSpawnConditionScore <= nextNoteGroupUnLockCount)
            {
                nextNoteGroupUnLockCount = 0;
                NoteGroupManager.Instance.OnSpawnNoteGroup();
            }

            if (maxScore <= score)
            {
                gameClear.SetActive(true);
            }
        }
        else
        {
            this.score--;
        }

        UIManager.Instance.OnScore(this.score, maxScore);
    }

    public void CallBtn_Restart()
    {

    }
}
