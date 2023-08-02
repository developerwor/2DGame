using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_flowcam : MonoBehaviour
{
    // Start is called before the first frame update
    Transform CharPos;
    void Start()
    {
        CharPos = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(CharPos.position.x, transform.position.y, transform.position.z);
    }
}
