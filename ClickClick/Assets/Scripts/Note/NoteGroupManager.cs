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
        int randID = Random.Range(0, this.noteGroupClass.Length);
        NoteGroup randomNoteGroupClass = this.noteGroupClass[randID];

        foreach (NoteGroup noteGroup in this.noteGroupClass)
        {
            noteGroup.OnSpawnNote(noteGroup == randomNoteGroupClass);
        }

        if (keycode == KeyCode.A)
        {
            this.noteGroupClass[0].OnInputFunc(true);
        }
        else if (keycode == KeyCode.S)
        {
            this.noteGroupClass[1].OnInputFunc(false); 
        }


    }
}
