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


    // Update is called once per frame
    void Update()
    {
        
    }
}
