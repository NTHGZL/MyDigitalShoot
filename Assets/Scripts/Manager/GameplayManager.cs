using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameplayManager Instance;
        
    

    // Update is called once per frame
    private void Awake()
    {
        Instance = this;
    }
}
