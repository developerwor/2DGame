using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_fall : MonoBehaviour
{    
    // 블럭 타입 랜덤값
    float nRandom;

    // 블럭의 x값 랜덤값
    float Rd_Position;

    // 랜덤 최대값
    float nMax = 0.4f;
    
    // 랜덤 최소값
    float nMin = -18;

    //-------------블럭 위치값---------------//
    float Zero = -5;
    float Two = -1;
    float Three = -3;
    float Four = -8;    
    //-------------블럭 위치값---------------//
    
    void Start()
    {
        nRandom = Random.RandomRange(0, 4);
        Rd_Position = Random.RandomRange(nMin, nMax);
    }

    void Update()
    {
        //-------------블럭 낙하 스피드 타입---------------//
        if (nRandom == 0)
        {
            transform.Translate(new Vector3(0, Zero, 0) * 1f * Time.deltaTime);                
        }
        else if (nRandom == 1)
        {
            transform.Translate(new Vector3(0, Two, 0) * 2f * Time.deltaTime);            
        }
        else if (nRandom == 2)
        {
            transform.Translate(new Vector3(0, Three, 0) * 3f * Time.deltaTime);            
        }
        else if (nRandom == 3)
        {
            transform.Translate(new Vector3(0, Four, 0) * 4f * Time.deltaTime);
        }
        //-------------블럭 낙하 스피드 타입---------------//

        // 블럭이 에리어를 벗어나면
        if (transform.position.y < -7)
        {
            // 블럭의 위치 지정
            transform.position = new Vector3(Rd_Position, 10, 0);

            // 블럭의 타입 랜덤지정
            nRandom = Random.RandomRange(0, 4);

            // 다음 블럭의 x값 랜덤지정
            Rd_Position = Random.RandomRange(8, -9);           
        }
    }
}
