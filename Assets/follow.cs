using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public int z = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint(
            new Vector3(mousePos.x, mousePos.y, z));
        transform.position = wantedPos;
    }
}
