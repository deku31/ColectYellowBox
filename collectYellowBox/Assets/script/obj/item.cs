using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public objScript obj;
    public gamemanager gm;
    public bool lvup;

    public Rigidbody2D rgbd;
    public float speed=10;

    [Header("gravitasi setting")]
    int randomGravity;
    [SerializeField] private int min;
    [SerializeField] private int max;

    private void Start()
    {
        randomGravity = Random.RandomRange(min, max);
        obj = FindObjectOfType<objScript>().GetComponent<objScript>();
        gm = FindObjectOfType<gamemanager>().GetComponent<gamemanager>();
    }
    void Update()
    {
        rgbd.gravityScale = randomGravity;
        lvupMethod();
        if (lvup)
        {
            min *= 2;
            max *= 2;
            lvup = false;
        }
    }
    void lvupMethod()//fungsi untuk menentukan lvup gravitasi
    {
        if (gm.score>10)
        {
            lvup = true;
        }
        else if (gm.score>20)
        {
            lvup=true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "BatasBawah")
        {
            obj.jumbalahPrefab -= 1;
            Destroy(this.gameObject);
        }
        else if (collision.transform.tag == "player")
        {
            gm.score++;
            obj.jumbalahPrefab -= 1;
            Destroy(this.gameObject);
        }
    }
}
