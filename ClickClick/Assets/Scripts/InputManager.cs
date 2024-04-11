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
            Debug.Log("AŬ��!");
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("SŬ��!");
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("DŬ��!");
        }
    }
}
