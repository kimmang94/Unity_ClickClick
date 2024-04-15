using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroupManager : MonoBehaviour
{
    public static NoteGroupManager Instance;
    [SerializeField] private NoteGroup[] noteGroupClass;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }


    public void OnInput_Func(KeyCode keycode)
    {
        if (keycode == KeyCode.A)
        {
            this.noteGroupClass[0].OnInputFunc(true);
        }
        else
        {
            this.noteGroupClass[1].OnInputFunc(true);
        }

    }
}
