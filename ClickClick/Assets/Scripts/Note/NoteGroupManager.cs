using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteGroupManager : MonoBehaviour
{
    public static NoteGroupManager Instance;
    [SerializeField] private KeyCode[] initKeyCodeArr;
    [SerializeField] private NoteGroup baseNoteGroup = null;
    [SerializeField] private NoteGroup[] noteGroupClass;
    [SerializeField] private float noteGroupWidthInterval = 1f;
    private List<NoteGroup> noteGroupsClassList;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        noteGroupsClassList = new List<NoteGroup>();
    }

    public void Activate()
    {
        foreach (var _initKeyCode in initKeyCodeArr)
            this.OnSpawnNoteGroup(_initKeyCode);  
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
            Debug.Log(isSelected);
            noteGroup.OnInputFunc(isSelected);
        }
    }
}
