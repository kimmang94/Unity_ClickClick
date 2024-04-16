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

    private void Awake()
    {
        Instance = this;
    }

    public void OnScore(int _currentScore, int _maxScore)
    {
        this.scoreTmp.text = $"{_currentScore}/{_maxScore}";
        Debug.Log($" this.scoreTmp.text {this.scoreTmp.text}");
        this.scroeImg.fillAmount = (float)_currentScore / _maxScore;
    }
}
