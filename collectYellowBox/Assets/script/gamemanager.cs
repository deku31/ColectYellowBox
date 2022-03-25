using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum state{pause, resume}
public class gamemanager : MonoBehaviour
{
    public GameObject panelPlay;
    public  bool start=true;
    public int score=0;
    public int nyawa =3;
    public float time;

    public GameObject player;
    public Text scoreTxt;
    public Text nyawatxt;

    public state pause=state.resume;
    void Start()
    {
        nyawatxt.text = nyawa.ToString();
        start = true;
        if (start==true)
        {
            Time.timeScale = 0;
        }
        panelPlay.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (start==true)
        {
            if (Input.GetMouseButton(0))
            {
                panelPlay.SetActive(false);
                Time.timeScale = 1;
                start = false;
            }
        }
        
        if (nyawa==0)
        {
            nyawatxt.text = nyawa.ToString();
            StartCoroutine(gameover());
        }
        else
        {
            nyawatxt.text = nyawa.ToString();
            scoreTxt.text = score.ToString();
        }
    }
    IEnumerator gameover()
    {
        yield return new WaitForSeconds(0.3f);
        Time.timeScale = 0;
        StopAllCoroutines();
    }
    //tombol pause
    public void pausebtn()
    {
        if (pause==state.pause)
        {
            Time.timeScale = 1;
            pause = state.resume;
        }
        else
        {
            Time.timeScale = 0;
            pause = state.pause;
        }
    }
    public void restart(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
