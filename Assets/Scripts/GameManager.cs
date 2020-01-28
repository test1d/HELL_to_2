using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public DialogueManager manager;


    void Awake()
    {
        if (DialogueManager.instance == null)
        {
            Instantiate(manager);
        }

        DontDestroyOnLoad(gameObject);
    }
}
