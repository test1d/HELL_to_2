using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public List<MonoBehaviour> backgroundList = new List<MonoBehaviour>();
    public MonoBehaviour player;
    public Camera mainCamera;
    public float speed;
    float halfWidth;

    // Start is called before the first frame update
    void Start()
    {
        halfWidth = mainCamera.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        var playerPos = player.transform.position;

        foreach (var item in backgroundList)
        {
            var itemPos = item.transform.position;

            if (playerPos.x + halfWidth > itemPos.x)
                itemPos = new Vector3(playerPos.x + halfWidth, itemPos.y, 0);
            else
                itemPos = new Vector3(itemPos.x - speed, itemPos.y, 0);
        }
    }
}
