using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private SpriteRenderer srdr;
    [SerializeField] private Sprite appleSprite;
    [SerializeField] private Sprite blueberrySprite;
    public void Activate(bool isApple)
    {
        //Sprite sprite = isApple ? appleSprite : blueberrySprite;

        if (isApple)
        {
            srdr.sprite = appleSprite;
        }
        else
        {
            srdr.sprite = blueberrySprite;
        }
    }
    public void DeActivate()
    {
        GameObject.Destroy(this.gameObject);
    }
}
