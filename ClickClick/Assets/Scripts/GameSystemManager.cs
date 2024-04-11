using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManager : MonoBehaviour
{
    public static GameSystemManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
