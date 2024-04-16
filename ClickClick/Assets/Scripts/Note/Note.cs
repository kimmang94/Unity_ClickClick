using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private SpriteRenderer srdr;
    [SerializeField] private Sprite appleSprite;
    [SerializeField] private Sprite blueberrySprite;
    private bool isApple;
    public void Activate(bool _isApple)
    {
        //Sprite sprite = isApple ? appleSprite : blueberrySprite;
        this.isApple = _isApple;
        if (_isApple)
        {
            srdr.sprite = appleSprite;
        }
        else
        {
            srdr.sprite = blueberrySprite;
        }
    }

    public void OnInput(bool isSelected)
    {
        if (isSelected == true)
        {
            bool _isCorrect = this.isApple == true;
            GameSystemManager.Instance.OnScore(_isCorrect);
        }
        this.DeActivate();
    }
    public void DeActivate()
    {
        GameObject.Destroy(this.gameObject);
    }
}
