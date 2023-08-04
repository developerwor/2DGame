using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_flowcam : MonoBehaviour
{    
    Transform CharPos;
    
    void Start()
    {
        // CharPos의 변수에 현재 Player라는 태그가 붙어 있는 오브젝트 trasnform값을 할당
        CharPos = GameObject.FindWithTag("Player").transform;
    }
    
    void Update()
    {
        // 카메라의 위치값이 플레이어의 x값만 따라갈수있도록 설정
        transform.position = new Vector3(CharPos.position.x, transform.position.y, transform.position.z);
    }
}
