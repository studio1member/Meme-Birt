using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public static Control instance;
    [SerializeField] private float Fly;
    public bool Die;
    private void Awake()
    {
        instance = this;
        this.Fly = Birt.instance.Fly;
    }
    public void _Fly()
    {
        if (Die) return;
        Birt.instance.bodyBirt.velocity = new Vector2(0, this.Fly);
    }
}
