using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            NoteGroupManager.Instance.OnInput_Func(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            NoteGroupManager.Instance.OnInput_Func(KeyCode.S);
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            NoteGroupManager.Instance.OnInput_Func(KeyCode.D);
        }
    }
}
