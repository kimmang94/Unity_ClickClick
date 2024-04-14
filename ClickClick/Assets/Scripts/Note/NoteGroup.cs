using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroup : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 5;
    [SerializeField] private Note baseNoteClass = null;
    private List<Note> noteClassList;

    private void Awake()
    {
        this.noteClassList = new List<Note>();
    }

    // Start is called before the first frame update
    void Start()
    {
        var _noteClassObj = GameObject.Instantiate(this.baseNoteClass.gameObject);
        var _noteClass = _noteClassObj.GetComponent<Note>();

        this.noteClassList.Add( _noteClass );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
