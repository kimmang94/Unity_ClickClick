using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public void DeActivate()
    {
        GameObject.Destroy(this.gameObject);
    }
}
