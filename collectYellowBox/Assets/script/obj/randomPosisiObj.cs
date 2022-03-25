using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPosisiObj : MonoBehaviour
{
    [Header("Random posisi")]
    private float randomX;
    private float randomY;
    [SerializeField] private Transform minPosX;
    [SerializeField] private Transform maxposX;
    [SerializeField] private float minPosY;
    [SerializeField] private float maxposY;

    Transform posperfab;

    public Transform parent;
    private void Awake()
    {
        maxposX = GameObject.Find("maxPosX").GetComponent<Transform>();
        minPosX = GameObject.Find("minPosX").GetComponent<Transform>();
        parent = GameObject.Find("Canvas").GetComponent<Transform>();
        posperfab = GameObject.Find("posprefab").GetComponent<Transform>();
    }
    private void Start()
    {
        randomX = Random.Range(minPosX.position.x, maxposX.position.x);
        randomY = Random.Range(minPosY, maxposY);

        transform.position = new Vector2( randomX, posperfab.position.y+randomY);
        //transform.SetParent(parent);
    }
    private void Update()
    {
        
    }
    
}
