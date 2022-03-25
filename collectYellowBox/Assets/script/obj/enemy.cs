using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : item
{
    [SerializeField]
    public string tag = "player";

    private void Awake()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "BatasBawah")
        {
            obj.jumbalahPrefab -= 1;
            Destroy(this.gameObject);
        }
        else if (collision.transform.tag==tag)
        {
            obj.jumbalahPrefab--;
            gm.nyawa--;
            Destroy(gameObject);
        }
    }
}
