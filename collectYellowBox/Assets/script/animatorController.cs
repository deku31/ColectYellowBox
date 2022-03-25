using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    public Animator AnimatorController;
    public bool walk;

    // Start is called before the first frame update
    void Start()
    {
        walk = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimatorController!=null)
        {
            gerakan();
        }
        else
        {
            Debug.Log("GameOver");//jika objek hilang atau tidak dimasukan akan memunculkan pesan gameover
        }
    }
    void gerakan()//method gerakan
    {
        AnimatorController.SetBool("walk", walk);
    }
}
