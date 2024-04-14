using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroup : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 5;
    [SerializeField] private Note baseNoteClass = null;
    
    [SerializeField] private Transform noteSpawnTrf = null;
    [SerializeField] private SpriteRenderer btnSrdr = null;
    [SerializeField] private Sprite normalBtnSprite = null;
    [SerializeField] private Sprite selectBtnSprite = null;
    [SerializeField] private Animation anim = null;
    private List<Note> noteClassList;

    private float noteGapInterval = 8f;

    private void Awake()
    {
        this.noteClassList = new List<Note>();
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < this.noteMaxNum; i++)
        {
            var _noteClassObj = GameObject.Instantiate(this.baseNoteClass.gameObject);
            _noteClassObj.transform.SetParent(this.noteSpawnTrf);
            _noteClassObj.transform.localPosition = Vector3.up * this.noteClassList.Count * this.noteGapInterval;
            var _noteClass = _noteClassObj.GetComponent<Note>();

            this.noteClassList.Add(_noteClass);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInputFunc(bool _isSelected)
    {
        if (_isSelected)
        {
            this.btnSrdr.sprite = this.selectBtnSprite;
            this.anim.Play();
        }
    }

    public void CallAni_Done()
    {
        this.btnSrdr.sprite = this.normalBtnSprite;
    }
}
