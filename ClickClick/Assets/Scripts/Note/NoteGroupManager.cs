using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteGroupManager : MonoBehaviour
{
    public static NoteGroupManager Instance;

    [SerializeField] private NoteGroup baseNoteGroup = null;
    [SerializeField] private NoteGroup[] noteGroupClass;
    [SerializeField] private float noteGroupWidthInterval = 1f;
    private List<NoteGroup> noteGroupsClassList;
    [SerializeField] private int initNoteGroupNum = 2;
    private KeyCode[] wholekeyCodeArr = new KeyCode[]
        {
            KeyCode.A,
            KeyCode.S,
            KeyCode.D,
            KeyCode.F,
            KeyCode.G,
            KeyCode.H,
            KeyCode.J,
            KeyCode.K,
            KeyCode.L,
        };

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        noteGroupsClassList = new List<NoteGroup>();
    }

    public void Activate()
    {
        for (int i = 0; i < initNoteGroupNum; i++)
        {
            KeyCode _keyCode = wholekeyCodeArr[i];
            OnSpawnNoteGroup(_keyCode);
        }

    }
    public void OnSpawnNoteGroup()
    {
        int _noteGroupNum = noteGroupsClassList.Count;
        var _keyCode = wholekeyCodeArr[_noteGroupNum];
        OnSpawnNoteGroup(_keyCode);
    }


    public void OnSpawnNoteGroup(KeyCode _keyCode)
    {
        GameObject _noteGruopClassObj = GameObject.Instantiate(this.baseNoteGroup.gameObject);
        _noteGruopClassObj.transform.position = Vector3.right  * this.noteGroupWidthInterval* this.noteGroupsClassList.Count;

        NoteGroup _noteGroupClass = _noteGruopClassObj.GetComponent<NoteGroup>();
        _noteGroupClass.Activate(_keyCode);

        this.noteGroupsClassList.Add(_noteGroupClass);
    }

    public void OnInput_Func(KeyCode keycode)
    {
        int randID = Random.Range(0, this.noteGroupsClassList.Count);
        NoteGroup randomNoteGroupClass = this.noteGroupsClassList[randID];

        foreach (NoteGroup noteGroup in this.noteGroupsClassList)
        {
            noteGroup.OnSpawnNote(noteGroup == randomNoteGroupClass);
            bool isSelected = noteGroup.GetKeyCode == keycode;

            noteGroup.OnInputFunc(isSelected);
        }
    }
}
