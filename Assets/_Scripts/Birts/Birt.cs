using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Birt : MonoBehaviour
{
    public static Birt instance;
    public Rigidbody2D bodyBirt;

    [Header("Index")]
    public float Fly;
    public bool Die;
    private void Awake()
    {
        instance = this;
        bodyBirt = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") && !Die)
        {
            Die = true;
            StartCoroutine(_Die());
        }
        if(collision.gameObject.CompareTag("Point") && !Die)
        {
            Debug.Log("Add Point");
        }
    }
    private IEnumerator _Die()
    {
        Control.instance.Die = true;
        bodyBirt.velocity = new Vector2(0, 10f);
        yield return new WaitForSeconds(2f);
        bodyBirt.bodyType = RigidbodyType2D.Kinematic;
        bodyBirt.velocity = Vector2.zero;
    }
}
