using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    private List<KeyCode> keyCodeList;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        keyCodeList = new List<KeyCode>();
    }

    public void AddKeyCode(KeyCode _keyCode)
    {
        keyCodeList.Add(_keyCode);  
    }
    // Update is called once per frame
    void Update()
    {
        foreach (KeyCode _keyCode in keyCodeList) 
        { 
            if (Input.GetKeyDown(_keyCode) == true)
            {
                NoteGroupManager.Instance.OnInput_Func(_keyCode);
            }
        }

    }
}
