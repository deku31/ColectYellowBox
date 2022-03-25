using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objScript : MonoBehaviour
{
    public Canvas canvas;
    public Transform posprefab;

    public List<GameObject> prefab;

    public int jumbalahPrefab;
    [SerializeField]private int maxPrefab=10;

    public int acakItem;
    int noPrefab;

    [SerializeField] private gamemanager gm;
    private void Start()
    {
        acakItem = Random.RandomRange(0,prefab.Count);
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }
    private void Update()
    {
        if (gm.start==false)
        {
            if (jumbalahPrefab < maxPrefab)//memunculkan prefab sesuai jumalh
            {
                StartCoroutine(instanceobj());//memunculkan objek setelah 2detik
            }
            else
            {
                StopAllCoroutines();//menghentikan muncul objek
            }
        }
    }
    IEnumerator instanceobj()
    {
        yield return new WaitForSeconds(2f);

        Instantiate(prefab[acakItem],posprefab);
        jumbalahPrefab += 1;
        acakItem = Random.RandomRange(0, prefab.Count);
    }
}
