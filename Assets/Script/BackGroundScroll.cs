using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    public float Speed = 4f;
    public float EndSprite = -40f;

    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time .deltaTime);
        if (transform.position.y < EndSprite)
        {
            transform.position = StartPos;
        }
    }
}
