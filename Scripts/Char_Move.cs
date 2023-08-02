using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Move : MonoBehaviour
{
    public GameObject Chariter;
    public float Speed;
    bool Jumpcheck;
    float JumpTimecheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Chariter.transform.Translate(new Vector3(-3,0,0) *Speed *Time.deltaTime);
            Chariter.GetComponent<Animator>().Play("walking");
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

        if (transform.position.y < -15)
        {
            transform.Translate(new Vector3(0,15,0));
        }
    }
}
