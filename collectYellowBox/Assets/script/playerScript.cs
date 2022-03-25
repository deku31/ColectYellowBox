using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D playerobj;//objek player
    public float speed = 5;
    float x;
    int flip;
    public GameObject playerbody;

    //animator
    [SerializeField] private animatorController anim;

    private void Awake()
    {
        //anim = GetComponent<animatorController>();
    }
    private void Start()
    {
        flip = 1;
    }
    private void Update()
    {
        move();
    }
    //metod untuk menggerakan player
    void move()
    {
        x = Input.GetAxis("Horizontal");//untuk menerima input horizontal
        if (x != 0) {
            anim.walk = true;
            if (x < 0)
            {
                flip = -1;
            }
            else if (x > 0)
            {
                flip = 1;
            }
        }
        else
        {
            anim.walk = false;
        }

        playerbody.transform.localScale = new Vector2(flip, 1);
        x *= speed * 10;
        Vector2 move = new Vector2(x, 0);
        playerobj.velocity = move;
    }
}
