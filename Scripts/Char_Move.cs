using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Move : MonoBehaviour
{
    // 캐릭터 오브젝트
    public GameObject Chariter;

    // 캐릭터 스피드
    public float Speed;
    
    void Update()
    {
        // A키 혹은 왼쪽키를 눌렀을때
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // 왼쪽으로 이동
            Chariter.transform.Translate(new Vector3(-3,0,0) *Speed *Time.deltaTime);

            // 걷는 모션 실행
            Chariter.GetComponent<Animator>().Play("walking");

            // 왼쪽으로 방향 전환
            Chariter.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Chariter.transform.Translate(new Vector3(3, 0, 0) * Speed * Time.deltaTime);
            Chariter.GetComponent<Animator>().Play("walking");
            Chariter.GetComponent<SpriteRenderer>().flipX = true ;
        }
        else
        {
            Chariter.GetComponent<Animator>().Play("Charicter");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Chariter.transform.Translate(new Vector3(0,8,0) *Speed* Time.deltaTime);
            Chariter.GetComponent<Animator>().Play("Fly");
        }

        // 에리어를 벗어날시
        if (transform.position.y < -15)
        {
            // 에리어 공간으로 다시 복귀
            transform.Translate(new Vector3(0,15,0));
        }
    }
}
