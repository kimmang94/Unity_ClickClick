using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private Image scroeImg = null;
    [SerializeField] private TextMeshProUGUI scoreTmp = null;

    [SerializeField] private Image timerImg = null;
    [SerializeField] private TextMeshProUGUI timerTmp = null;

    private void Awake()
    {
        Instance = this;
    }

    public void OnScore(int _currentScore, int _maxScore)
    {
        scoreTmp.text = $"{_currentScore}/{_maxScore}";
        this.scroeImg.fillAmount = (float)_currentScore / _maxScore;
    }

    public void OnTimer(float _currentTimer, float _maxTimer)
    {
        timerTmp.text = $"{_currentTimer.ToString_Func(1)}/{_maxTimer.ToString_Func(1)}";
        this.timerImg.fillAmount = (float)_currentTimer / _maxTimer;
    }
}


