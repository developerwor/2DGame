using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_fall : MonoBehaviour
{
    // Start is called before the first frame update
    float nRandom;
    float Rd_Position;
    float nMax = 0.4f;
    float nMin = -18;

    float Zero = -5;
    float Two = -1;
    float Three = -3;
    float Four = -8;
    void Start()
    {
        nRandom = Random.RandomRange(0, 4);
        Rd_Position = Random.RandomRange(nMin, nMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (nRandom == 0)
        {
                transform.Translate(new Vector3(0, Zero, 0) * 1f * Time.deltaTime);
                Debug.Log("현재 레벨 1의 속도로 블럭이 내려가고 있습니다.");
        }
        else if (nRandom == 1)
        {
            transform.Translate(new Vector3(0, Two, 0) * 2f * Time.deltaTime);
            Debug.Log("현재 레벨 2의 속도로 블럭이 내려가고 있습니다.");
        }
        else if (nRandom == 2)
        {
            transform.Translate(new Vector3(0, Three, 0) * 3f * Time.deltaTime);
            Debug.Log("현재 레벨 3의 속도로 블럭이 내려가고 있습니다.");
        }
        else if (nRandom == 3)
        {
            transform.Translate(new Vector3(0, Four, 0) * 4f * Time.deltaTime);
            Debug.Log("현재 레벨 4의 속도로 블럭이 내려가고 있습니다.");
        }
        if (transform.position.y < -7)
        {
            transform.position = new Vector3(Rd_Position, 10, 0);
            nRandom = Random.RandomRange(0, 4);
            Rd_Position = Random.RandomRange(8, -9);           
        }
    }
}
