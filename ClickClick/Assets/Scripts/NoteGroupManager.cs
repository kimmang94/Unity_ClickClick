using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroupManager : MonoBehaviour
{
    public static NoteGroupManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }


    public void OnInput_Func(KeyCode keycode)
    {
        Debug.Log(keycode + "키가 눌렷어요");
    }
}
