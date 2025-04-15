using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Foreign_Objects : MonoBehaviour
{
    private GameObject foreignObject;
    [SerializeField] private float timer;
    private void Awake()
    {
        foreignObject = GameObject.Find("Foreign Object");
        foreignObject.SetActive(false);
    }
    private void Start()
    {
        StartCoroutine(spawnForeignObject());
    }
    IEnumerator spawnForeignObject()
    {
        yield return new WaitForSeconds(timer);
        GameObject ins = Instantiate(foreignObject);
        ins.SetActive(true);
        ins.transform.position = transform.position;
        StartCoroutine(spawnForeignObject());
    }
}
