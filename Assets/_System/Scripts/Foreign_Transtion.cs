using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreign_Transtion : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(new Vector2(speed * -1, 0) * Time.deltaTime);
    }
}
