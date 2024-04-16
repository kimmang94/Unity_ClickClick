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

    private float maxTime = 30f;
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
    }
    
    IEnumerator OnTimer()
    {
        float _currentTime = 0;

        while (true)
        {
            _currentTime += Time.deltaTime;

            UIManager.Instance.OnTimer(_currentTime, maxTime);

            yield return null;
        }
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

        }
        else
        {
            this.score--;
        }

        UIManager.Instance.OnScore(this.score, maxScore);
    }
}
